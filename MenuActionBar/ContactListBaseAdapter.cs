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

namespace MenuActionBar
{
    [Activity(Label = "ContactListBaseAdapter")]
    public partial class ContactListBaseAdapter : BaseAdapter<AddressBook>
    {
        IList<AddressBook> contactListArrayList;
        private LayoutInflater mInflater;
        private Context activity;
        public ContactListBaseAdapter(Context context,
                                                IList<AddressBook> results)
        {
            this.activity = context;
            contactListArrayList = results;
            mInflater = (LayoutInflater)activity.GetSystemService(Context.LayoutInflaterService);
        }

        public override int Count
        {
            get { return contactListArrayList.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override AddressBook this[int position]
        {
            get { return contactListArrayList[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView btnDelete;
            ContactsViewHolder holder = null;
            if (convertView == null)
            {
                convertView = mInflater.Inflate(Resource.Layout.list_row_contact_list, null);
                holder = new ContactsViewHolder();

                holder.txtNameFerms = convertView.FindViewById<TextView>(Resource.Id.lr_NameFerms);
                holder.txtNumberFerms = convertView.FindViewById<TextView>(Resource.Id.lr_NumberFerms);
                holder.txtPodrazdelenie = convertView.FindViewById<TextView>(Resource.Id.lr_Podrazdelenie);
                holder.txtNameAPP = convertView.FindViewById<TextView>(Resource.Id.lr_NameAPP);
                holder.txtTelefonStacionar = convertView.FindViewById<TextView>(Resource.Id.lr_TelefonStacionar);
                holder.txtNameAdministrator = convertView.FindViewById<TextView>(Resource.Id.lr_NameAdministrator);
                holder.txtMobileAdministrator = convertView.FindViewById<TextView>(Resource.Id.lr_MobileAdministrator);
                holder.txtNameRukovoditel = convertView.FindViewById<TextView>(Resource.Id.lr_NameRukovoditel);
                holder.txtMobileRukovoditel = convertView.FindViewById<TextView>(Resource.Id.lr_MobileRukovoditel);
                holder.txtAPIPAddres = convertView.FindViewById<TextView>(Resource.Id.lr_APIPAddres);
                holder.txtIpAddres1 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres1);
                holder.txtIpAddres2 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres2);
                holder.txtIpAddres3 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres3);
                holder.txtIpAddres4 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres4);
                holder.txtIpAddres5 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres5);
                holder.txtIpAddres6 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres6);
                holder.txtIpAddres7 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres7);
                holder.txtIpAddres8 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres8);
                holder.txtDescription = convertView.FindViewById<TextView>(Resource.Id.lr_descriptin);
                holder.txtLocation = convertView.FindViewById<TextView>(Resource.Id.lr_location);
                btnDelete = convertView.FindViewById<ImageView>(Resource.Id.lr_deleteBtn);


                btnDelete.Click += (object sender, EventArgs e) =>
                {

                    var poldel = (int)((sender as ImageView).Tag);

                    string id = contactListArrayList[poldel].Id.ToString();
                    string fname = contactListArrayList[poldel].NameFerms;

                    AlertDialog.Builder builder = new AlertDialog.Builder(activity);
                    AlertDialog confirm = builder.Create();
                    confirm.SetTitle(fname);
                    confirm.SetMessage("Удалить запись?");
                    confirm.SetButton("OK", (s, ev) =>
                    {

                        

                        contactListArrayList.RemoveAt(poldel);

                        DeleteSelectedContact(id);
                        NotifyDataSetChanged();

                        Toast.MakeText(activity, "Запись успешно удалена", ToastLength.Short).Show();
                    });
                    confirm.SetButton2("Отменить", (s, ev) =>
                    {

                    });

                    confirm.Show();
                };

                convertView.Tag = holder;
                btnDelete.Tag = position;
            }
            else
            {
                btnDelete = convertView.FindViewById<ImageView>(Resource.Id.lr_deleteBtn);
                holder = convertView.Tag as ContactsViewHolder;
                btnDelete.Tag = position;
            }

            holder.txtNameFerms.Text = contactListArrayList[position].NameFerms.ToString();
            holder.txtNumberFerms.Text = contactListArrayList[position].NumberFerms;
            holder.txtPodrazdelenie.Text = contactListArrayList[position].Podrazdelenie;
            holder.txtNameAPP.Text = contactListArrayList[position].NameAPP;
            holder.txtTelefonStacionar.Text = contactListArrayList[position].TelefonStacionar;
            holder.txtNameAdministrator.Text = contactListArrayList[position].NameAdministrator;
            holder.txtMobileAdministrator.Text = contactListArrayList[position].MobileAdministrator;
            holder.txtNameRukovoditel.Text = contactListArrayList[position].NameRukovoditel;
            holder.txtMobileRukovoditel.Text = contactListArrayList[position].MobileRukovoditel;
            holder.txtAPIPAddres.Text = contactListArrayList[position].APIPAddres;
            holder.txtIpAddres1.Text = contactListArrayList[position].IpAddres1;
            holder.txtIpAddres2.Text = contactListArrayList[position].IpAddres2;
            holder.txtIpAddres3.Text = contactListArrayList[position].IpAddres3;
            holder.txtIpAddres4.Text = contactListArrayList[position].IpAddres4;
            holder.txtIpAddres5.Text = contactListArrayList[position].IpAddres5;
            holder.txtIpAddres6.Text = contactListArrayList[position].IpAddres6;
            holder.txtIpAddres7.Text = contactListArrayList[position].IpAddres7;
            holder.txtIpAddres8.Text = contactListArrayList[position].IpAddres8;
            holder.txtDescription.Text = contactListArrayList[position].Details;
            holder.txtLocation.Text = contactListArrayList[position].Location;

            if (position % 2 == 0)
            {
                convertView.SetBackgroundResource(Resource.Drawable.list_selector);
            }
            else
            {
                convertView.SetBackgroundResource(Resource.Drawable.list_selector_alternate);
            }

            return convertView;
        }

        public IList<AddressBook> GetAllData()
        {
            return contactListArrayList;
        }

        public class ContactsViewHolder : Java.Lang.Object
        {
            public TextView txtNameFerms { get; set; }
            public TextView txtNumberFerms { get; set; }
            public TextView txtPodrazdelenie { get; set; }
            public TextView txtNameAPP { get; set; }
            public TextView txtTelefonStacionar { get; set; }
            public TextView txtNameAdministrator { get; set; }
            public TextView txtMobileAdministrator { get; set; }
            public TextView txtNameRukovoditel { get; set; }
            public TextView txtMobileRukovoditel { get; set; }
            public TextView txtAPIPAddres { get; set; }
            public TextView txtIpAddres1 { get; set; }
            public TextView txtIpAddres2 { get; set; }
            public TextView txtIpAddres3 { get; set; }
            public TextView txtIpAddres4 { get; set; }
            public TextView txtIpAddres5 { get; set; }
            public TextView txtIpAddres6 { get; set; }
            public TextView txtIpAddres7 { get; set; }
            public TextView txtIpAddres8 { get; set; }
            public TextView txtDescription { get; set; }
            public TextView txtLocation { get; set; }
        }

        private void DeleteSelectedContact(string contactId)
        {
            AddressBookDbHelper _db = new AddressBookDbHelper(activity);
            _db.DeleteContact(contactId);
        }

    }
}