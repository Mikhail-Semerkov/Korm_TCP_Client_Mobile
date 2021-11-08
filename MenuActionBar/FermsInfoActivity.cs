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
using System.Text.RegularExpressions;
using Android.Graphics;

namespace MenuActionBar
{
    [Activity(Label = "Информация по ферме")]
    public class FermsInfoActivity : Activity
    {

        TextView txtId, txtNameFerms, txtNumberFerms, txtPodrazdelenie, txtNameAPP, txtTelefonStacionar, txtNameAdministrator, txtMobileAdministrator, txtNameRukovoditel, txtMobileRukovoditel, txtAPIPAddres, txtIpAddres1, txtIpAddres2, txtIpAddres3, txtIpAddres4, txtIpAddres5, txtIpAddres6, txtIpAddres7, txtIpAddres8, txtDetails, txtLocation;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.InfoFerms);


            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);


            txtId = FindViewById<TextView>(Resource.Id.addEdit_ContactId);
            txtNameFerms = FindViewById<TextView>(Resource.Id.addEdit_NameFerms);
            txtNumberFerms = FindViewById<TextView>(Resource.Id.addEdit_NumberFerms);
            txtPodrazdelenie = FindViewById<TextView>(Resource.Id.addEdit_Podrazdelenie);
            txtNameAPP = FindViewById<TextView>(Resource.Id.addEdit_NameAPP);
            txtTelefonStacionar = FindViewById<TextView>(Resource.Id.addEdit_TelefonStacionar);
            txtNameAdministrator = FindViewById<TextView>(Resource.Id.addEdit_NameAdministrator);
            txtMobileAdministrator = FindViewById<TextView>(Resource.Id.addEdit_MobileAdministrator);
            txtNameRukovoditel = FindViewById<TextView>(Resource.Id.addEdit_NameRukovoditel);
            txtMobileRukovoditel = FindViewById<TextView>(Resource.Id.addEdit_MobileRukovoditel);
            txtAPIPAddres = FindViewById<TextView>(Resource.Id.addEdit_APIPAddres);
            txtIpAddres1 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres1);
            txtIpAddres2 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres2);
            txtIpAddres3 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres3);
            txtIpAddres4 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres4);
            txtIpAddres5 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres5);
            txtIpAddres6 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres6);
            txtIpAddres7 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres7);
            txtIpAddres8 = FindViewById<TextView>(Resource.Id.addEdit_IpAddres8);
            txtDetails = FindViewById<TextView>(Resource.Id.addEdit_descriptin);
            txtLocation = FindViewById<TextView>(Resource.Id.addEdit_location);
            txtLocation.Click += delegate {


                //string[] Location = txtLocation.Text;
                
                //string[] mystring = txtLocation.Text.Split(Chaseparators);

                if(txtLocation.Text != null)
                {

                    string[] separators = { "," };
                    string value = txtLocation.Text;
                    string[] location = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    var uri = Android.Net.Uri.Parse("yandexnavi://build_route_on_map?lat_to=" + location[0] + "&lon_to=" + location[1]);
                    var intent = new Intent(Intent.ActionView, uri);
                    StartActivity(intent);

                }


            };


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

                txtNameFerms.Text = cData.GetString(cData.GetColumnIndex("NameFerms"));
                txtNumberFerms.Text = cData.GetString(cData.GetColumnIndex("NumberFerms"));
                txtPodrazdelenie.Text = cData.GetString(cData.GetColumnIndex("Podrazdelenie"));
                txtNameAPP.Text = cData.GetString(cData.GetColumnIndex("NameAPP"));
                txtTelefonStacionar.Text = cData.GetString(cData.GetColumnIndex("TelefonStacionar"));
                txtNameAdministrator.Text = cData.GetString(cData.GetColumnIndex("NameAdministrator"));
                txtMobileAdministrator.Text = cData.GetString(cData.GetColumnIndex("MobileAdministrator"));
                txtNameRukovoditel.Text = cData.GetString(cData.GetColumnIndex("NameRukovoditel"));
                txtMobileRukovoditel.Text = cData.GetString(cData.GetColumnIndex("MobileRukovoditel"));
                txtAPIPAddres.Text = cData.GetString(cData.GetColumnIndex("APIPAddres"));
                txtIpAddres1.Text = cData.GetString(cData.GetColumnIndex("IpAddres1"));
                txtIpAddres2.Text = cData.GetString(cData.GetColumnIndex("IpAddres2"));
                txtIpAddres3.Text = cData.GetString(cData.GetColumnIndex("IpAddres3"));
                txtIpAddres4.Text = cData.GetString(cData.GetColumnIndex("IpAddres4"));
                txtIpAddres5.Text = cData.GetString(cData.GetColumnIndex("IpAddres5"));
                txtIpAddres6.Text = cData.GetString(cData.GetColumnIndex("IpAddres6"));
                txtIpAddres7.Text = cData.GetString(cData.GetColumnIndex("IpAddres7"));
                txtIpAddres8.Text = cData.GetString(cData.GetColumnIndex("IpAddres8"));
                txtDetails.Text = cData.GetString(cData.GetColumnIndex("Details"));
                txtLocation.Text = cData.GetString(cData.GetColumnIndex("Location"));


                //if(txtNameFerms.Text != null)
                //{
                //    txtNameFerms.Visibility = ViewStates.Visible;
                //}

                //if (txtNumberFerms.Text != null)
                //{
                //    txtNumberFerms.Visibility = ViewStates.Visible;
                //}

                //if (txtPodrazdelenie.Text != null)
                //{
                //    txtPodrazdelenie.Visibility = ViewStates.Visible;
                //}

                //if (txtNameAPP.Text != null)
                //{
                //    txtNameAPP.Visibility = ViewStates.Visible;
                //}

                //if (txtTelefonStacionar.Text != null)
                //{
                //    txtTelefonStacionar.Visibility = ViewStates.Visible;
                //}

                //if (txtNameAdministrator.Text != null)
                //{
                //    txtNameAdministrator.Visibility = ViewStates.Visible;
                //}

                //if (txtMobileAdministrator != null)
                //{
                //    txtMobileAdministrator.Visibility = ViewStates.Visible;
                //}

                //if (txtNameRukovoditel.Text != null)
                //{
                //    txtNameRukovoditel.Visibility = ViewStates.Visible;
                //}

                //if (txtMobileRukovoditel.Text != null)
                //{
                //    txtMobileRukovoditel.Visibility = ViewStates.Visible;
                //}

                //if (txtAPIPAddres.Text != null)
                //{
                //    txtAPIPAddres.Visibility = ViewStates.Visible;
                //}

                //if (txtIpAddres1.Text != null)
                //{
                //    txtIpAddres1.Visibility = ViewStates.Visible;
                //}

                //if (txtIpAddres2.Text != null)
                //{
                //    txtIpAddres2.Visibility = ViewStates.Visible;

                //}

                //if (txtIpAddres3.Text != null)
                //{
                //    txtIpAddres3.Visibility = ViewStates.Visible;

                //}
                //if (txtIpAddres4.Text != null)
                //{
                //    txtIpAddres4.Visibility = ViewStates.Visible;

                //}
                //if (txtIpAddres5.Text != null)
                //{
                //    txtIpAddres5.Visibility = ViewStates.Visible;

                //}
                //if (txtIpAddres6.Text != null)
                //{
                //    txtIpAddres6.Visibility = ViewStates.Visible;

                //}
                //if (txtIpAddres7.Text != null)
                //{
                //    txtIpAddres7.Visibility = ViewStates.Visible;

                //}
                //if (txtIpAddres8.Text != null)
                //{
                //    txtIpAddres8.Visibility = ViewStates.Visible;

                //}
                //if (txtDetails.Text != null)
                //{
                //    txtDetails.Visibility = ViewStates.Visible;

                //}

            }
        }
    }
}



  