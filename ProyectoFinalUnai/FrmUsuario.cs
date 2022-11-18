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
    public partial class FrmUsuario : Form
    {
        FrmPrincipal prin = null;
        public FrmUsuario(FrmPrincipal principal)
        {
            InitializeComponent();
            prin = principal;
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            PcbUsuario.Image = Image.FromStream(ModeloUsuarios.ByteImage(Sesion.imagen));
            PcbImagen.Load("https://catbox.moe/pictures/qts/1428254016467.png");
            LblNombreV.Text = Sesion.nombre;
            LblUsuarioV.Text = Sesion.usuario;
            LblApellidoV.Text = Sesion.apellido;
            LblCorreoV.Text = Sesion.correo;
        }
        private void PcbCerrar_Click(object sender, EventArgs e)
        {
            ModeloUsuarios.jsonWriter(0, "null");
            ConexionUsuarios.crearSesion(Sesion.usuario, ModeloUsuarios.generarSHA1(FrmLogIn.generarCodSesion()));
            FrmLogIn inicio = new FrmLogIn();
            Sesion nueva = new Sesion();
            this.Dispose();
            prin.Dispose();
            inicio.Show();
        }
        private void PcbBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea Borrar el Usuario " + LblUsuarioV.Text + "?",
               "Boorar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Usuarios usuario = new Usuarios();
                usuario.setUsuario(Sesion.usuario);
                ConexionUsuarios.eliminar(usuario);
                ModeloUsuarios.jsonWriter(0, "null");
                MessageBox.Show("Usuario Borrado\nLamentamos su marcha", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogIn inicio = new FrmLogIn();
                Sesion nueva = new Sesion();
                this.Dispose();
                prin.Dispose();
                inicio.Show();
            }
        }
        private void LblCambiar_Click(object sender, EventArgs e)
        {
            TxtCorreo.Text = LblCorreoV.Text;
            TxtCorreo.Visible = true;
            LblCorreoV.Visible = false;
        }
        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ModeloUsuarios.emailRegex(TxtCorreo.Text))
                {
                    Usuarios usuario = ModeloUsuarios.porUsuario(LblUsuarioV.Text);
                    usuario.setCorreo(TxtCorreo.Text);
                    ConexionUsuarios.actualizar(usuario);
                    ModeloUsuarios.enviarCorreo(usuario.getUsuario(), usuario.getCorreo());
                    Sesion.correo = TxtCorreo.Text;
                    LblCorreoV.Text = TxtCorreo.Text;
                    TxtCorreo.Visible = false;
                    LblCorreoV.Visible = true;
                }
                else
                {
                    TxtCorreo.Text = "";
                    TxtCorreo.Visible = false;
                    LblCorreoV.Visible = true;
                    MessageBox.Show("Introduzca un correo electronico valido", "AnimeDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FrmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
