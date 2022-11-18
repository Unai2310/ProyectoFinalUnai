using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUnai
{
    public partial class FrmTemporada : Form
    {
        Temporada temporadaClick = null;
        Boolean Op = false;
        Boolean Caps = false;
        public FrmTemporada(Temporada temporada)
        {
            InitializeComponent();
            ImgLista.Images.Add(Properties.Resources.PlaceholderVideo);
            temporadaClick = temporada;
        }
        private void FrmTemporada_Load(object sender, EventArgs e)
        {
            LblNombre.Text = temporadaClick.getNombre();
        }
        private void BtnCapitulos_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.Firebrick;
        }
        private void BtnCapitulos_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.IndianRed;
        }
        private void BtnCapitulos_Click(object sender, EventArgs e)
        {
            Op = false;
            Caps = true;
            LvwDatos.Items.Clear();
            for (int i = 0; i < temporadaClick.getCapitulos(); i++)
            {
                ListViewItem lista = new ListViewItem(temporadaRomana(temporadaClick.getId()) + "Capitulo " + (i + 1), 0);
                LvwDatos.Items.Add(lista);
            }
        }
        private void BtnOp_Click(object sender, EventArgs e)
        {
            Op = true;
            Caps = false;
            List<String> openings = numeroOP(temporadaClick.getOp());
            LvwDatos.Items.Clear();
            for (int i = 0; i < openings.Count; i++)
            {
                ListViewItem lista = new ListViewItem(temporadaRomana(temporadaClick.getId()) + "Opening " + (i + 1), 0);
                LvwDatos.Items.Add(lista);
            }
        }
        private void LvwDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Caps)
            {
                FrmReproductor reproductor = new FrmReproductor(urlCompleta(LvwDatos.SelectedItems[0].SubItems[0].Text));
                reproductor.ShowDialog();
            }
            else
            {
                List<String> openings = numeroOP(temporadaClick.getOp());
                FrmReproductor reproductor = new FrmReproductor(openings[urlOp(LvwDatos.SelectedItems[0].SubItems[0].Text, openings.Count) - 1]);
                reproductor.ShowDialog();
            }
            
        }
        private String urlCompleta(String cadena)
        {
            String rutaSin = temporadaClick.getRuta() + "/" + cadena + ".mp4";
            String rutaCon = rutaSin.Replace(" ", "%20");
            return rutaCon;
        }
        private int urlOp(String cadena, int longitud)
        {
            if (longitud < 10)
            {
                int numeroOp = Int32.Parse(cadena.Substring(cadena.Length - 1));
                return numeroOp;
            }
            else
            {
                int numeroOp = Int32.Parse(cadena.Substring(cadena.Length - 2));
                return numeroOp;
            }
        }
        private List<String> numeroOP(String cadena)
        {
            List<String> openings = new List<string>();
            char[] caracteres = cadena.ToCharArray();
            StringBuilder sb = new StringBuilder();
            Boolean primero = true;
            for (int i = 0; i<caracteres.Length; i++)
            {
                if (!caracteres[i].Equals(' ') && !caracteres[i].Equals('|'))
                {
                    sb.Append(caracteres[i]);
                }
                else if (caracteres[i].Equals(' ') && primero) 
                {
                    openings.Add(sb.ToString());
                    sb.Clear();
                    primero = false;
                }
                else if (caracteres[i].Equals(' ') && !primero)
                {
                    primero = true;
                }   
            }
            if (sb.Length != 0)
            {
                openings.Add(sb.ToString());
            }
            return openings;
        }
        private String temporadaRomana(String temporada)
        {
            String romano = null;
            String[] partes = temporada.Split(' ');
            foreach (String palabra in partes)
            {
                if (palabra == "1")
                {
                    romano += "I ";
                }
                else if (palabra == "2")
                {
                    romano += "II ";
                }
                else if (palabra == "3")
                {
                    romano += "III ";
                }
                else if (palabra == "4")
                {
                    romano += "IV ";
                }
                else if (palabra == "5")
                {
                    romano += "V ";
                }
                else if (palabra == "6")
                {
                    romano += "VI ";
                }
                else if (palabra == "7")
                {
                    romano += "VII ";
                }
                else if (palabra == "8")
                {
                    romano += "VIII ";
                }
                else if (palabra == "9")
                {
                    romano += "IX ";
                }
                else if (palabra == "10")
                {
                    romano += "X ";
                }
                else if (!palabra.Equals("Temporada"))
                {
                    romano += palabra + " ";
                }
            }
            return romano;
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
