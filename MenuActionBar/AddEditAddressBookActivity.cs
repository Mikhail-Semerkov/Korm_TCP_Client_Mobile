using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Android.Database;
using System.Text.RegularExpressions;

namespace MenuActionBar
{
    [Activity(Label = "Редактор SQL")]
    public class AddEditAddressBookActivity : Activity
    {
        EditText txtNameFerms, txtNumberFerms, txtPodrazdelenie, txtNameAPP, txtTelefonStacionar, txtNameAdministrator, txtMobileAdministrator, txtNameRukovoditel, txtMobileRukovoditel, txtAPIPAddres, txtIpAddres1, txtIpAddres2, txtIpAddres3, txtIpAddres4, txtIpAddres5, txtIpAddres6, txtIpAddres7, txtIpAddres8, txtDescription, txtLocation;
        TextView txtId;
        Button btnSave;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AddEditContacts);



            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);




            txtId = FindViewById<TextView>(Resource.Id.addEdit_ContactId);
            txtNameFerms = FindViewById<EditText>(Resource.Id.addEdit_NameFerms);
            txtNumberFerms = FindViewById<EditText>(Resource.Id.addEdit_NumberFerms);
            txtPodrazdelenie = FindViewById<EditText>(Resource.Id.addEdit_Podrazdelenie);
            txtNameAPP = FindViewById<EditText>(Resource.Id.addEdit_NameAPP);
            txtTelefonStacionar = FindViewById<EditText>(Resource.Id.addEdit_TelefonStacionar);
            txtNameAdministrator = FindViewById<EditText>(Resource.Id.addEdit_NameAdministrator);
            txtMobileAdministrator = FindViewById<EditText>(Resource.Id.addEdit_MobileAdministrator);
            txtNameRukovoditel = FindViewById<EditText>(Resource.Id.addEdit_NameRukovoditel);
            txtMobileRukovoditel = FindViewById<EditText>(Resource.Id.addEdit_MobileRukovoditel);
            txtAPIPAddres = FindViewById<EditText>(Resource.Id.addEdit_APIPAddres);
            txtIpAddres1 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres1);
            txtIpAddres2 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres2);
            txtIpAddres3 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres3);
            txtIpAddres4 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres4);
            txtIpAddres5 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres5);
            txtIpAddres6 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres6);
            txtIpAddres7 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres7);
            txtIpAddres8 = FindViewById<EditText>(Resource.Id.addEdit_IpAddres8);
            txtDescription = FindViewById<EditText>(Resource.Id.addEdit_Description);
            txtLocation = FindViewById<EditText>(Resource.Id.addEdit_Location);
            btnSave = FindViewById<Button>(Resource.Id.addEdit_btnSave);


            
            
            btnSave.Click += buttonSave_Click;

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
                txtDescription.Text = cData.GetString(cData.GetColumnIndex("Details"));
                txtLocation.Text = cData.GetString(cData.GetColumnIndex("Location"));
            }
        }

        void buttonSave_Click(object sender, EventArgs e)
        {
            AddressBookDbHelper db = new AddressBookDbHelper(this);
            if (txtNameFerms.Text.Trim().Length < 1)
            {
                Toast.MakeText(this, "Введите имя фермы.", ToastLength.Short).Show();
                return;
            }

            //if (txtMobile.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Введите номер телефона.", ToastLength.Short).Show();
            //    return;
            //}


            //if (txtIpAddres1.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Enter IpAddres1 Number.", ToastLength.Short).Show();
            //    return;
            //}

            //if (txtIpAddres2.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Enter IpAddres2 Number.", ToastLength.Short).Show();
            //    return;
            //}

            //if (txtIpAddres3.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Enter IpAddres3 Number.", ToastLength.Short).Show();
            //    return;
            //}

            //if (txtIpAddres4.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Enter IpAddres4 Number.", ToastLength.Short).Show();
            //    return;
            //}

            //if (txtIpAddres5.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Enter IpAddres5 Number.", ToastLength.Short).Show();
            //    return;
            //}

            //if (txtIpAddres6.Text.Trim().Length < 1)
            //{
            //    Toast.MakeText(this, "Enter IpAddres6 Number.", ToastLength.Short).Show();
            //    return;
            //}

            //if (txtEmail.Text.Trim().Length > 0)
            //{
            //    string EmailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            //    if (!Regex.IsMatch(txtEmail.Text, EmailPattern, RegexOptions.IgnoreCase))
            //    {
            //        Toast.MakeText(this, "Invalid email address.", ToastLength.Short).Show();
            //        return;
            //    }
            //}

            AddressBook ab = new AddressBook();

            if (txtId.Text.Trim().Length > 0)
            {
                ab.Id = int.Parse(txtId.Text);
            }
            ab.NameFerms = txtNameFerms.Text;
            ab.NumberFerms = txtNumberFerms.Text;
            ab.Podrazdelenie = txtPodrazdelenie.Text;
            ab.NameAPP = txtNameAPP.Text;
            ab.TelefonStacionar = txtTelefonStacionar.Text;
            ab.NameAdministrator = txtNameAdministrator.Text;
            ab.MobileAdministrator = txtMobileAdministrator.Text;
            ab.NameRukovoditel = txtNameRukovoditel.Text;
            ab.MobileRukovoditel = txtMobileRukovoditel.Text;
            ab.APIPAddres = txtAPIPAddres.Text;
            ab.IpAddres1 = txtIpAddres1.Text;
            ab.IpAddres2 = txtIpAddres2.Text;
            ab.IpAddres3 = txtIpAddres3.Text;
            ab.IpAddres4 = txtIpAddres4.Text;
            ab.IpAddres5 = txtIpAddres5.Text;
            ab.IpAddres6 = txtIpAddres6.Text;
            ab.IpAddres7 = txtIpAddres7.Text;
            ab.IpAddres8 = txtIpAddres8.Text;
            ab.Details = txtDescription.Text;
            ab.Location = txtLocation.Text;

            try
            {

                if (txtId.Text.Trim().Length > 0)
                {
                    db.UpdateContact(ab);
                    Toast.MakeText(this, "Запись успешно обновлена.", ToastLength.Short).Show();
                }
                else
                { 
                    db.AddNewContact(ab);
                    Toast.MakeText(this, "Новая запись успешно создана.", ToastLength.Short).Show();
                }

                Finish();

                //Go to main activity after save/edit
                var mainActivity = new Intent(this, typeof(SQL));
                StartActivity(mainActivity);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }
    }
}