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
    [Activity(Label = "ingresarSala")]
    public class ingresarSala : Activity
    {
        public string nsal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ingresarSala);

            

            var txtIngresarSala = FindViewById<EditText>(Resource.Id.Ingresar_Numero_Sala_Buscar);
            var btnUnirseSala = FindViewById<Button>(Resource.Id.btnUnirseSala);
            
            WebService1 conex = new WebService1();

            
            
            btnUnirseSala.Click += delegate
            {
               
                if (conex.ValidarSala(Convert.ToInt32(txtIngresarSala.Text)) == 1)
                {

                    Sala sa = new Sala(txtIngresarSala.Text);
                    Intent intent = new Intent(this, typeof(juego));
                    StartActivity(intent);
                }

                if (conex.ValidarSala(Convert.ToInt32(txtIngresarSala.Text)) == 0)
                {
                    Toast.MakeText(this, "NUMERO DE SALA incorrectos", ToastLength.Short).Show();
                }
            };


        }
    }
}