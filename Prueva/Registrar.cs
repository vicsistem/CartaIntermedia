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
    [Activity(Label = "Registrar")]
    public class Registrar : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.Registrar);
            //// Create your application here
            

            //var txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuarioR);
            //var pswContra = FindViewById<EditText>(Resource.Id.txtContraseñaR);
            //var btnRegistrar = FindViewById<Button>(Resource.Id.btnIngresarR);

            //WebService1 conex = new WebService1();
            //btnRegistrar.Click += delegate
            //{
            //    conex.CrearUsuario(txtUsuario.Text,pswContra.Text);
            //};
            //// Create your application here
        }
    }
}