using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Plugin.Settings;
using MySql.Data.MySqlClient;
using System.Data;
using Android.Content;
using Android.Runtime;
using System.Collections.Generic;
using System.Diagnostics;

namespace MenuActionBar
{
    [Activity(Label = "Параметры")]
    public class Setting : Activity
    {

        EditText _SettingProbros, _SettingPort;
        Button _SaveSettingButton;
        
        


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.Setting);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);

            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);      
            _SettingProbros = FindViewById<EditText>(Resource.Id.FormatProbrosVes);
            _SaveSettingButton = FindViewById<Button>(Resource.Id.SaveSetting);
            _SaveSettingButton.Click += _SaveSettingButton_Click;
            _SettingPort = FindViewById<EditText>(Resource.Id.FormatPort);

            _SettingProbros.Text = CrossSettings.Current.GetValueOrDefault("Setting_Probros", "Gs03");
            _SettingPort.Text = CrossSettings.Current.GetValueOrDefault("Setting_Port", "4001");

        }


        //Сохранение настроек....
        private void _SaveSettingButton_Click(object sender, System.EventArgs e)
        {


            CrossSettings.Current.AddOrUpdateValue("Setting_Probros", _SettingProbros.Text);
            CrossSettings.Current.AddOrUpdateValue("Setting_Port", _SettingPort.Text);
            Toast.MakeText(this, "Настройки сохранены", ToastLength.Long).Show();
            var MainActivity = new Intent(this, typeof(MainActivity));
            StartActivity(MainActivity);



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
    }
}