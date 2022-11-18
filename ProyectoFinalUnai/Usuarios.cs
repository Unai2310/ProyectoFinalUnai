using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    public class Usuarios
    {
        private int id;
        private String usuario;
        private String password;
        private String nombre;
        private String apellido;
        private String correo;
        private int id_tipo;
		private byte[] imagen;
		private String sesion;

		public Usuarios(int id, String usuario, String password, String nombre, String apellido, String correo, int id_tipo, byte[] imagen)
		{
			this.id = id;
			this.usuario = usuario;
			this.password = password;
			this.nombre = nombre;
			this.apellido = apellido;
			this.correo = correo;
			this.id_tipo = id_tipo;
			this.imagen = imagen;
		}
		public Usuarios()
        {

        }
		public int getId()
		{
			return id;
		}
		public void setId(int id)
		{
			this.id = id;
		}
		public String getUsuario()
		{
				return usuario;
		}
		public void setUsuario(String usuario)
		{
			this.usuario = usuario;
		}
		public String getPassword()
		{
			return password;
		}
		public void setPassword(String password)
		{
			this.password = password;
		}
		public String getNombre()
		{
			return nombre;
		}
		public void setNombre(String nombre)
		{
			this.nombre = nombre;
		}
		public String getApellido()
		{
			return apellido;
		}
		public void setApellido(String apellido)
		{
			this.apellido = apellido;
		}
		public String getCorreo()
		{
			return correo;
		}
		public void setCorreo(String correo)
		{
			this.correo = correo;
		}
		public int getId_tipo()
		{
			return id_tipo;
		}
		public void setId_tipo(int id_tipo)
		{
			this.id_tipo = id_tipo;
		}
		public byte[] getImagen()
		{
			return imagen;
		}
		public void setImagen(byte[] imagen)
		{
			this.imagen = imagen;
		}
		public String getSesion()
		{
			return sesion;
		}
		public void setSesion(String sesion)
		{
			this.sesion = sesion;
		}
	}
}
