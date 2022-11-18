using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class ConexionAnime
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

        public static void crear(Anime anime)
        {
            String sql = "INSERT INTO Anime (Nombre, Genero, Ruta, Imagen, Temporadas, Capitulos) VALUES (@nombre, @genero, @ruta, @imagen, @temporadas, @capitulos)";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@nombre", anime.getNombre());
            comadoSQL.Parameters.AddWithValue("@genero", anime.getGenero());
            comadoSQL.Parameters.AddWithValue("@ruta", anime.getRuta());
            comadoSQL.Parameters.AddWithValue("@imagen", anime.getImagen());
            comadoSQL.Parameters.AddWithValue("@temporadas", anime.getTemporadas());
            comadoSQL.Parameters.AddWithValue("@capitulos", anime.getCapitulos());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void eliminar(Anime anime)
        {
            String sql = "DELETE FROM Anime WHERE Nombre LIKE @nombre";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@nombre", anime.getNombre());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void actualizar(Anime anime)
        {
            String sql = "UPDATE Anime SET Genero=@genero, Ruta=@ruta, Imagen=@imagen, Temporadas=@temporadas, Capitulos=@capitulos WHERE Nombre=@nombre";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@genero", anime.getGenero());
            comadoSQL.Parameters.AddWithValue("@ruta", anime.getRuta());
            comadoSQL.Parameters.AddWithValue("@imagen", anime.getImagen());
            comadoSQL.Parameters.AddWithValue("@temporadas", anime.getTemporadas());
            comadoSQL.Parameters.AddWithValue("@capitulos", anime.getCapitulos());
            comadoSQL.Parameters.AddWithValue("@nombre", anime.getNombre());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static List<Anime> buscar(String valor, String campo)
        {
            String sql = "SELECT * FROM Anime WHERE " + campo + " like '%"+valor+"%'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Anime> animes = new List<Anime>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Anime anime = new Anime();
                    anime.setNombre(reader.GetString(0));
                    anime.setGenero(reader.GetString(1));
                    anime.setRuta(reader.GetString(2));
                    anime.setImagen(reader.GetString(3));
                    anime.setTemporadas(reader.GetInt32(4));
                    anime.setCapitulos(reader.GetInt32(5));
                    animes.Add(anime);
                }
            }
            conexionBD.Close();
            return animes;
        }
        public static List<Anime> listar()
        {
            String sql = "SELECT * FROM Anime";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Anime> animes = new List<Anime>(); 
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Anime anime = new Anime();
                    anime.setNombre(reader.GetString(0));
                    anime.setGenero(reader.GetString(1));
                    anime.setRuta(reader.GetString(2));
                    anime.setImagen(reader.GetString(3));
                    anime.setTemporadas(reader.GetInt32(4));
                    anime.setCapitulos(reader.GetInt32(5));
                    animes.Add(anime);
                }
            }
            conexionBD.Close();
            return animes;
        }
        public static DataTable buscarDinamico()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM Anime", conexion());
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            return datos;
        }
    }
}
