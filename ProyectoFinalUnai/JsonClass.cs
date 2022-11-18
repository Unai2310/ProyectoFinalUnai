using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class JsonClass
    {
        public int recordar;
        public String sesion;
		public JsonClass(int recordar, String sesion)
		{
			this.recordar = recordar;
			this.sesion = sesion;
		}
		public JsonClass()
        {

        }
		public int getRecordar()
		{
			return recordar;
		}
		public void setRecordar(int recordar)
		{
			this.recordar = recordar;
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
