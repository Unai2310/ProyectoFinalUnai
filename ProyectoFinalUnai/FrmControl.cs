using MySql.Data.MySqlClient;
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
    public partial class FrmControl : Form
    {
        String formato = "png";
        public FrmControl()
        {
            InitializeComponent();
        }
        /////////////////////////////////////////////////////
        //CRUD ANIME
        /////////////////////////////////////////////////////
        private void BtnCrearAnime_Click(object sender, EventArgs e) // CREAR ANIME
        {
            if (!String.IsNullOrEmpty(TxtNombreA.Text) && !String.IsNullOrEmpty(TxtGeneroA.Text) && !String.IsNullOrEmpty(TxtRutaA.Text) && !String.IsNullOrEmpty(TxtImagenA.Text) && !String.IsNullOrEmpty(TxtTemporadasA.Text) && !String.IsNullOrEmpty(TxtTemporadasA.Text))
            {
                Anime anime = new Anime(TxtNombreA.Text, TxtGeneroA.Text, TxtRutaA.Text, TxtImagenA.Text, Convert.ToInt32(TxtTemporadasA.Text), Convert.ToInt32(TxtCapitulosA.Text));
                try
                {
                    ConexionAnime.crear(anime);
                    MessageBox.Show("Anime Añadido", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void BTnActulizarAnime_Click(object sender, EventArgs e) //ACTUALIZAR ANIME
        {
            if (!String.IsNullOrEmpty(TxtNombreA.Text) && !String.IsNullOrEmpty(TxtGeneroA.Text) 
                && !String.IsNullOrEmpty(TxtRutaA.Text) && !String.IsNullOrEmpty(TxtImagenA.Text) 
                && !String.IsNullOrEmpty(TxtTemporadasA.Text) && !String.IsNullOrEmpty(TxtTemporadasA.Text))
            {
                Anime anime = new Anime(TxtNombreA.Text, TxtGeneroA.Text, TxtRutaA.Text, TxtImagenA.Text, Convert.ToInt32(TxtTemporadasA.Text), Convert.ToInt32(TxtTemporadasA.Text));
                try
                {
                    ConexionAnime.actualizar(anime);
                    MessageBox.Show("Anime Actualizado", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBorrarAnime_Click(object sender, EventArgs e) //BORRAR ANIME
        {
            if (!String.IsNullOrEmpty(TxtNombreA.Text))
            {
                Anime anime = new Anime(TxtNombreA.Text, TxtGeneroA.Text, TxtRutaA.Text, TxtImagenA.Text, Convert.ToInt32(TxtTemporadasA.Text), Convert.ToInt32(TxtCapitulosA.Text));
                try
                {
                    ConexionAnime.eliminar(anime);
                    MessageBox.Show("Anime Borrado", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Nombre para borrar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBuscarAnime_Click(object sender, EventArgs e) //BUSCAR ANIME
        {
            var (campo, valor) = buscarPorAnimeTxt();
            if (!String.IsNullOrEmpty(valor.Text))
            {
                try
                {
                    List<Anime> animes = ConexionAnime.buscar(valor.Text, campo);
                    DtgAnime.Rows.Clear();
                    foreach (Anime anime in animes)
                    {
                        DtgAnime.Rows.Add(anime.getNombre(), anime.getGenero(), anime.getRuta(), anime.getImagen(), anime.getTemporadas(), anime.getCapitulos());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Nombre para Buscar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnListarAnime_Click(object sender, EventArgs e) //LISTAR ANIME
        {
            try
            {
                List<Anime> animes = ConexionAnime.listar();
                DtgAnime.Rows.Clear();
                foreach (Anime anime in animes)
                {
                    DtgAnime.Rows.Add(anime.getNombre(), anime.getGenero(), anime.getRuta(), anime.getImagen(), anime.getTemporadas(), anime.getCapitulos());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DtgAnime_CellClick(object sender, DataGridViewCellEventArgs e) //CLICK DATAGRAM ANIME
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DtgAnime.Rows[e.RowIndex];
                    TxtNombreA.Text = row.Cells[0].Value.ToString();
                    TxtGeneroA.Text = row.Cells[1].Value.ToString();
                    TxtRutaA.Text = row.Cells[2].Value.ToString();
                    TxtImagenA.Text = row.Cells[3].Value.ToString();
                    TxtTemporadasA.Text = row.Cells[4].Value.ToString();
                    TxtCapitulosA.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /////////////////////////////////////////////////////
        //CRUD TEMPORADA
        /////////////////////////////////////////////////////
        private void BtnCrearTemp_Click(object sender, EventArgs e) //CREAR TEMPORADA
        {
            if (!String.IsNullOrEmpty(TxtIdT.Text) && !String.IsNullOrEmpty(TxtNombreT.Text) && !String.IsNullOrEmpty(TxtCapitulosT.Text) && !String.IsNullOrEmpty(TxtRutaT.Text) && !String.IsNullOrEmpty(TxtOpT.Text) && !String.IsNullOrEmpty(TxtAnimeT.Text) && !String.IsNullOrEmpty(TxtPosicionT.Text))
            {
                Temporada temporada = new Temporada(TxtIdT.Text, TxtNombreT.Text, Convert.ToInt32(TxtCapitulosT.Text), TxtRutaT.Text, TxtOpT.Text, TxtAnimeT.Text, Convert.ToInt32(TxtPosicionT.Text));
                try
                {
                    ConexionTemporada.crear(temporada);
                    MessageBox.Show("Temporada Actualizada", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnActualizarTemp_Click(object sender, EventArgs e) // ACTUALIZAR TEMPORADA
        {
            if (!String.IsNullOrEmpty(TxtIdT.Text) && !String.IsNullOrEmpty(TxtNombreT.Text) && !String.IsNullOrEmpty(TxtCapitulosT.Text) && !String.IsNullOrEmpty(TxtRutaT.Text) && !String.IsNullOrEmpty(TxtOpT.Text) && !String.IsNullOrEmpty(TxtAnimeT.Text) && !String.IsNullOrEmpty(TxtPosicionT.Text))
            {
                Temporada temporada = new Temporada(TxtIdT.Text, TxtNombreT.Text, Convert.ToInt32(TxtCapitulosT.Text), TxtRutaT.Text, TxtOpT.Text, TxtAnimeT.Text, Convert.ToInt32(TxtPosicionT.Text));
                try
                {
                    ConexionTemporada.actualizar(temporada);
                    MessageBox.Show("Temporada Actualizada", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBorrarTemp_Click(object sender, EventArgs e) //BORRAR TEMPORADA
        {
            if (!String.IsNullOrEmpty(TxtIdT.Text))
            {
                Temporada temporada = new Temporada(TxtIdT.Text, TxtNombreT.Text, Convert.ToInt32(TxtPosicionT.Text), TxtRutaT.Text, TxtOpT.Text, TxtAnimeT.Text, Convert.ToInt32(TxtPosicionT.Text));
                try
                {
                    ConexionTemporada.eliminar(temporada);
                    MessageBox.Show("Temporada Eliminada", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Id para borrar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBuscarTemp_Click(object sender, EventArgs e) //BUSCAR TEMPORADA
        {
            var (campo, valor) = buscarPorTemporadaTxt();
            if (!String.IsNullOrEmpty(valor.Text))
            {
                try
                {
                    List<Temporada> temporadas = ConexionTemporada.buscar(valor.Text, campo);
                    DtgTemporada.Rows.Clear();
                    foreach (Temporada temporada in temporadas)
                    {
                        DtgTemporada.Rows.Add(temporada.getId(), temporada.getNombre(), temporada.getCapitulos(), temporada.getRuta(), temporada.getOp(), temporada.getAnime(), temporada.getPosicion());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Id para buscar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnListarTemp_Click(object sender, EventArgs e) // LISTAR TEMPORADA
        {
            List<Temporada> temporadas = ConexionTemporada.listar();
            try
            {
                DtgTemporada.Rows.Clear();
                foreach (Temporada temporada in temporadas)
                {
                    DtgTemporada.Rows.Add(temporada.getId(), temporada.getNombre(), temporada.getCapitulos(), temporada.getRuta(), temporada.getOp(), temporada.getAnime(), temporada.getPosicion());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DtgTemporada_CellClick(object sender, DataGridViewCellEventArgs e) //CLICK DATAGRAM TEMPORADA
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DtgTemporada.Rows[e.RowIndex];
                    TxtIdT.Text = row.Cells[0].Value.ToString();
                    TxtNombreT.Text = row.Cells[1].Value.ToString();
                    TxtCapitulosT.Text = row.Cells[2].Value.ToString();
                    TxtRutaT.Text = row.Cells[3].Value.ToString();
                    TxtOpT.Text = row.Cells[4].Value.ToString();
                    TxtAnimeT.Text = row.Cells[5].Value.ToString();
                    TxtPosicionT.Text = row.Cells[6].Value.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /////////////////////////////////////////////////////
        //CRUD PELICULA
        /////////////////////////////////////////////////////
        private void BtnCrearPel_Click(object sender, EventArgs e) //CREAR PELICULA
        {
            if (!String.IsNullOrEmpty(TxtIdP.Text) && !String.IsNullOrEmpty(TxtNombreP.Text) && !String.IsNullOrEmpty(TxtDuracionP.Text) && !String.IsNullOrEmpty(TxtRutaP.Text) && !String.IsNullOrEmpty(TxtAnimeP.Text) && !String.IsNullOrEmpty(TxtPosicionP.Text))
            {
                try
                {
                    Pelicula pelicula = new Pelicula(TxtIdP.Text, TxtNombreP.Text, Convert.ToInt32(TxtDuracionP.Text), TxtRutaP.Text, TxtAnimeP.Text, Convert.ToInt32(TxtPosicionP.Text));
                    ConexionPelicula.crear(pelicula);
                    MessageBox.Show("Pelicula Añadida", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnActualizarPel_Click(object sender, EventArgs e) //ACTUALIZAR PELICULA
        {
            if (!String.IsNullOrEmpty(TxtIdP.Text) && !String.IsNullOrEmpty(TxtNombreP.Text) && !String.IsNullOrEmpty(TxtDuracionP.Text) && !String.IsNullOrEmpty(TxtRutaP.Text) && !String.IsNullOrEmpty(TxtAnimeP.Text) && !String.IsNullOrEmpty(TxtPosicionP.Text))
            {
                Pelicula pelicula = new Pelicula(TxtIdP.Text, TxtNombreP.Text, Convert.ToInt32(TxtDuracionP.Text), TxtRutaP.Text, TxtAnimeP.Text, Convert.ToInt32(TxtPosicionP.Text));
                try
                {
                    ConexionPelicula.actualizar(pelicula);
                    MessageBox.Show("Pelicula Actualizada", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBorrarPel_Click(object sender, EventArgs e) //BORRAR PELICULA
        {
            if (!String.IsNullOrEmpty(TxtIdP.Text))
            {
                Pelicula pelicula = new Pelicula(TxtIdP.Text, TxtNombreP.Text, Convert.ToInt32(TxtDuracionP.Text), TxtRutaP.Text, TxtAnimeP.Text, Convert.ToInt32(TxtPosicionP.Text));
                try
                {
                    ConexionPelicula.eliminar(pelicula);
                    MessageBox.Show("Pelicula Eliminada", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Id para borrar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBuscarPel_Click(object sender, EventArgs e) //BUSCAR PELICULA
        {
            var (campo, valor) = buscarPorPeliculaTxt();
            if (!String.IsNullOrEmpty(valor.Text))
            {
                try
                {
                    List<Pelicula> peliculas = ConexionPelicula.buscar(valor.Text, campo);
                    DtgPelicula.Rows.Clear();
                    foreach (Pelicula pelicula in peliculas)
                    {
                        DtgPelicula.Rows.Add(pelicula.getId(), pelicula.getNombre(), pelicula.getDuracion(), pelicula.getRuta(), pelicula.getAnime(), pelicula.getPosicion());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Id para buscar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnListarPel_Click(object sender, EventArgs e) //LISTAR PELICULA
        {
            List<Pelicula> peliculas = ConexionPelicula.listar();
            try
            {
                DtgPelicula.Rows.Clear();
                foreach (Pelicula pelicula in peliculas)
                {
                    DtgPelicula.Rows.Add(pelicula.getId(), pelicula.getNombre(), pelicula.getDuracion(), pelicula.getRuta(), pelicula.getAnime(), pelicula.getPosicion());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DtgPelicula_CellClick(object sender, DataGridViewCellEventArgs e) //CLICK DATAGRAM TEMPORADA
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DtgPelicula.Rows[e.RowIndex];
                    TxtIdP.Text = row.Cells[0].Value.ToString();
                    TxtNombreP.Text = row.Cells[1].Value.ToString();
                    TxtDuracionP.Text = row.Cells[2].Value.ToString();
                    TxtRutaP.Text = row.Cells[3].Value.ToString();
                    TxtAnimeP.Text = row.Cells[4].Value.ToString();
                    TxtPosicionP.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /////////////////////////////////////////////////////
        //CRUD USUARIOS
        /////////////////////////////////////////////////////
        private void BtnCrearU_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtIdU.Text) && !String.IsNullOrEmpty(TxtUsuarioU.Text) && !String.IsNullOrEmpty(TxtPasswordU.Text) && !String.IsNullOrEmpty(TxtNombreU.Text) && !String.IsNullOrEmpty(TxtApellidoU.Text) && !String.IsNullOrEmpty(TxtCorreoU.Text) && Int32.Parse(TxtId_TipoU.Text) <= 2 && PcbImagenU.Image != null)
            {
                try
                {
                    Usuarios usuario = new Usuarios(Int32.Parse(TxtIdU.Text), TxtUsuarioU.Text.ToLower(), TxtPasswordU.Text, TxtNombreU.Text, TxtApellidoU.Text, TxtCorreoU.Text, Int32.Parse(TxtId_TipoU.Text), ModeloUsuarios.ImageByte(PcbImagenU.Image, formato));
                    ConexionUsuarios.crearAdmin(usuario);
                    MessageBox.Show("Usuario Añadido", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnActualizarU_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtIdU.Text) && !String.IsNullOrEmpty(TxtUsuarioU.Text) && !String.IsNullOrEmpty(TxtPasswordU.Text) && !String.IsNullOrEmpty(TxtNombreU.Text) && !String.IsNullOrEmpty(TxtApellidoU.Text) && !String.IsNullOrEmpty(TxtCorreoU.Text) && Int32.Parse(TxtId_TipoU.Text) <= 2 && !PcbImagenU.Image.Equals(null))
            {
                try
                {
                    Usuarios usuario = new Usuarios(Int32.Parse(TxtIdU.Text), TxtUsuarioU.Text.ToLower(), TxtPasswordU.Text, TxtNombreU.Text, TxtApellidoU.Text, TxtCorreoU.Text, Int32.Parse(TxtId_TipoU.Text), ModeloUsuarios.ImageByte(PcbImagenU.Image, formato));
                    ConexionUsuarios.actualizar(usuario);
                    MessageBox.Show("Usuario Actualizado", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBorrarU_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtIdU.Text))
            {
                Usuarios usuario = new Usuarios(Int32.Parse(TxtIdU.Text), TxtUsuarioU.Text, TxtPasswordU.Text, TxtNombreU.Text, TxtApellidoU.Text, TxtCorreoU.Text, Int32.Parse(TxtId_TipoU.Text), ModeloUsuarios.ImageByte(PcbImagenU.Image));
                try
                {
                    ConexionUsuarios.eliminar(usuario);
                    MessageBox.Show("Usuario Eliminado", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Id para borrar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnBuscarU_Click(object sender, EventArgs e)
        {
            var (campo, valor) = buscarPorUsuarioTxt();
            if (!String.IsNullOrEmpty(valor.Text))
            {
                try
                {
                    List<Usuarios> usuarios = ConexionUsuarios.buscar(valor.Text, campo);
                    DtgUsuario.Rows.Clear();
                    foreach (Usuarios usuario in usuarios)
                    {
                        DtgUsuario.Rows.Add(usuario.getId(), usuario.getUsuario(), usuario.getPassword(), usuario.getNombre(), usuario.getApellido(), usuario.getCorreo(), usuario.getId_tipo());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Falta Id para buscar", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnListarU_Click(object sender, EventArgs e)
        {
            List<Usuarios> usuarios = ConexionUsuarios.listar();
            try
            {
                DtgUsuario.Rows.Clear();
                foreach (Usuarios usuario in usuarios)
                {
                    DtgUsuario.Rows.Add(usuario.getId(), usuario.getUsuario(), usuario.getPassword(), usuario.getNombre(), usuario.getApellido(), usuario.getCorreo(), usuario.getId_tipo());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PcbImagenU_Click(object sender, EventArgs e)
        {
            if (OfdImagen.ShowDialog() == DialogResult.OK)
            {
                Image imagen = Image.FromFile(OfdImagen.FileName);
                formato = obtenerFormato(OfdImagen.FileName);
                PcbImagenU.Image = imagen;
            }
        }
        private void DtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DtgUsuario.Rows[e.RowIndex];
                    TxtIdU.Text = row.Cells[0].Value.ToString();
                    TxtUsuarioU.Text = row.Cells[1].Value.ToString();
                    TxtPasswordU.Text = row.Cells[2].Value.ToString();
                    TxtNombreU.Text = row.Cells[3].Value.ToString();
                    TxtApellidoU.Text = row.Cells[4].Value.ToString();
                    TxtCorreoU.Text = row.Cells[5].Value.ToString();
                    TxtId_TipoU.Text = row.Cells[6].Value.ToString();
                    List<Usuarios> usuarios = ConexionUsuarios.buscar(row.Cells[0].Value.ToString(), "Id");
                    PcbImagenU.Image = Image.FromStream(ModeloUsuarios.ByteImage(usuarios[0].getImagen()));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /////////////////////////////////////////
        ///CLICK LABELS ANIME
        /////////////////////////////////////////
        private void LblNombreA_Click(object sender, EventArgs e)
        {
            LblNombreA.Text = "Nombre 🔎";
            LblGeneroA.Text = "Genero";
            LblTemporadasA.Text = "Temporadas";
            LblCapitulosA.Text = "Capitulos";
        }
        private void LblGeneroA_Click(object sender, EventArgs e)
        {
            LblNombreA.Text = "Nombre";
            LblGeneroA.Text = "Genero 🔎";
            LblTemporadasA.Text = "Temporadas";
            LblCapitulosA.Text = "Capitulos";
        }
        private void LblTemporadasA_Click(object sender, EventArgs e)
        {
            LblNombreA.Text = "Nombre";
            LblGeneroA.Text = "Genero";
            LblTemporadasA.Text = "Temporadas 🔎";
            LblCapitulosA.Text = "Capitulos";
        }
        private void LblCapitulosA_Click(object sender, EventArgs e)
        {
            LblNombreA.Text = "Nombre";
            LblGeneroA.Text = "Genero";
            LblTemporadasA.Text = "Temporadas";
            LblCapitulosA.Text = "Capitulos 🔎";
        }
        private (String, TextBox) buscarPorAnimeTxt()
        {
            if (LblNombreA.Text.EndsWith("🔎"))
            {
                return (LblNombreA.Text.Substring(0, LblNombreA.Text.Length - 2), TxtNombreA);
            }
            else if (LblGeneroA.Text.EndsWith("🔎"))
            {
                return (LblGeneroA.Text.Substring(0, LblGeneroA.Text.Length - 2), TxtGeneroA);
            }
            else if (LblTemporadasA.Text.EndsWith("🔎"))
            {
                return (LblTemporadasA.Text.Substring(0, LblTemporadasA.Text.Length - 2), TxtTemporadasA);
            }
            else if (LblCapitulosA.Text.EndsWith("🔎"))
            {
                return (LblCapitulosA.Text.Substring(0, LblCapitulosA.Text.Length - 2), TxtCapitulosA);
            }
            else
            {
                return (null, null);
            }
        }
        /////////////////////////////////////////
        ///CLICK LABELS TEMPORADA
        /////////////////////////////////////////
        private void LblIdT_Click(object sender, EventArgs e)
                {
                    LblIdT.Text = "Id 🔎";
                    LblNombreT.Text = "Nombre";
                    LblCapitulosT.Text = "Capitulos";
                    LblAnimeT.Text = "Anime";
                    LblPosicionT.Text = "Posicion";
                }
        private void LblNombreT_Click(object sender, EventArgs e)
        {
            LblIdT.Text = "Id";
            LblNombreT.Text = "Nombre 🔎";
            LblCapitulosT.Text = "Capitulos";
            LblAnimeT.Text = "Anime";
            LblPosicionT.Text = "Posicion";
        }
        private void LblCapitulosT_Click(object sender, EventArgs e)
        {
            LblIdT.Text = "Id";
            LblNombreT.Text = "Nombre";
            LblCapitulosT.Text = "Capitulos 🔎";
            LblAnimeT.Text = "Anime";
            LblPosicionT.Text = "Posicion";
        }
        private void LblAnimeT_Click(object sender, EventArgs e)
        {
            LblIdT.Text = "Id";
            LblNombreT.Text = "Nombre";
            LblCapitulosT.Text = "Capitulos";
            LblAnimeT.Text = "Anime 🔎";
            LblPosicionT.Text = "Posicion";
        }
        private void LblPosicionT_Click(object sender, EventArgs e)
        {
            LblIdT.Text = "Id";
            LblNombreT.Text = "Nombre";
            LblCapitulosT.Text = "Capitulos";
            LblAnimeT.Text = "Anime";
            LblPosicionT.Text = "Posicion 🔎";
        }
        private (String, TextBox) buscarPorTemporadaTxt()
        {
            if (LblIdT.Text.EndsWith("🔎"))
            {
                return (LblIdT.Text.Substring(0, LblIdT.Text.Length - 2), TxtIdT);
            }
            else if (LblNombreT.Text.EndsWith("🔎"))
            {
                return (LblNombreT.Text.Substring(0, LblNombreT.Text.Length - 2), TxtNombreT);
            }
            else if (LblCapitulosT.Text.EndsWith("🔎"))
            {
                return (LblCapitulosT.Text.Substring(0, LblCapitulosT.Text.Length - 2),TxtCapitulosT);
            }
            else if (LblAnimeT.Text.EndsWith("🔎"))
            {
                return (LblAnimeT.Text.Substring(0, LblAnimeT.Text.Length - 2), TxtAnimeT);
            }
            else if (LblPosicionT.Text.EndsWith("🔎"))
            {
                return (LblPosicionT.Text.Substring(0, LblPosicionT.Text.Length - 2), TxtPosicionT);
            }
            else
            {
                return (null, null);
            }
        }
        /////////////////////////////////////////
        ///CLICK LABELS PELICULA
        /////////////////////////////////////////
        private void LblIdP_Click(object sender, EventArgs e)
        {
            LblIdP.Text = "Id 🔎";
            LblNombreP.Text = "Nombre";
            LblDuracionP.Text = "Duracion";
            LblAnimeP.Text = "Anime";
            LblPosiconP.Text = "Posicion";
        }
        private void LblNombreP_Click(object sender, EventArgs e)
        {
            LblIdP.Text = "Id";
            LblNombreP.Text = "Nombre 🔎";
            LblDuracionP.Text = "Duracion";
            LblAnimeP.Text = "Anime";
            LblPosiconP.Text = "Posicion";
        }
        private void LblDuracionP_Click(object sender, EventArgs e)
        {
            LblIdP.Text = "Id";
            LblNombreP.Text = "Nombre";
            LblDuracionP.Text = "Duracion 🔎";
            LblAnimeP.Text = "Anime";
            LblPosiconP.Text = "Posicion";
        }
        private void LblAnimeP_Click(object sender, EventArgs e)
        {
            LblIdP.Text = "Id";
            LblNombreP.Text = "Nombre";
            LblDuracionP.Text = "Duracion";
            LblAnimeP.Text = "Anime 🔎";
            LblPosiconP.Text = "Posicion";
        }
        private void LblPosiconP_Click(object sender, EventArgs e)
        {
            LblIdP.Text = "Id";
            LblNombreP.Text = "Nombre";
            LblDuracionP.Text = "Duracion";
            LblAnimeP.Text = "Anime";
            LblPosiconP.Text = "Posicion 🔎";
        }
        private (String, TextBox) buscarPorPeliculaTxt()
        {
            if (LblIdP.Text.EndsWith("🔎"))
            {
                return (LblIdP.Text.Substring(LblIdP.Text.Length - 2), TxtIdP);
            }
            else if (LblNombreP.Text.EndsWith("🔎"))
            {
                return (LblNombreP.Text.Substring(0, LblNombreP.Text.Length - 2), TxtNombreP);
            }
            else if (LblDuracionP.Text.EndsWith("🔎"))
            {
                return (LblDuracionP.Text.Substring(0, LblDuracionP.Text.Length - 2), TxtDuracionP);
            }
            else if (LblAnimeP.Text.EndsWith("🔎"))
            {
                return (LblAnimeP.Text.Substring(0, LblAnimeP.Text.Length - 2), TxtAnimeP);
            }
            else if (LblPosiconP.Text.EndsWith("🔎"))
            {
                return (LblPosiconP.Text.Substring(LblPosiconP.Text.Length - 2), TxtPosicionP);
            }
            else
            {
                return (null, null);
            }
        }
        /////////////////////////////////////////
        ///CLICK LABELS USUARIO
        /////////////////////////////////////////
        private void LblIdU_Click(object sender, EventArgs e)
        {
            LblIdU.Text = "Id 🔎";
            LblUsuarioU.Text = "Usuario";
            LblNombreU.Text = "Nombre";
            LblApellidoU.Text = "Apellido";
            LblCorreoU.Text = "Correo";
            LblIdTipoU.Text = "Id_Tipo";
        }
        private void LblUsuarioU_Click(object sender, EventArgs e)
        {
            LblIdU.Text = "Id";
            LblUsuarioU.Text = "Usuario 🔎";
            LblNombreU.Text = "Nombre";
            LblApellidoU.Text = "Apellido";
            LblCorreoU.Text = "Correo";
            LblIdTipoU.Text = "Id_Tipo";
        }
        private void LblNombreU_Click(object sender, EventArgs e)
        {
            LblIdU.Text = "Id";
            LblUsuarioU.Text = "Usuario";
            LblNombreU.Text = "Nombre 🔎";
            LblApellidoU.Text = "Apellido";
            LblCorreoU.Text = "Correo";
            LblIdTipoU.Text = "Id_Tipo";
        }
        private void LblApellidoU_Click(object sender, EventArgs e)
        {
            LblIdU.Text = "Id";
            LblUsuarioU.Text = "Usuario";
            LblNombreU.Text = "Nombre";
            LblApellidoU.Text = "Apellido 🔎";
            LblCorreoU.Text = "Correo";
            LblIdTipoU.Text = "Id_Tipo";
        }
        private void LblCorreoU_Click(object sender, EventArgs e)
        {
            LblIdU.Text = "Id";
            LblUsuarioU.Text = "Usuario";
            LblNombreU.Text = "Nombre"; ;
            LblApellidoU.Text = "Apellido";
            LblCorreoU.Text = "Correo 🔎";
            LblIdTipoU.Text = "Id_Tipo";
        }
        private void LblIdTipoU_Click(object sender, EventArgs e)
        {
            LblIdU.Text = "Id";
            LblUsuarioU.Text = "Usuario";
            LblNombreU.Text = "Nombre";
            LblApellidoU.Text = "Apellido";
            LblCorreoU.Text = "Correo";
            LblIdTipoU.Text = "Id_Tipo 🔎";
        }
        private (String, TextBox) buscarPorUsuarioTxt()
        {
            if (LblIdU.Text.EndsWith("🔎"))
            {
                return (LblIdU.Text.Substring(0, LblIdU.Text.Length - 2), TxtIdU);
            }
            else if (LblUsuarioU.Text.EndsWith("🔎"))
            {
                return (LblUsuarioU.Text.Substring(0, LblUsuarioU.Text.Length - 2), TxtUsuarioU);
            }
            else if (LblNombreU.Text.EndsWith("🔎"))
            {
                return (LblNombreU.Text.Substring(0, LblNombreU.Text.Length - 2), TxtNombreU);
            }
            else if (LblApellidoU.Text.EndsWith("🔎"))
            {
                return (LblApellidoU.Text.Substring(0, LblApellidoU.Text.Length - 2), TxtApellidoU);
            }
            else if (LblCorreoU.Text.EndsWith("🔎"))
            {
                return (LblCorreoU.Text.Substring(0, LblCorreoU.Text.Length - 2), TxtCorreoU);
            }
            else if (LblIdTipoU.Text.EndsWith("🔎"))
            {
                return (LblIdTipoU.Text.Substring(0, LblIdTipoU.Text.Length - 2), TxtId_TipoU);
            }
            else
            {
                return (null, null);
            }
        }
        private String obtenerFormato(String foto)
        {
            return foto.Substring(foto.Length - 3, 3);
        }
        private void FrmControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void BtnCerrarA_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Dispose();
            principal.Show();
        }
    }
}
