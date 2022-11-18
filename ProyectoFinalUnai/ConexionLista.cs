using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class ConexionLista
    {
        private static MySqlConnection conexion()
        {
            String cadenaConexion = "server=flo.no-ip.info; port=3306; user=admin; password=Lamochila; database=AnimeDB";
            try
            {
                MySqlConnection connection = new MySqlConnection(cadenaConexion);
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void crear(Lista lista)
        {
            String sql = "INSERT INTO lista (Usuario, Anime, Nota, FecComp) VALUES ( @usuario, @anime, @nota, @fecha)";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@usuario", lista.getUsuario());
            comadoSQL.Parameters.AddWithValue("@anime", lista.getAnime());
            comadoSQL.Parameters.AddWithValue("@nota", lista.getNota());
            comadoSQL.Parameters.AddWithValue("@fecha", lista.getFecha());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void eliminar(Lista lista)
        {
            String sql = "DELETE FROM lista WHERE id=@id";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@id", lista.getId());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void actualizar(Lista lista)
        {
            String sql = "UPDATE lista SET Usuario=@usuario, Anime=@anime, Nota=@nota, FecComp=@fecha WHERE Id=@id";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@usuario", lista.getUsuario());
            comadoSQL.Parameters.AddWithValue("@anime", lista.getAnime());
            comadoSQL.Parameters.AddWithValue("@nota", lista.getNota());
            comadoSQL.Parameters.AddWithValue("@fecha", lista.getFecha());
            comadoSQL.Parameters.AddWithValue("@id", lista.getId());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static List<Lista> buscar(String valor, String campo)
        {
            String sql = "SELECT * FROM lista WHERE " + campo + " like '" + valor + "'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Lista> listas = new List<Lista>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Lista lista = new Lista();
                    lista.setId(reader.GetInt32(0));
                    lista.setUsuario(reader.GetInt32(1));
                    lista.setAnime(reader.GetString(2));
                    lista.setNota(reader.GetString(3));
                    lista.setFecha(reader.GetString(4));
                    listas.Add(lista);
                }
            }
            conexionBD.Close();
            return listas;
        }
        public static List<Lista> listar()
        {
            String sql = "SELECT * FROM lista";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Lista> listas = new List<Lista>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Lista lista = new Lista();
                    lista.setId(reader.GetInt32(0));
                    lista.setUsuario(reader.GetInt32(1));
                    lista.setAnime(reader.GetString(2));
                    lista.setNota(reader.GetString(3));
                    lista.setFecha(reader.GetString(4));
                    listas.Add(lista);
                }
            }
            conexionBD.Close();
            return listas;
        }
        public static Lista buscarEntrada(int usuario, String anime)
        {
            String sql = "SELECT * FROM lista WHERE Usuario = '" + usuario + "' AND Anime like '" + anime + "'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            Lista lista = new Lista();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.setId(reader.GetInt32(0));
                    lista.setUsuario(reader.GetInt32(1));
                    lista.setAnime(reader.GetString(2));
                    lista.setNota(reader.GetString(3));
                    lista.setFecha(reader.GetString(4));
                    return lista;
                }
            }
            return null;
        }
        public static DataTable buscarDinamico(int id)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM lista WHERE Usuario like '%" + id + "%'", conexion());
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            return datos;
        }
    }
}
