using Newtonsoft.Json;
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
    public partial class FrmPrincipal : Form
    {
        Boolean Anime = false;
        Boolean User = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            autoCompletar();
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }
        private void BtnAnime_Click(object sender, EventArgs e)
        {
            if (!Anime)
            {
                BtnAnime.Font = new System.Drawing.Font(BtnAnime.Font, FontStyle.Bold);
                BtnUsuarios.Font = new System.Drawing.Font(BtnUsuarios.Font, FontStyle.Regular);
                llenarListViewAnime();
                resetGeneros();
                Anime = true;
                User = false;
            }
        }
        private void BtnPeliculas_Click(object sender, EventArgs e)
        {
            if (!User)
            {
                BtnAnime.Font = new System.Drawing.Font(BtnAnime.Font, FontStyle.Regular);
                BtnUsuarios.Font = new System.Drawing.Font(BtnUsuarios.Font, FontStyle.Bold);
                llenarListViewUsuarios();
                resetGeneros();
                Anime = false;
                User = true;
            }
        }
        private void botonGenero_Click(object sender, EventArgs e)
        {
            RJButton boton = (RJButton)sender;
            if (boton.Tag.Equals("0"))
            {
                resetGeneros();
                boton.BorderColor = Color.FromArgb(47, 202, 167);
                boton.ForeColor = Color.FromArgb(47, 202, 167);
                boton.Tag = 1;
                llenarListViewGenero(boton.Text);
            }
            else
            {
                Anime = false;
                resetGeneros();
            }
        }
        private void llenarListViewAnime()
        {
            if (!Anime)
            {
                ImgLista.Images.Clear();
                LvwAnimes.Items.Clear();
                LblCarga.Visible = true;
                PrbCarga.Visible = true;
                List<Anime> animes = ConexionAnime.listar();
                PrbCarga.Minimum = 1;
                PrbCarga.Maximum = animes.Count();
                PrbCarga.Value = 10;
                int i = 0;
                LvwAnimes.LargeImageList = ImgLista;
                foreach (Anime anime in animes)
                {
                    PcbAyuda.Load(anime.getImagen());
                    ImgLista.Images.Add(PcbAyuda.Image);
                    ListViewItem lista = new ListViewItem(anime.getNombre(), i);
                    LvwAnimes.Items.Add(lista);
                    PrbCarga.PerformStep();
                    i++;
                }                
                LblCarga.Visible = false;
                PrbCarga.Visible = false;
            }
        }
        private void llenarListViewUsuarios()
        {
            if (!User)
            {
                ImgLista.Images.Clear();
                LvwAnimes.Items.Clear();
                LblCarga.Visible = true;
                PrbCarga.Visible = true;
                List<Usuarios> usuarios = ConexionUsuarios.listar();
                PrbCarga.Minimum = 1;
                PrbCarga.Maximum = usuarios.Count();
                PrbCarga.Value = 1;
                int i = 0;
                LvwAnimes.LargeImageList = ImgLista;
                foreach (Usuarios usuario in usuarios)
                {
                    PcbAyuda.Image = Image.FromStream(ModeloUsuarios.ByteImage(usuario.getImagen()));
                    ImgLista.Images.Add(PcbAyuda.Image);
                    ListViewItem lista = new ListViewItem(usuario.getUsuario(), i);
                    LvwAnimes.Items.Add(lista);
                    PrbCarga.PerformStep();
                    i++;
                }
                LblCarga.Visible = false;
                PrbCarga.Visible = false;
            }
        }
        private void llenarListViewGenero(String genero)
        {
            if (!User)
            {
                ImgLista.Images.Clear();
                LvwAnimes.Items.Clear();
                LblCarga.Visible = true;
                PrbCarga.Visible = true;
                List<Anime> animes = ConexionAnime.buscar(genero, "Genero");
                PrbCarga.Minimum = 1;
                PrbCarga.Maximum = animes.Count();
                PrbCarga.Value = 1;
                int i = 0;
                LvwAnimes.LargeImageList = ImgLista;
                foreach (Anime anime in animes)
                {
                    PcbAyuda.Load(anime.getImagen());
                    ImgLista.Images.Add(PcbAyuda.Image);
                    ListViewItem lista = new ListViewItem(anime.getNombre(), i);
                    LvwAnimes.Items.Add(lista);
                    PrbCarga.PerformStep();
                    i++;
                }
                LblCarga.Visible = false;
                PrbCarga.Visible = false;
            }
        }
        private void resetGeneros()
        {
            BtnAccion.BorderColor = Color.Black;
            BtnAccion.TextColor = Color.Black;
            BtnAccion.Tag = "0";

            BtnArtes.BorderColor = Color.Black;
            BtnArtes.TextColor = Color.Black;
            BtnArtes.Tag = "0";

            BtnAventuras.BorderColor = Color.Black;
            BtnAventuras.TextColor = Color.Black;
            BtnAventuras.Tag = "0";

            BtnCiencia.BorderColor = Color.Black;
            BtnCiencia.TextColor = Color.Black;
            BtnCiencia.Tag = "0";

            BtnComedia.BorderColor = Color.Black;
            BtnComedia.TextColor = Color.Black;
            BtnComedia.Tag = "0";

            BtnDemonios.BorderColor = Color.Black;
            BtnDemonios.TextColor = Color.Black;
            BtnDemonios.Tag = "0";

            BtnDeportes.BorderColor = Color.Black;
            BtnDeportes.TextColor = Color.Black;
            BtnDeportes.Tag = "0";

            BtnDrama.BorderColor = Color.Black;
            BtnDrama.TextColor = Color.Black;
            BtnDrama.Tag = "0";

            BtnEcchi.BorderColor = Color.Black;
            BtnEcchi.TextColor = Color.Black;
            BtnEcchi.Tag = "0";

            BtnEscolares.BorderColor = Color.Black;
            BtnEscolares.TextColor = Color.Black;
            BtnEscolares.Tag = "0";

            BtnFantasia.BorderColor = Color.Black;
            BtnFantasia.TextColor = Color.Black;

            BtnHarem.BorderColor = Color.Black;
            BtnHarem.TextColor = Color.Black;
            BtnHarem.Tag = "0";

            BtnHistorico.BorderColor = Color.Black;
            BtnHistorico.TextColor = Color.Black;
            BtnHistorico.Tag = "0";

            BtnJuegos.BorderColor = Color.Black;
            BtnJuegos.TextColor = Color.Black;
            BtnJuegos.Tag = "0";

            BtnMagia.BorderColor = Color.Black;
            BtnMagia.TextColor = Color.Black;
            BtnMagia.Tag = "0";

            BtnMecha.BorderColor = Color.Black;
            BtnMecha.TextColor = Color.Black;
            BtnMecha.Tag = "0";

            BtnMilitar.BorderColor = Color.Black;
            BtnMilitar.TextColor = Color.Black;
            BtnMilitar.Tag = "0";

            BtnMisterio.BorderColor = Color.Black;
            BtnMisterio.TextColor = Color.Black;
            BtnMisterio.Tag = "0";

            BtnMusica.BorderColor = Color.Black;
            BtnMusica.TextColor = Color.Black;
            BtnMusica.Tag = "0";

            BtnPolicial.BorderColor = Color.Black;
            BtnPolicial.TextColor = Color.Black;
            BtnPolicial.Tag = "0";

            BtnPsicologico.BorderColor = Color.Black;
            BtnPsicologico.TextColor = Color.Black;
            BtnPsicologico.Tag = "0";

            BtnRomance.BorderColor = Color.Black;
            BtnRomance.TextColor = Color.Black;
            BtnRomance.Tag = "0";

            BtnSeinen.BorderColor = Color.Black;
            BtnSeinen.TextColor = Color.Black;
            BtnSeinen.Tag = "0";

            BtnShoujo.BorderColor = Color.Black;
            BtnShoujo.TextColor = Color.Black;
            BtnShoujo.Tag = "0";

            BtnShounen.BorderColor = Color.Black;
            BtnShounen.TextColor = Color.Black;
            BtnShounen.Tag = "0";

            BtnSlice.BorderColor = Color.Black;
            BtnSlice.TextColor = Color.Black;
            BtnSlice.Tag = "0";

            BtnSobrenatural.BorderColor = Color.Black;
            BtnSobrenatural.TextColor = Color.Black;
            BtnSobrenatural.Tag = "0";

            BtnSuperpoderes.BorderColor = Color.Black;
            BtnSuperpoderes.TextColor = Color.Black;
            BtnSuperpoderes.Tag = "0";

            BtnSuspense.BorderColor = Color.Black;
            BtnSuspense.TextColor = Color.Black;
            BtnSuspense.Tag = "0";

            BtnTerror.BorderColor = Color.Black;
            BtnTerror.TextColor = Color.Black;
            BtnTerror.Tag = "0";

            BtnVampiros.BorderColor = Color.Black;
            BtnVampiros.TextColor = Color.Black;
            BtnVampiros.Tag = "0";

            BtnYaoi.BorderColor = Color.Black;
            BtnYaoi.TextColor = Color.Black;
            BtnYaoi.Tag = "0";
        }
        private void PbcPerfil_Click(object sender, EventArgs e)
        {
            if (PnlSubMenu.Visible)
            {
                PnlSubMenu.Visible = false;
            }
            else
            {
                PnlSubMenu.Visible = true;
            }
        }
        private void BtnFiltros_Click(object sender, EventArgs e)
        {
            if (!BtnAccion.Visible)
            {
                BtnFiltros.Text = "Filtros 🢙";
                BtnAccion.Visible = true;
                BtnArtes.Visible = true;
                BtnAventuras.Visible = true;
                BtnCiencia.Visible = true;
                BtnComedia.Visible = true;
                BtnDemonios.Visible = true;
                BtnDeportes.Visible = true;
                BtnDrama.Visible = true;
                BtnEcchi.Visible = true;
                BtnEscolares.Visible = true;
                BtnFantasia.Visible = true;
                BtnHarem.Visible = true;
                BtnHistorico.Visible = true;
                BtnJuegos.Visible = true;
                BtnMagia.Visible = true;
                BtnMecha.Visible = true;
                BtnMilitar.Visible = true;
                BtnMisterio.Visible = true;
                BtnMusica.Visible = true;
                BtnMusica.Visible = true;
                BtnPolicial.Visible = true;
                BtnPsicologico.Visible = true;
                BtnRomance.Visible = true;
                BtnSeinen.Visible = true;
                BtnShoujo.Visible = true;
                BtnShounen.Visible = true;
                BtnSlice.Visible = true;
                BtnSobrenatural.Visible = true;
                BtnSuperpoderes.Visible = true;
                BtnSuspense.Visible = true;
                BtnTerror.Visible = true;
                BtnVampiros.Visible = true;
                BtnYaoi.Visible = true;
            }
            else
            {
                BtnFiltros.Text = "Filtros 🢛";
                BtnAccion.Visible = false;
                BtnArtes.Visible = false;
                BtnAventuras.Visible = false;
                BtnCiencia.Visible = false;
                BtnComedia.Visible = false;
                BtnDemonios.Visible = false;
                BtnDeportes.Visible = false;
                BtnDrama.Visible = false;
                BtnEcchi.Visible = false;
                BtnEscolares.Visible = false;
                BtnFantasia.Visible = false;
                BtnHarem.Visible = false;
                BtnHistorico.Visible = false;
                BtnJuegos.Visible = false;
                BtnMagia.Visible = false;
                BtnMecha.Visible = false;
                BtnMilitar.Visible = false;
                BtnMisterio.Visible = false;
                BtnMusica.Visible = false;
                BtnMusica.Visible = false;
                BtnPolicial.Visible = false;
                BtnPsicologico.Visible = false;
                BtnRomance.Visible = false;
                BtnSeinen.Visible = false;
                BtnShoujo.Visible = false;
                BtnShounen.Visible = false;
                BtnSlice.Visible = false;
                BtnSobrenatural.Visible = false;
                BtnSuperpoderes.Visible = false;
                BtnSuspense.Visible = false;
                BtnTerror.Visible = false;
                BtnVampiros.Visible = false;
                BtnYaoi.Visible = false;
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PcbPerfil.Image = Image.FromStream(ModeloUsuarios.ByteImage(Sesion.imagen));
            if (Sesion.id_tipo == 1)
            {
                PcbConfiguracion.Visible = true;
            }
            else
            {
                PcbConfiguracion.Visible = false;
            }
        }
        private void BtnCerrar_Click(object sender,EventArgs e)
        {
            ModeloUsuarios.jsonWriter(0, "null");
            ConexionUsuarios.crearSesion(Sesion.usuario, ModeloUsuarios.generarSHA1(FrmLogIn.generarCodSesion()));
            FrmLogIn inicio = new FrmLogIn();
            Sesion nueva = new Sesion();
            this.Dispose();
            inicio.Show();
        }
        private void LvwAnimes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Boolean esta = false;
            if (primeraMayus(LvwAnimes.SelectedItems[0].SubItems[0].Text))
            {
                List<Anime> animes = ConexionAnime.buscar(LvwAnimes.SelectedItems[0].SubItems[0].Text, "Nombre");
                FrmAnime anime = new FrmAnime(animes[0]);
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FrmAnime))
                    {
                        esta = true;
                        break;
                    }
                }
                if (!esta)
                {
                    anime.Show();
                }
            }
            else
            {
                Usuarios usuario = ModeloUsuarios.porUsuario(LvwAnimes.SelectedItems[0].SubItems[0].Text);
                FrmLista lista = new FrmLista(usuario, false);
                lista.ShowDialog();
            }
        }
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario(this);
            usuario.ShowDialog();
        }
        private void PcbConfiguracion_Click(object sender, EventArgs e)
        {
            FrmControl control = new FrmControl();
            this.Dispose();
            control.Show();
        }
        private void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            for (int i = 0; i < ConexionAnime.buscarDinamico().Rows.Count; i++)
            {
                lista.Add(ConexionAnime.buscarDinamico().Rows[i]["Nombre"].ToString());
            }
            for (int i = 0; i < ConexionUsuarios.buscarDinamico().Rows.Count; i++)
            {
                lista.Add(ConexionUsuarios.buscarDinamico().Rows[i]["Usuario"].ToString());
            }
            TxtBuscar.AutoCompleteCustomSource = lista;
        }
        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && primeraMayus(TxtBuscar.Text))
            {
                List<Anime> animes = ConexionAnime.buscar(TxtBuscar.Text, "Nombre");
                if (animes.Count != 0)
                {
                    ImgLista.Images.Clear();
                    BtnUsuarios.Font = new System.Drawing.Font(BtnUsuarios.Font, FontStyle.Regular);
                    BtnAnime.Font = new System.Drawing.Font(BtnUsuarios.Font, FontStyle.Regular);
                    Anime = false;
                    User = false;
                    LvwAnimes.Items.Clear();
                    LvwAnimes.LargeImageList = ImgLista;
                    PcbAyuda.Load(animes[0].getImagen());
                    ImgLista.Images.Add(PcbAyuda.Image);
                    ListViewItem lista = new ListViewItem(animes[0].getNombre(), 0);
                    LvwAnimes.Items.Add(lista);
                    resetGeneros();
                }
            }
            else if (e.KeyCode == Keys.Enter && !primeraMayus(TxtBuscar.Text))
            {
                List<Usuarios> usuarios = ConexionUsuarios.buscar(TxtBuscar.Text, "Usuario");
                if (usuarios.Count != 0)
                {
                    ImgLista.Images.Clear();
                    BtnUsuarios.Font = new System.Drawing.Font(BtnUsuarios.Font, FontStyle.Regular);
                    BtnAnime.Font = new System.Drawing.Font(BtnUsuarios.Font, FontStyle.Regular);
                    Anime = false;
                    User = false;
                    LvwAnimes.Items.Clear();
                    ImageList icono = new ImageList();
                    icono.ImageSize = new Size(160, 220);
                    LvwAnimes.SmallImageList = icono;
                    LvwAnimes.LargeImageList = icono;
                    PcbAyuda.Image = Image.FromStream(ModeloUsuarios.ByteImage(usuarios[0].getImagen()));
                    icono.Images.Add(PcbAyuda.Image);
                    ListViewItem lista = new ListViewItem(usuarios[0].getUsuario(), 0);
                    LvwAnimes.Items.Add(lista);
                    resetGeneros();
                }
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
        private void BtnLista_Click(object sender, EventArgs e)
        {
            List<Usuarios> usuarios = ConexionUsuarios.buscar(Sesion.id.ToString(),"Id");
            FrmLista lista = new FrmLista(usuarios[0], true);
            lista.ShowDialog();
        }
    }
}
