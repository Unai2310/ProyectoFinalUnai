using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class ConexionPelicula
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

        public static void crear(Pelicula pelicula)
        {
            String sql = "INSERT INTO Pelicula (Id, Nombre, Duracion, Ruta, Anime, Posicion) VALUES (@id, @nombre, @duracion, @ruta, @anime, @posicion)";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@id", pelicula.getId());
            comadoSQL.Parameters.AddWithValue("@nombre", pelicula.getNombre());
            comadoSQL.Parameters.AddWithValue("@duracion", pelicula.getDuracion());
            comadoSQL.Parameters.AddWithValue("@ruta", pelicula.getRuta());
            comadoSQL.Parameters.AddWithValue("@anime", pelicula.getAnime());
            comadoSQL.Parameters.AddWithValue("@posicion",  pelicula.getPosicion());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void eliminar(Pelicula pelicula)
        {
            String sql = "DELETE FROM Pelicula WHERE Id LIKE @id";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@id", pelicula.getId());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void actualizar(Pelicula pelicula)
        {
            String sql = "UPDATE Pelicula SET Nombre=@nombre, Duracion=@duracion, Ruta=@ruta, Anime=@anime, Posicion=@posicion WHERE Id=@id";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@posicion", pelicula.getPosicion());
            comadoSQL.Parameters.AddWithValue("@id", pelicula.getId());
            comadoSQL.Parameters.AddWithValue("@nombre", pelicula.getNombre());
            comadoSQL.Parameters.AddWithValue("@duracion", pelicula.getDuracion());
            comadoSQL.Parameters.AddWithValue("@ruta", pelicula.getRuta());
            comadoSQL.Parameters.AddWithValue("@anime", pelicula.getAnime());
            comadoSQL.ExecuteNonQuery();      
            conexionBD.Close();
        }
        public static List<Pelicula> buscar(String valor, String campo)
        {
            String sql = "SELECT * FROM Pelicula WHERE " + campo + " like '%"+valor+"%'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Pelicula> peliculas = new List<Pelicula>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.setId(reader.GetString(0));
                    pelicula.setNombre(reader.GetString(1));
                    pelicula.setDuracion(reader.GetInt32(2));
                    pelicula.setRuta(reader.GetString(3));
                    pelicula.setAnime(reader.GetString(4));
                    pelicula.setPosicion(reader.GetInt32(5));
                    peliculas.Add(pelicula);
                }
            }
            conexionBD.Close();
            return peliculas;
        }
        public static List<Pelicula> listar()
        {
            String sql = "SELECT * FROM Pelicula";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Pelicula> peliculas = new List<Pelicula>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula pelicula = new Pelicula();
                    pelicula.setId(reader.GetString(0));
                    pelicula.setNombre(reader.GetString(1));
                    pelicula.setDuracion(reader.GetInt32(2));
                    pelicula.setRuta(reader.GetString(3));
                    pelicula.setAnime(reader.GetString(4));
                    pelicula.setPosicion(reader.GetInt32(5));
                    peliculas.Add(pelicula);
                }
            }
            conexionBD.Close();
            return peliculas;
        }
    }
}
