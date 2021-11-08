using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;
using Sockets.Plugin;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Android.Database;
using Plugin.Settings;
using Android.Graphics;

namespace MenuActionBar
{
    [Activity(Label = "Выбор адреса")]
    public class AddEditIPActivity : Activity
    {

        Button txtIpAddres1, txtIpAddres2, txtIpAddres3, txtIpAddres4, txtIpAddres5, txtIpAddres6, txtIpAddres7, txtIpAddres8, PingClickButton;
        TextView txtId, txtNameFerms, txtAPIPAddres, txtprogressBarText;
        ProgressBar progressBar;

        public int timeout = 150;
        public string data = ".......................";
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        public bool PingClick = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AddEditIP);



            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);

            progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);

            PingClickButton = FindViewById<Button>(Resource.Id.addEdit_PingClick);
            PingClickButton.Click += PingClickButtonClick;

            txtprogressBarText = FindViewById<TextView>(Resource.Id.progressBarText);

            txtId = FindViewById<TextView>(Resource.Id.addEdit_ContactId);
            txtNameFerms = FindViewById<TextView>(Resource.Id.addEdit_NameFerms);

            txtIpAddres1 = FindViewById<Button>(Resource.Id.addEdit_IpAddres1);
            txtIpAddres1.Click += txtIpAddres1Click;

            txtIpAddres2 = FindViewById<Button>(Resource.Id.addEdit_IpAddres2);
            txtIpAddres2.Click += txtIpAddres2Click;

            txtIpAddres3 = FindViewById<Button>(Resource.Id.addEdit_IpAddres3);
            txtIpAddres3.Click += txtIpAddres3Click;

            txtIpAddres4 = FindViewById<Button>(Resource.Id.addEdit_IpAddres4);
            txtIpAddres4.Click += txtIpAddres4Click;

            txtIpAddres5 = FindViewById<Button>(Resource.Id.addEdit_IpAddres5);
            txtIpAddres5.Click += txtIpAddres5Click;

            txtIpAddres6 = FindViewById<Button>(Resource.Id.addEdit_IpAddres6);
            txtIpAddres6.Click += txtIpAddres6Click;

            txtIpAddres7 = FindViewById<Button>(Resource.Id.addEdit_IpAddres7);
            txtIpAddres7.Click += txtIpAddres7Click;

            txtIpAddres8 = FindViewById<Button>(Resource.Id.addEdit_IpAddres8);
            txtIpAddres8.Click += txtIpAddres8Click;

            txtAPIPAddres = FindViewById<TextView>(Resource.Id.addEdit_APIPAddres);

            string editId = Intent.GetStringExtra("ContactId") ?? string.Empty;

            if (editId.Trim().Length > 0)
            {
                txtId.Text = editId;
                LoadDataForEdit(editId);
            }



        }




        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }



        private void LoadDataForEdit(string contactId)
        {


            AddressBookDbHelper db = new AddressBookDbHelper(this);
            ICursor cData = db.getContactById(int.Parse(contactId));
            if (cData.MoveToFirst())
            {
                txtNameFerms.Text = "Ферма: " + cData.GetString(cData.GetColumnIndex("NameFerms"));
                txtAPIPAddres.Text = cData.GetString(cData.GetColumnIndex("APIPAddres"));
                txtIpAddres1.Text = cData.GetString(cData.GetColumnIndex("IpAddres1"));
                txtIpAddres2.Text = cData.GetString(cData.GetColumnIndex("IpAddres2"));
                txtIpAddres3.Text = cData.GetString(cData.GetColumnIndex("IpAddres3"));
                txtIpAddres4.Text = cData.GetString(cData.GetColumnIndex("IpAddres4"));
                txtIpAddres5.Text = cData.GetString(cData.GetColumnIndex("IpAddres5"));
                txtIpAddres6.Text = cData.GetString(cData.GetColumnIndex("IpAddres6"));
                txtIpAddres7.Text = cData.GetString(cData.GetColumnIndex("IpAddres7"));
                txtIpAddres8.Text = cData.GetString(cData.GetColumnIndex("IpAddres8"));
               
            }

            if (txtIpAddres1.Text == "")
            {

                txtIpAddres1.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres2.Text == "")
            {

                txtIpAddres2.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres3.Text == "")
            {

                txtIpAddres3.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres4.Text == "")
            {

                txtIpAddres4.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres5.Text == "")
            {

                txtIpAddres5.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres6.Text == "")
            {

                txtIpAddres6.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres7.Text == "")
            {

                txtIpAddres7.Visibility = ViewStates.Invisible;


            }
            if (txtIpAddres8.Text == "")
            {

                txtIpAddres8.Visibility = ViewStates.Invisible;


            }



        }


        public void StartTimer(TimeSpan interval, Func<bool> callback)
        {
            var handler = new Handler(Looper.MainLooper);
            handler.PostDelayed(() => {
                if (callback())
                    StartTimer(interval, callback);

                handler.Dispose();
                handler = null;
            }, (long)interval.TotalMilliseconds);
        }


        private void txtIpAddres1Click(object sender, EventArgs eventArgs)
        {


            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres1.Text);
            StartActivity(intent);

        }

        private void txtIpAddres2Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres2.Text);
            StartActivity(intent);

        }

        private void txtIpAddres3Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres3.Text);
            StartActivity(intent);

        }

        private void txtIpAddres4Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres4.Text);
            StartActivity(intent);

        }


        private void txtIpAddres5Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres5.Text);
            StartActivity(intent);

        }


        private void txtIpAddres6Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres6.Text);
            StartActivity(intent);

        }

        private void txtIpAddres7Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres7.Text);
            StartActivity(intent);

        }

        private void txtIpAddres8Click(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", txtIpAddres8.Text);
            StartActivity(intent);

        }

        private void PingClickButtonClick(object sender, EventArgs eventArgs)
        {


            if (txtAPIPAddres.Text != "")
            {
                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;



                StartTimer(TimeSpan.FromSeconds(1), () => {

                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtAPIPAddres.Text, timeout, buffer, options);


                    if (reply.Status == IPStatus.Success)
                    {
                        
                        txtAPIPAddres.SetTextColor(color: Color.DarkGreen);
                        txtAPIPAddres.SetBackgroundColor(color: Color.LightGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;

                    }
                    else
                    {
                        
                        txtAPIPAddres.SetTextColor(color: Color.Red);
                        txtAPIPAddres.SetBackgroundColor(color: Color.LightPink);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }


                    return false; // True = Repeat again, False = Stop the timer
                });

            }



            if (txtIpAddres1.Text != "")
            {
                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;



                StartTimer(TimeSpan.FromSeconds(1), () => {

                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres1.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres1.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        txtIpAddres1.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;
                    }


                    return false; // True = Repeat again, False = Stop the timer
                });

            }


            if (txtIpAddres2.Text != "")
            {
                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres2.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres2.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        txtIpAddres2.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }

            if (txtIpAddres3.Text != "")
            {

                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres3.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres3.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    else
                    {
                        txtIpAddres3.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }

            if (txtIpAddres4.Text != "")
            {

                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres4.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres4.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    else
                    {
                        txtIpAddres4.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;



                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }

            if (txtIpAddres5.Text != "")
            {

                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres5.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres5.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    else
                    {
                        txtIpAddres5.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }

            if (txtIpAddres6.Text != "")
            {
                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres6.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres6.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;



                    }
                    else
                    {
                        txtIpAddres6.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }

            if (txtIpAddres7.Text != "")
            {
                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres7.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres7.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;



                    }
                    else
                    {
                        txtIpAddres7.SetTextColor(color: Color.Red);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;


                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }

            if (txtIpAddres8.Text != "")
            {
                progressBar.Visibility = ViewStates.Visible;
                txtprogressBarText.Visibility = ViewStates.Visible;


                StartTimer(TimeSpan.FromSeconds(1), () => {
                    options.DontFragment = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(data);

                    PingReply reply = pingSender.Send(txtIpAddres8.Text, timeout, buffer, options);
                    if (reply.Status == IPStatus.Success)
                    {
                        txtIpAddres8.SetTextColor(color: Color.DarkGreen);
                        progressBar.Visibility = ViewStates.Invisible;
                        txtprogressBarText.Visibility = ViewStates.Invisible;



                    }
                    else
                    {
                        txtIpAddres8.SetTextColor(color: Color.Red);
                        txtprogressBarText.Visibility = ViewStates.Invisible;
                        progressBar.Visibility = ViewStates.Invisible;

                    }
                    return false; // True = Repeat again, False = Stop the timer
                });
            }
        }
    }
}