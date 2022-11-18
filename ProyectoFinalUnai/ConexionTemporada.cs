using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class ConexionTemporada
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
        public static void crear(Temporada temporada)
        {
            String sql = "INSERT INTO Temporada (Id, Nombre, Capitulos, Ruta, Op, Anime, Posicion) VALUES (@id, @nombre, @capitulos, @ruta, @op, @anime, @posicion)";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@id", temporada.getId());
            comadoSQL.Parameters.AddWithValue("@nombre", temporada.getNombre());
            comadoSQL.Parameters.AddWithValue("@capitulos", temporada.getCapitulos());
            comadoSQL.Parameters.AddWithValue("@ruta", temporada.getRuta());
            comadoSQL.Parameters.AddWithValue("@op", temporada.getOp());
            comadoSQL.Parameters.AddWithValue("@anime", temporada.getAnime());
            comadoSQL.Parameters.AddWithValue("@posicion", temporada.getPosicion());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void eliminar(Temporada temporada)
        {
            String sql = "DELETE FROM Temporada WHERE Id LIKE @id";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@id", temporada.getId());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void actualizar(Temporada temporada)
        {
            String sql = "UPDATE Temporada SET Nombre=@nombre, Capitulos=@capitulos, Ruta=@ruta, Op=@op, Anime=@anime, Posicion=@posicion WHERE Id=@id";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@nombre", temporada.getNombre());
            comadoSQL.Parameters.AddWithValue("@capitulos", temporada.getCapitulos());
            comadoSQL.Parameters.AddWithValue("@ruta", temporada.getRuta());
            comadoSQL.Parameters.AddWithValue("@op", temporada.getOp());
            comadoSQL.Parameters.AddWithValue("@anime", temporada.getAnime());
            comadoSQL.Parameters.AddWithValue("@posicion", temporada.getPosicion());
            comadoSQL.Parameters.AddWithValue("@id", temporada.getId());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static List<Temporada> buscar(String valor, String campo)
        {
            String sql = "SELECT * FROM Temporada WHERE " + campo + " like '%" + valor + "%'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Temporada> temporadas = new List<Temporada>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Temporada temporada = new Temporada();
                    temporada.setId(reader.GetString(0));
                    temporada.setNombre(reader.GetString(1));
                    temporada.setCapitulos(reader.GetInt32(2));
                    temporada.setRuta(reader.GetString(3));
                    temporada.setOp(reader.GetString(4));
                    temporada.setAnime(reader.GetString(5));
                    temporada.setPosicion(reader.GetInt32(6));
                    temporadas.Add(temporada);
                }
            }
            conexionBD.Close();
            return temporadas;
        }
        public static List<Temporada> listar()
        {
            String sql = "SELECT * FROM Temporada";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Temporada> temporadas = new List<Temporada>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Temporada temporada = new Temporada();
                    temporada.setId(reader.GetString(0));
                    temporada.setNombre(reader.GetString(1));
                    temporada.setCapitulos(reader.GetInt32(2));
                    temporada.setRuta(reader.GetString(3));
                    temporada.setOp(reader.GetString(4));
                    temporada.setAnime(reader.GetString(5));
                    temporada.setPosicion(reader.GetInt32(6));
                    temporadas.Add(temporada);
                }
            }
            conexionBD.Close();
            return temporadas;
        }
        public static List<Temporada> buscarOrdenado(String valor, String campo)
        {
            String sql = "SELECT * FROM Temporada WHERE " + campo + " like '%" + valor + "%' order by 7";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Temporada> temporadas = new List<Temporada>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Temporada temporada = new Temporada();
                    temporada.setId(reader.GetString(0));
                    temporada.setNombre(reader.GetString(1));
                    temporada.setCapitulos(reader.GetInt32(2));
                    temporada.setRuta(reader.GetString(3));
                    temporada.setOp(reader.GetString(4));
                    temporada.setAnime(reader.GetString(5));
                    temporada.setPosicion(reader.GetInt32(6));
                    temporadas.Add(temporada);
                }
            }
            conexionBD.Close();
            return temporadas;
        }
    }
}
