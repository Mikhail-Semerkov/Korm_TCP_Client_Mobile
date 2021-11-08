using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using Android.Content;
using Android.Runtime;
using System.Collections.Generic;


namespace MenuActionBar
{
    [Activity(Label = "База Данных SQL")]
    public class SQL : Activity
    {
        Button btnAdd;
        EditText txtSearch;
        ListView lv;


        IList<AddressBook> listItsms = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.SQL);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);

            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);

            btnAdd = FindViewById<Button>(Resource.Id.contactList_btnAdd);
            txtSearch = FindViewById<EditText>(Resource.Id.contactList_txtSearch);
             
            lv = FindViewById<ListView>(Resource.Id.contactList_listView);




            btnAdd.Click += delegate {
                var activityAddEdit = new Intent(this, typeof(AddEditAddressBookActivity));
                StartActivity(activityAddEdit);

            };



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


                lv.Adapter = new ContactListBaseAdapter(this, listItsms);
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


            lv.Adapter = new ContactListBaseAdapter(this, listItsms);

            lv.ItemLongClick += lv_ItemLongClick;
            lv.ItemClick += lv_ItemClick;
        }

        private void lv_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            AddressBook o = listItsms[e.Position];

            //  Toast.MakeText(this, o.Id.ToString(), ToastLength.Long).Show();

            var activityAddEdit = new Intent(this, typeof(AddEditAddressBookActivity));
            activityAddEdit.PutExtra("ContactId", o.Id.ToString());
            activityAddEdit.PutExtra("ContactName", o.NameFerms);
            StartActivity(activityAddEdit);
        }

        private void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            
        }
    }
}