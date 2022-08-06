using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Prueva.com.somee.cartaintermediavictor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueva
{
    [Activity(Label = "validarusu", MainLauncher = true)]
    public class validarusu : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);
            // Create your application here

            var txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuariol);
            var pswContra = FindViewById<EditText>(Resource.Id.txtContraseñal);
            var btnApertura = FindViewById<Button>(Resource.Id.btnIngresarl);


            WebService1 conex = new WebService1();

            btnApertura.Click += delegate
            {
                if (conex.ValidarUsuario(txtUsuario.Text, pswContra.Text) == 1)
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                }
                
                if (conex.ValidarUsuario(txtUsuario.Text, pswContra.Text) == 0)
                {
                    Toast.MakeText(this, "USUARIO/CONTRASEÑA incorrectos", ToastLength.Short).Show();
                }
            };

            //btnRegistrar.Click += delegate
            //{
            //    Intent intent = new Intent(this, typeof(Registrar));
            //    StartActivity(intent);
            //};
            




        }
    }
}