using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUnai
{
    public partial class FrmRegistro : Form
    {

        String formato = "png";
        public FrmRegistro()
        {
            InitializeComponent();
        }
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            PcbFoto.Load("https://catbox.moe/pictures/qts/1428177904344.png");
            PcbFotoU.Load("../../resources/subir1.png");
        }
        private void PcbRegistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUsuario.Texts) || String.IsNullOrEmpty(TxtNombre.Texts) 
                || String.IsNullOrEmpty(TxtApellido.Texts) || String.IsNullOrEmpty(TxtCorreo.Texts) 
                || String.IsNullOrEmpty(TxtContraseña.Texts) || String.IsNullOrEmpty(TxtReContraseña.Texts))
            {
                MessageBox.Show("Hay campos vacios", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtContraseña.Texts.Equals(TxtReContraseña.Texts))
                {
                    if (ModeloUsuarios.existeUsuario(TxtUsuario.Texts))
                    {
                        MessageBox.Show("Ya existe ese usuario", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!ModeloUsuarios.emailRegex(TxtCorreo.Texts))
                    {
                        MessageBox.Show("Introduzca un correo electronico valido", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.setUsuario(TxtUsuario.Texts.ToLower());
                        usuario.setNombre(TxtNombre.Texts);
                        usuario.setApellido(TxtApellido.Texts);
                        usuario.setCorreo(TxtCorreo.Texts);
                        usuario.setPassword(ModeloUsuarios.generarSHA1(TxtContraseña.Texts));
                        usuario.setImagen(ModeloUsuarios.ImageByte(PcbFotoU.Image, formato));
                        do
                        {
                            usuario.setSesion(ModeloUsuarios.generarSHA1(FrmLogIn.generarCodSesion()));
                        } while (ModeloUsuarios.porSesion(usuario.getSesion()) == null);
                        try
                        {
                            ConexionUsuarios.crear(usuario);
                            MessageBox.Show("Usuario añadido\nBienvenido a Animoment", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ModeloUsuarios.enviarCorreo(TxtUsuario.Texts, TxtCorreo.Texts);
                            FrmLogIn log = new FrmLogIn();
                            this.Dispose();
                            log.Show();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RdbUrl_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUrl.Checked)
            {
                BtnArchivo.Enabled = false;
                BtnUrl.Enabled = true;
                TxtUrl.Enabled = true;
            }
            else
            {
                BtnArchivo.Enabled = true;
                BtnUrl.Enabled = false;
                TxtUrl.Enabled = false;
            }
        }
        private void PcbFotoU_Click(object sender, EventArgs e)
        {
            RdbArchivo.Visible = true;
            RdbUrl.Visible = true;
            TxtUrl.Visible = true;
            BtnArchivo.Visible = true;
            BtnUrl.Visible = true;
        }
        private void BtnUrl_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TxtUrl.Text.Equals(""))
                {
                    formato = obtenerFormato(TxtUrl.Text);
                    if (!formato.Equals("png") && !formato.Equals("jpg"))
                    {
                        MessageBox.Show("La imagen no tiene un formato correcto\nDebe ser PNG o JPG", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PcbFotoU.Load(TxtUrl.Text);
                        RdbArchivo.Visible = false;
                        RdbUrl.Visible = false;
                        TxtUrl.Visible = false;
                        BtnArchivo.Visible = false;
                        BtnUrl.Visible = false;
                    }
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Ese link no contiene ninguna imagen\nError: " + ex.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.ArgumentException ez)
            {
                MessageBox.Show("Esa imagen no es valida\nError: " + ez.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Net.WebException ec)
            {
                MessageBox.Show("No se puede abrir esa imagen\nError: " + ec.Message, "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            if (OfdFotos.ShowDialog() == DialogResult.OK)
            {
                Image imagen = Image.FromFile(OfdFotos.FileName);
                formato = obtenerFormato(OfdFotos.FileName);
                PcbFotoU.Image = imagen;
                RdbArchivo.Visible = false;
                RdbUrl.Visible = false;
                TxtUrl.Visible = false;
                BtnArchivo.Visible = false;
                BtnUrl.Visible = false;
            }
        }
        private String obtenerFormato(String foto)
        {
            return foto.Substring(foto.Length - 3, 3);
        }
        private void FrmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LblRegresar_Click(object sender, EventArgs e)
        {
            FrmLogIn inicio = new FrmLogIn();
            this.Dispose();
            inicio.Show();
        }
    }
}
