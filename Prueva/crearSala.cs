using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Prueva.com.somee.cartaintermediavictor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Prueva
{
    [Activity(Label = "crearSala")]
    public class crearSala : Activity
    {

        List<string> jugadores = new List<string>();
        WebService1 conex = new WebService1();
        int idjug1;
        int idjug2;
        int idjug3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.crearSala);

            var txtNumeroSala = FindViewById<EditText>(Resource.Id.txtINGRESAR_SALA);
            var txtFondo = FindViewById<EditText>(Resource.Id.txtFONDO_MESA);
            var btnCrear = FindViewById<Button>(Resource.Id.btnCREAR_SALA);
            var spinerJugador1 = FindViewById<Spinner>(Resource.Id.spinner1);
            var spinerJugador2 = FindViewById<Spinner>(Resource.Id.spinner2);
            var spinerJugador3 = FindViewById<Spinner>(Resource.Id.spinner3);

            DataSet data = conex.TraerJugadores();
            int numero = data.Tables[0].Rows.Count;
     
            for (int i = 0; i < numero; i++)
            {
                jugadores.Add(data.Tables[0].Rows[i]["log_usu"].ToString());
                //jugadores.Add(data.Tables[0].Rows[i]["log_pass"].ToString());
            }

            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, jugadores);
            spinerJugador1.Adapter = adapter;

            var adapter2 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, jugadores);
            spinerJugador2.Adapter = adapter2;

            var adapter3 = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, jugadores);
            spinerJugador3.Adapter = adapter3;

            btnCrear.Click += delegate
            {
                idjug1 = conex.TraerID(spinerJugador1.SelectedItem.ToString());
                idjug2 = conex.TraerID(spinerJugador2.SelectedItem.ToString());
                idjug3 = conex.TraerID(spinerJugador3.SelectedItem.ToString());

                conex.CrearMesa(txtNumeroSala.Text, txtFondo.Text, idjug1);
                conex.CrearMesa(txtNumeroSala.Text, txtFondo.Text, idjug2);
                conex.CrearMesa(txtNumeroSala.Text, txtFondo.Text, idjug3);
            };

        }
    }
}