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
using Android.Database.Sqlite;
using Java.Lang;

namespace MenuActionBar
{
   public class AddressBook
    {
        public int Id { get; set; }
        public string NameFerms { get; set; }
        public string NumberFerms { get; set; }
        public string Podrazdelenie { get; set; }
        public string NameAPP { get; set; }
        public string TelefonStacionar { get; set; }
        public string NameAdministrator { get; set; }
        public string MobileAdministrator { get; set; }
        public string NameRukovoditel { get; set; }
        public string MobileRukovoditel { get; set; }
        public string APIPAddres { get; set; }
        public string IpAddres1 { get; set; }
        public string IpAddres2 { get; set; }
        public string IpAddres3 { get; set; }
        public string IpAddres4 { get; set; }
        public string IpAddres5 { get; set; }
        public string IpAddres6 { get; set; }
        public string IpAddres7 { get; set; }
        public string IpAddres8 { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }

        public static explicit operator AddressBook(Java.Lang.Object v)
        {
            throw new NotImplementedException();
        }
    }
}