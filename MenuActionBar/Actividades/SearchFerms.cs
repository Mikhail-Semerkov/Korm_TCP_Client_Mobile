using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using Android.Content;
using Android.Runtime;
using System.Collections.Generic;
using Java.Interop;
using System.Reflection;

namespace MenuActionBar
{
    [Activity(Label = "Поиск")]
    public class SearchFerms : Activity
    {

        EditText txtSearch;
        ListView lv;
  
   
        


        IList<AddressBook> listItsms = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.SearchFerms);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);

            ActionBar.SetDisplayHomeAsUpEnabled(true);
            
            ActionBar.SetHomeButtonEnabled(true);
            
            txtSearch = FindViewById<EditText>(Resource.Id.contactList_txtSearch);
            lv = FindViewById<ListView>(Resource.Id.contactList_listView);


            txtSearch.TextChanged += delegate
            {
                AddressBookDbHelper dbVals = new AddressBookDbHelper(this);
                if (txtSearch.Text.Trim().Length < 1)
                {
                    listItsms = dbVals.GetAllContacts();
                }
                else
                {

                    listItsms = dbVals.GetContactsBySearchName(txtSearch.Text.Trim());
                }


                lv.Adapter = new SearchFemsList(this, listItsms);

            };

            LoadContactsInList();

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

        private void LoadContactsInList()
        {
            AddressBookDbHelper dbVals = new AddressBookDbHelper(this);
            if (txtSearch.Text.Trim().Length < 1)
            {
                listItsms = dbVals.GetAllContacts();
            }
            else
            {

                listItsms = dbVals.GetContactsBySearchName(txtSearch.Text.Trim());
            }


            lv.Adapter = new SearchFemsList(this, listItsms);

            lv.ItemLongClick += lv_ItemLongClick;
            lv.ItemClick += lv_ItemClick;
            
        }





        private void lv_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {

            AddressBook o = listItsms[e.Position];

            //  Toast.MakeText(this, o.Id.ToString(), ToastLength.Long).Show();

            var FermsInfoActivity = new Intent(this, typeof(FermsInfoActivity));
            FermsInfoActivity.PutExtra("ContactId", o.Id.ToString());
            FermsInfoActivity.PutExtra("ContactName", o.IpAddres1);
            StartActivity(FermsInfoActivity);


        }

        private void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {


            AddressBook o = listItsms[e.Position];

            //  Toast.MakeText(this, o.Id.ToString(), ToastLength.Long).Show();

            var IPActivity = new Intent(this, typeof(AddEditIPActivity));
            IPActivity.PutExtra("ContactId", o.Id.ToString());
            IPActivity.PutExtra("ContactName", o.IpAddres1);
            StartActivity(IPActivity);


            //if (o.IpAddres1 != null)
            //{

            //    Toast.MakeText(this, o.IpAddres1, ToastLength.Short).Show();
            //    return;

            //}

            //if (o.IpAddres2 != null)
            //{

            //    Toast.MakeText(this, o.IpAddres2, ToastLength.Short).Show();
            //    return;

            //}

            //if (o.IpAddres3 != null)
            //{

            //    Toast.MakeText(this, o.IpAddres3, ToastLength.Short).Show();
            //    return;

            //}

            //if (o.IpAddres4 != null)
            //{

            //    Toast.MakeText(this, o.IpAddres4, ToastLength.Short).Show();
            //    return;

            //}

            //if (o.IpAddres5 != null)
            //{

            //    Toast.MakeText(this, o.IpAddres5, ToastLength.Short).Show();
            //    return;

            //}

            //if (o.IpAddres6 != null)
            //{

            //    Toast.MakeText(this, o.IpAddres6, ToastLength.Short).Show();
            //    return;

            //}

            //return;

        }

    }
}