using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUnai
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            PcbFotoD.Load("https://catbox.moe/pictures/qts/1448242666775.png");
        }
        private void PcbLogIn_Click(object sender, EventArgs e)
        {
            Usuarios usuario = null;
            if (String.IsNullOrEmpty(TxtPassword.Texts) || String.IsNullOrEmpty(TxtUsuario.Texts))
            {
                MessageBox.Show("Hay campos vacios", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usuario = ModeloUsuarios.porUsuario(TxtUsuario.Texts.ToLower());
                if (usuario == null)
                {
                    MessageBox.Show("El usuario no existe\nO\nEsta mal escrito", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (usuario.getPassword() != ModeloUsuarios.generarSHA1(TxtPassword.Texts))
                    {
                        MessageBox.Show("El usuario y/o la contraseña no coinciden", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Sesion.id = usuario.getId();
                        Sesion.usuario = usuario.getUsuario();
                        Sesion.nombre = usuario.getNombre();
                        Sesion.apellido = usuario.getApellido();
                        Sesion.correo = usuario.getCorreo();
                        Sesion.id_tipo = usuario.getId_tipo();
                        Sesion.imagen = usuario.getImagen();
                        Sesion.sesion = usuario.getSesion();
                        if (ChbRecordar.Checked)
                        {
                            String sesion = ModeloUsuarios.generarSHA1(generarCodSesion());
                            ModeloUsuarios.jsonWriter(1, sesion);
                            ConexionUsuarios.crearSesion(usuario.getUsuario(), sesion);
                        }
                        else
                        {
                            ModeloUsuarios.jsonWriter(0, "null");
                        }
                        this.Dispose();
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();
                    }
                }
            }
        }
        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LblReg2_MouseEnter(object sender, EventArgs e)
        {
            LblReg2.ForeColor = Color.DarkBlue;
        }
        private void LblReg2_MouseLeave(object sender, EventArgs e)
        {
            LblReg2.ForeColor = Color.Blue;
        }
        private void LblReg2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
        }
        public static String generarCodSesion()
        {
            StringBuilder sb = new StringBuilder();
            String caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random ran = new Random();
            for (int i = 0; i<16; i++)
            {
                sb.Append(caracteres.ElementAt(ran.Next(caracteres.Length)));
            }
            return sb.ToString();
        }
    }
}
