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
    [Activity(Label = "juego", Theme = "@style/AppTheme", MainLauncher = false)]
    public class juego : Activity
    {
        public static int valor, valor1, valormedio,contador=0;
        public string jugador1, jugador2, jugador3;
        
        WebService1 conex = new WebService1();
        protected override void OnCreate(Bundle savedInstanceState )
        {
            
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.juego);

            var btnRepartir = FindViewById<Button>(Resource.Id.btnRepartir);
            var btnJugar = FindViewById<Button>(Resource.Id.btnJugar);
            var lblCartauno = FindViewById<TextView>(Resource.Id.textView6);
            var lblCartados = FindViewById<TextView>(Resource.Id.textView7);
            var lblCartatres = FindViewById<TextView>(Resource.Id.textView8);
            var lblJugadorTurno = FindViewById<TextView>(Resource.Id.txtJugadorTurno);
            var lblsaldojugador1 = FindViewById<TextView>(Resource.Id.textView9);
            var lblsaldojugador2 = FindViewById<TextView>(Resource.Id.textView10);
            var lblsaldojugador3 = FindViewById<TextView>(Resource.Id.textView11);
            var lblsaldoapostado = FindViewById<EditText>(Resource.Id.editText1);
            var lblnumerosala = FindViewById<TextView>(Resource.Id.txtVistaNumeroSala);


            


            var atrebol = Resources.GetDrawable(Resource.Drawable.A_trebol);
            var dostrebol = Resources.GetDrawable(Resource.Drawable.dostrebol);
            var trestrebol = Resources.GetDrawable(Resource.Drawable.trestrebol);
            var cuatrotrebol = Resources.GetDrawable(Resource.Drawable.cuatrotrebol);
            var cincotrebol = Resources.GetDrawable(Resource.Drawable.cincotrebol);
            var seistrebol = Resources.GetDrawable(Resource.Drawable.seistrebol);
            var sietetrebol = Resources.GetDrawable(Resource.Drawable.sietetrebol);
            var ochotrebol = Resources.GetDrawable(Resource.Drawable.ochotrebol);
            var nuevetrebol = Resources.GetDrawable(Resource.Drawable.nuevetrebol);
            var diestrebol = Resources.GetDrawable(Resource.Drawable.diestrebol);
            var jtrebol = Resources.GetDrawable(Resource.Drawable.J_trebol);
            var qtrebol = Resources.GetDrawable(Resource.Drawable.Q_trebol);
            var ktrebol = Resources.GetDrawable(Resource.Drawable.K_trebol);
            var cartaFinal = Resources.GetDrawable(Resource.Drawable.cartaAtras);
            

            Random random = new Random();
            Random random2 = new Random();

            btnJugar.Click += delegate
            {
                valormedio = random.Next(1, 13);
                if (valormedio == 1)
                {
                    lblCartados.Background = (atrebol);
                }
                if (valormedio == 2)
                {
                    lblCartados.Background = (dostrebol);
                }
                if (valormedio == 3)
                {
                    lblCartados.Background = (trestrebol);
                }
                if (valormedio == 4)
                {
                    lblCartados.Background = (cuatrotrebol);
                }
                if (valormedio == 5)
                {
                    lblCartados.Background = (cincotrebol);
                }
                if (valormedio == 6)
                {
                    lblCartados.Background = (seistrebol);
                }
                if (valormedio == 7)
                {
                    lblCartados.Background = (sietetrebol);
                }
                if (valormedio == 8)
                {
                    lblCartados.Background = (ochotrebol);
                }
                if (valormedio == 9)
                {
                    lblCartados.Background = (nuevetrebol);
                }
                if (valormedio == 10)
                {
                    lblCartados.Background = (diestrebol);
                }
                if (valormedio == 11)
                {
                    lblCartados.Background = (jtrebol);
                }
                if (valormedio == 12)
                {
                    lblCartados.Background = (qtrebol);
                }
                if (valormedio == 13)
                {
                    lblCartados.Background = (ktrebol);
                }

                

                AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                AlertDialog alert = dialog.Create();
                alert.SetTitle("Informacion del Juego!");
                alert.SetIcon(Android.Resource.Drawable.AlertLightFrame);
                alert.SetButton("Continuar", (s, ev) =>
                 {
                     if (valor > valormedio && valor1 < valormedio)
                     {
                         Toast.MakeText(this, "A ganado ", ToastLength.Short).Show();
                         
                     }
                     if (valor == valormedio || valor1 == valormedio)
                     {
                         Toast.MakeText(this, "A perdido y el doble", ToastLength.Short).Show();
                     }
                     if (valor < valormedio && valor1 > valormedio)
                     {
                         Toast.MakeText(this, "A ganado ", ToastLength.Short).Show();
                     }
                     if (valormedio > valor1 && valormedio > valor)
                     {
                         Toast.MakeText(this, "A perdido ", ToastLength.Short).Show();
                     }
                     if (valormedio < valor && valormedio < valor1)
                     {
                         Toast.MakeText(this, "A perdido ", ToastLength.Short).Show();
                     }
                     if (valor < valormedio && valormedio < valor1)
                     {
                         Toast.MakeText(this, "A ganado ", ToastLength.Short).Show();
                     }

                     lblCartauno.Background = (cartaFinal);
                     lblCartados.Background = (cartaFinal);
                     lblCartatres.Background = (cartaFinal);
                 } );
                alert.Show();
                

            };
            btnRepartir.Click += delegate
            {
                int valorazarjug;
                contador++;
                if (contador == 1)
                {
                    lblJugadorTurno.Text = lblsaldojugador1.Text;
                }
                if(contador == 2)
                {
                    lblJugadorTurno.Text = lblsaldojugador2.Text;
                }
                if(contador == 3)
                {
                    lblJugadorTurno.Text = lblsaldojugador3.Text;
                    contador = 0;
                }
                valor = random.Next(1, 13);
                valor1 = random2.Next(1, 13);
                if(valor == 1)
                {
                    lblCartauno.Background = (atrebol);
                }
                if (valor == 2)
                {
                    lblCartauno.Background = (dostrebol);
                }
                if (valor == 3)
                {
                    lblCartauno.Background = (trestrebol);
                }
                if (valor == 4)
                {
                    lblCartauno.Background = (cuatrotrebol);
                }
                if (valor == 5)
                {
                    lblCartauno.Background = (cincotrebol);
                }
                if (valor == 6)
                {
                    lblCartauno.Background = (seistrebol);
                }
                if (valor == 7)
                {
                    lblCartauno.Background = (sietetrebol);
                }
                if (valor == 8)
                {
                    lblCartauno.Background = (ochotrebol);
                }
                if (valor == 9)
                {
                    lblCartauno.Background = (nuevetrebol);
                }
                if (valor == 10)
                {
                    lblCartauno.Background = (diestrebol);
                }
                if (valor == 11)
                {
                    lblCartauno.Background = (jtrebol);
                }
                if (valor == 12)
                {
                    lblCartauno.Background = (qtrebol);
                }
                if (valor == 13)
                {
                    lblCartauno.Background = (ktrebol);
                }

                //Lbl 3
                if (valor1 == 1)
                {
                    lblCartatres.Background = (atrebol);
                }
                if (valor1 == 2)
                {
                    lblCartatres.Background = (dostrebol);
                }
                if (valor1 == 3)
                {
                    lblCartatres.Background = (trestrebol);
                }
                if (valor1 == 4)
                {
                    lblCartatres.Background = (cuatrotrebol);
                }
                if (valor1 == 5)
                {
                    lblCartatres.Background = (cincotrebol);
                }
                if (valor1 == 6)
                {
                    lblCartatres.Background = (seistrebol);
                }
                if (valor1 == 7)
                {
                    lblCartatres.Background = (sietetrebol);
                }
                if (valor1 == 8)
                {
                    lblCartatres.Background = (ochotrebol);
                }
                if (valor1 == 9)
                {
                    lblCartatres.Background = (nuevetrebol);
                }
                if (valor1 == 10)
                {
                    lblCartatres.Background = (diestrebol);
                }
                if (valor1 == 11)
                {
                    lblCartatres.Background = (jtrebol);
                }
                if (valor1 == 12)
                {
                    lblCartatres.Background = (qtrebol);
                }
                if (valor1 == 13)
                {
                    lblCartatres.Background = (ktrebol);
                }
            };


            Sala sa = new Sala();

            var nmesa = sa.GetNumMesa();
            List<string> jugadores = new List<string>();
            List<string> numsal = new List<string>();

            DataSet dato = conex.TraerJugadoresySaldomesa(Convert.ToInt32(nmesa));

            int n = dato.Tables[0].Rows.Count;

            for (int i = 0; i < n; i++)
            {
                jugadores.Add(dato.Tables[0].Rows[i]["log_usu"].ToString());
                numsal.Add(dato.Tables[0].Rows[i]["sal_saldomesa"].ToString());
            }

            lblsaldojugador1.Text = jugadores[0];
            lblsaldojugador2.Text = jugadores[1];
            lblsaldojugador3.Text = jugadores[2];

            lblnumerosala.Text = numsal[0];
            
     
            
            

            
            

        }

        
    }
}