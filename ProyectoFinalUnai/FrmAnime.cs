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
    public partial class FrmAnime : Form
    {
        Anime animeClick = null;
        public FrmAnime(Anime anime)
        {
            InitializeComponent();
            ImgLista.Images.Add(Properties.Resources.Temp_1);
            ImgLista.Images.Add(Properties.Resources.Temp_2);
            ImgLista.Images.Add(Properties.Resources.Temp_3);
            ImgLista.Images.Add(Properties.Resources.Temp_4);
            ImgLista.Images.Add(Properties.Resources.Temp_5);
            ImgLista.Images.Add(Properties.Resources.Temp_6);
            ImgLista.Images.Add(Properties.Resources.Temp_7);
            ImgLista.Images.Add(Properties.Resources.Temp_8);
            ImgLista.Images.Add(Properties.Resources.Temp_9);
            ImgLista.Images.Add(Properties.Resources.Temp_10);
            animeClick = anime;
            autoCompletar();
        }
        private void FrmAnime_Load(object sender, EventArgs e)
        {
            Lista entrada = ConexionLista.buscarEntrada(Sesion.id, animeClick.getNombre());
            if (entrada != null)
            {
                PcbAñadir.Image = Properties.Resources.Añadido;
                CbxNota.Text = entrada.getNota(); 
            }
            else
            {
                PcbAñadir.Image = Properties.Resources.Añadir;
            }
            PcbPerfil.Image = Image.FromStream(ModeloUsuarios.ByteImage(Sesion.imagen));
            PcbImagen.Load(animeClick.getImagen());
            List<Temporada> temporadas = ConexionTemporada.buscarOrdenado(animeClick.getNombre(), "Anime");
            List<Pelicula> peliculas = ConexionPelicula.buscar(animeClick.getNombre(), "Anime");
            LvwTemporadas.Items.Clear();
            int i = 0;
            int posicion = 1;
            int indexPel = 0;
            int indexTemp = 0;
            for (int j = 0; j<temporadas.Count+peliculas.Count; j++)
            {
                if (peliculas.Count != 0)
                {
                    if (peliculas[indexPel].getPosicion() == posicion) 
                    {
                        ListViewItem lista = new ListViewItem(peliculas[indexPel].getNombre(), i);
                        lista.SubItems.Add(peliculas[0].getId());
                        LvwTemporadas.Items.Add(lista);
                        i++;
                        posicion++;
                        if (indexPel+1 < peliculas.Count)
                        {
                            indexPel++;
                        }
                    }   
                }

                if (temporadas.Count != 0 && temporadas[indexTemp].getPosicion() == posicion)
                {
                    ListViewItem lista = new ListViewItem(temporadas[indexTemp].getNombre(), i);
                    lista.SubItems.Add(temporadas[indexTemp].getId());
                    LvwTemporadas.Items.Add(lista);
                    i++;
                    posicion++;
                    if (indexTemp+1 < temporadas.Count)
                    {
                        indexTemp++;
                    }
                }

                if (temporadas.Count != 0 && temporadas[indexTemp].getPosicion() == 0)
                {
                    ListViewItem lista = new ListViewItem(temporadas[indexTemp].getNombre(), i);
                    lista.SubItems.Add(temporadas[indexTemp].getId());
                    LvwTemporadas.Items.Add(lista);
                }
            } 
            LblNombreV.Text = animeClick.getNombre();
            LblGeneroV.Text = animeClick.getGenero();
            LblTemporadasV.Text = animeClick.getTemporadas() + " Temporadas";
            LblCapitulosV.Text = animeClick.getCapitulos() + " Capitulos";
        }
        private void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            for (int i = 0; i < ConexionAnime.buscarDinamico().Rows.Count; i++)
            {
                lista.Add(ConexionAnime.buscarDinamico().Rows[i]["Nombre"].ToString());
            }
            TxtBuscar.AutoCompleteCustomSource = lista;
        }
        private void PcbCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && primeraMayus(TxtBuscar.Text))
            {
                List<Anime> animes = ConexionAnime.buscar(TxtBuscar.Text, "Nombre");
                FrmAnime anime = new FrmAnime(animes[0]);
                this.Dispose();
                anime.ShowDialog();
            }
        }
        private Boolean primeraMayus(String cadena)
        {
            String cadenaAyuda = cadena.ToLower();
            if (cadena.Equals(cadenaAyuda))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LvwTemporadas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<Temporada> temporadas = ConexionTemporada.buscar(LvwTemporadas.SelectedItems[0].SubItems[0].Text, "Nombre");
            List<Pelicula> peliculas = ConexionPelicula.buscar(LvwTemporadas.SelectedItems[0].SubItems[0].Text, "Nombre");
            if (temporadas.Count == 0)
            {
                FrmReproductor reproductor = new FrmReproductor(peliculas[0].getRuta());
                reproductor.ShowDialog();
            }
            else
            {
                FrmTemporada temporada = new FrmTemporada(temporadas[0]);
                temporada.ShowDialog();
            }
            
        }
        private void PcbAñadir_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            Lista entrada = ConexionLista.buscarEntrada(Sesion.id, animeClick.getNombre());
            if (entrada != null)
            {
                DialogResult dialogo = MessageBox.Show("¿Quieres borrar " + animeClick.getNombre() + " de tu lista?",
               "Eliminar Anime", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    Lista lista = new Lista(entrada.getId(), Sesion.id, animeClick.getNombre(), CbxNota.SelectedText, dt.ToString("D"));
                    ConexionLista.eliminar(lista);
                    MessageBox.Show("Anime Eliminado de tu lista", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PcbAñadir.Image = Properties.Resources.Añadir;
                    CbxNota.Text = "";
                }
            }
            else if (!String.IsNullOrEmpty(CbxNota.Text))
            {
                ErrLista.Clear();
                Lista lista = new Lista(0, Sesion.id, animeClick.getNombre(), CbxNota.SelectedText, dt.ToString("D"));
                ConexionLista.crear(lista);
                MessageBox.Show("Anime Añadido a tu lista", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PcbAñadir.Image = Properties.Resources.Añadido;
            }
            else
            {
                ErrLista.SetError(CbxNota, "No has puesto nota");
            }
        }
    }
}