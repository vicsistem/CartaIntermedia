using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Prueva
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnIngresarSala = FindViewById<Button>(Resource.Id.btnIngresarSala);
            var btnCrearSala = FindViewById<Button>(Resource.Id.btnCrearSala);

            btnIngresarSala.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ingresarSala));
                StartActivity(intent);
            };

            btnCrearSala.Click += delegate
            {
                Intent intent = new Intent(this, typeof(crearSala));
                StartActivity(intent);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}