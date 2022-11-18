using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class Lista
    {
		public int id;
		public int usuario;
		public String anime;
		public String nota;
		public String fecha;

		public Lista(int id, int usuario, String anime, String nota, String fecha)
		{
			this.id = id;
			this.usuario = usuario;
			this.anime = anime;
			this.nota = nota;
			this.fecha = fecha;
		}
		public Lista()
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
		public int getUsuario()
		{
			return usuario;
		}
		public void setUsuario(int usuario)
		{
			this.usuario = usuario;
		}
		public String getAnime()
		{
			return anime;
		}
		public void setAnime(String anime)
		{
			this.anime = anime;
		}
		public String getNota()
		{
			return nota;
		}
		public void setNota(String nota)
		{
			this.nota = nota;
		}
		public String getFecha()
		{
			return fecha;
		}
		public void setFecha(String fecha)
		{
			this.fecha = fecha;
		}
	}
}
