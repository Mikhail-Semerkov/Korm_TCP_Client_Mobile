using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace MenuActionBar
{
    [Activity(Label = "Настройки Digi-Star")]
    public class DocumentsDS : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.DocumentsDS);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarC);
            SetActionBar(toolbar);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeButtonEnabled(true);
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