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
    public partial class FrmLista : Form
    {
        private Usuarios usuarioClick;
        private Boolean pers;
        public FrmLista(Usuarios usuario, Boolean personal)
        {
            InitializeComponent();
            usuarioClick = usuario;
            pers = personal;
            autoCompletar();
        }
        private void FrmLista_Load(object sender, EventArgs e)
        {
            PcbFoto.Load("https://catbox.moe/pictures/qts/1489297097940.png");
            PcbImagen.Image = Image.FromStream(ModeloUsuarios.ByteImage(usuarioClick.getImagen()));
            LblLista.Text = "Lista de " + usuarioClick.getUsuario();
            List<Lista> lista = ConexionLista.buscar(usuarioClick.getId().ToString(), "Usuario");
            if (pers)
            {
                DtgLista.Columns.Add("Anime", "Anime");
                DataGridViewColumn column = DtgLista.Columns[0];
                column.Width = 290;
                DtgLista.Columns.Add("Nota", "Nota");
                column = DtgLista.Columns[1];
                column.Width = 120;
                DtgLista.Columns.Add("Fecha", "Fecha de Finalización");
                column = DtgLista.Columns[2];
                column.Width = 171;
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                DtgLista.Columns.Add(img);
                img.Width = 52;
            }
            else
            {
                DtgLista.Columns.Add("Anime", "Anime");
                DataGridViewColumn column = DtgLista.Columns[0];
                column.Width = 307;
                DtgLista.Columns.Add("Nota", "Nota");
                column = DtgLista.Columns[1];
                column.Width = 137;
                DtgLista.Columns.Add("Fecha", "Fecha de Finalización");
                column = DtgLista.Columns[2];
                column.Width = 188;
            }
            if (lista.Count == 0)
            {
                LblVacio.Visible = true;
                LblVacio.Text = "No hay Animes en la lista";
            }
            else
            {
                foreach (Lista elemento in lista)
                {
                    if (pers)
                    {
                        DtgLista.Rows.Add(elemento.getAnime(), elemento.getNota(), elemento.getFecha(), Properties.Resources.Borrar);
                    }
                    else
                    {
                        DtgLista.Rows.Add(elemento.getAnime(), elemento.getNota(), elemento.getFecha());
                    }
                }
            }
        }
        private void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            for (int i = 0; i < ConexionLista.buscarDinamico(usuarioClick.getId()).Rows.Count; i++)
            {
                lista.Add(ConexionLista.buscarDinamico(usuarioClick.getId()).Rows[i]["Anime"].ToString());
            }
            TxtBuscar.AutoCompleteCustomSource = lista;
        }
        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lista entrada = ConexionLista.buscarEntrada(usuarioClick.getId(), TxtBuscar.Text);
                if (entrada != null)
                {
                    DtgLista.Rows.Clear();
                    DtgLista.Rows.Add(entrada.getAnime(), entrada.getNota(), entrada.getFecha(), Properties.Resources.Borrar);
                }
            }
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBuscar.Text))
            {
                DtgLista.Rows.Clear();
                DtgLista.Columns.Clear();
                FrmLista_Load(sender, e);
            }
        }

        private void DtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgLista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("System.Drawing.Bitmap") && pers)
                {
                    Lista entrada = ConexionLista.buscarEntrada(Sesion.id, DtgLista.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString());
                    DialogResult dialogo = MessageBox.Show("¿Quieres borrar " + DtgLista.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value.ToString() + " de tu lista?",
                    "Eliminar Anime", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.Yes)
                    {
                        Lista lista = new Lista(entrada.getId(), Sesion.id, "", "", "");
                        ConexionLista.eliminar(lista);
                        MessageBox.Show("Anime Eliminado de tu lista", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DtgLista.Rows.Clear();
                        DtgLista.Columns.Clear();
                        FrmLista_Load(sender, e);
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
