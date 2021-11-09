using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppArchivosDeTeexto
{
    public partial class Form1 : Form
    {
        Lapiz[] l;
        int p = 0;

        public Form1()
        {
            InitializeComponent();
            l = new Lapiz[3];
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                string filePath = openFileDialog1.FileName;
                p = 0;
  
                foreach (string line in System.IO.File.ReadLines(filePath))
                {
                    string[] datos;
                    datos = line.Split('-');
                    Lapiz n = new Lapiz();
                    n.Tipo = datos[0];
                    n.Color = datos[1];
                    
                    l[p] = n;
                    listArreglo.Items.Add(l[p]);
                    p++;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(dialogo.FileName)) 
                    for (int i = 0; i < l.Length; i++)
                    {
                        if (l[i] != null)
                        {
                            archivo.WriteLineAsync(l[i].ToString());
                        }
                    }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Lapiz n = new Lapiz();
            n.Tipo = txtTipo.Text;
            n.Color = txtColor.Text;

            l[p] = n; 
            listArreglo.Items.Add(l[p]);
            p++;
        }
    }
}
