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
    public partial class SearchFemsList : BaseAdapter<AddressBook>
    {
        IList<AddressBook> contactListArrayList;
        private LayoutInflater mInflater;
        private Context activity;
        public SearchFemsList(Context context,
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
   
            ContactsViewHolder holder = null;
            if (convertView == null)
            {
                convertView = mInflater.Inflate(Resource.Layout.Serch_Ferms_List, null);
                holder = new ContactsViewHolder();

                holder.txtNameFerms = convertView.FindViewById<TextView>(Resource.Id.lr_NameFerms);
                holder.txtIpAddres1 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres1);
                holder.txtIpAddres2 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres2);
                holder.txtIpAddres3 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres3);
                holder.txtIpAddres4 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres4);
                holder.txtIpAddres5 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres5);
                holder.txtIpAddres6 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres6);
                holder.txtIpAddres7 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres7);
                holder.txtIpAddres8 = convertView.FindViewById<TextView>(Resource.Id.lr_IpAddres8);


                convertView.Tag = holder;
              
            }
            else
            {

                holder = convertView.Tag as ContactsViewHolder;

            }

            holder.txtNameFerms.Text = contactListArrayList[position].NameFerms.ToString();

            //holder.txtIpAddres1.Text = contactListArrayList[position].IpAddres1;
            //holder.txtIpAddres2.Text = contactListArrayList[position].IpAddres2;
            //holder.txtIpAddres3.Text = contactListArrayList[position].IpAddres3;
            //holder.txtIpAddres4.Text = contactListArrayList[position].IpAddres4;
            //holder.txtIpAddres5.Text = contactListArrayList[position].IpAddres5;
            //holder.txtIpAddres6.Text = contactListArrayList[position].IpAddres6;
            //holder.txtIpAddres7.Text = contactListArrayList[position].IpAddres7;
            //holder.txtIpAddres8.Text = contactListArrayList[position].IpAddres8;


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



        public class ContactsViewHolder : Java.Lang.Object
        {
            public TextView txtNameFerms { get; set; }
            public TextView NumberFerms { get; set; }
            public TextView Podrazdelenie { get; set; }
            public TextView NameAPP { get; set; }
            public TextView TelefonStacionar { get; set; }
            public TextView NameAdministrator { get; set; }
            public TextView MobileAdministrator { get; set; }
            public TextView NameRukovoditel { get; set; }
            public TextView MobileRukovoditel { get; set; }
            public TextView APIPAddres { get; set; }
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



    }
}