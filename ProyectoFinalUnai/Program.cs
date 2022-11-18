using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUnai
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            JsonClass session = ModeloUsuarios.jsonReader();
            if (session.recordar == 0)
            {
                FrmLogIn inicio = new FrmLogIn();
                Sesion nueva = new Sesion();
                inicio.Show();
            }
            else
            {
                Usuarios usuario = ModeloUsuarios.porSesion(session.sesion);
                if (usuario.getSesion() != null)
                {
                    FrmPrincipal inicio = new FrmPrincipal();
                    Sesion.id = usuario.getId();
                    Sesion.usuario = usuario.getUsuario();
                    Sesion.nombre = usuario.getNombre();
                    Sesion.apellido = usuario.getApellido();
                    Sesion.correo = usuario.getCorreo();
                    Sesion.id_tipo = usuario.getId_tipo();
                    Sesion.imagen = usuario.getImagen();
                    Sesion.sesion = usuario.getSesion();
                    inicio.Show();
                }
                else
                {
                    FrmLogIn inicio = new FrmLogIn();
                    Sesion nueva = new Sesion();
                    inicio.Show();
                }
            }
            Application.Run();
            //Application.Run(new FrmReproductor("https://files.catbox.moe/c6702w.mp4"));
        }
    }
}
