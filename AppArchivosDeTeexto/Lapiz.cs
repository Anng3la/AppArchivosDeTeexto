using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArchivosDeTeexto
{
    class Lapiz
    {
        private string tipo;
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public Lapiz()
        {
            tipo = "";
            color = "";
        }
        public override string ToString()
        {
            return tipo + "  " + color + "  ";
        }
    }
}
