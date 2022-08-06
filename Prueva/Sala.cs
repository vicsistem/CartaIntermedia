using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueva
{
    class Sala
    {
        static string num_mesa;

        public string Num_mesa { get => num_mesa; set => num_mesa = value; }

        public Sala(string num)
        {
            this.Num_mesa = num;
        }

        public Sala()
        {
            
        }

        public string GetNumMesa()
        {
            return num_mesa;
        }

        public void SetNumMesa(String num)
        {
            num_mesa = num;

        }
    }
}