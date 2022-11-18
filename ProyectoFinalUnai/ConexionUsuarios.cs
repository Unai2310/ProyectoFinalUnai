using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUnai
{
    class ConexionUsuarios
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
        public static void crear(Usuarios usuario)
        {
            String sql = "INSERT INTO Usuarios (Usuario, Password, Nombre, Apellido, Correo, Id_tipo, Imagen, Sesion) VALUES (@usuario, @password, @nombre, @apellido, @correo, 2, ?rawData, @sesion)";
            MySqlParameter imagen = new MySqlParameter("?rawData", MySqlDbType.Blob, usuario.getImagen().Length);
            imagen.Value = usuario.getImagen();
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@usuario", usuario.getUsuario());
            comadoSQL.Parameters.AddWithValue("@password", usuario.getPassword());
            comadoSQL.Parameters.AddWithValue("@nombre", usuario.getNombre());
            comadoSQL.Parameters.AddWithValue("@apellido", usuario.getApellido());
            comadoSQL.Parameters.AddWithValue("@correo", usuario.getCorreo());
            comadoSQL.Parameters.Add(imagen);
            comadoSQL.Parameters.AddWithValue("@sesion", ModeloUsuarios.generarSHA1(FrmLogIn.generarCodSesion()));
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void crearAdmin(Usuarios usuario)
        {
            String sql = "INSERT INTO Usuarios (Usuario, Password, Nombre, Apellido, Correo, Id_tipo, Imagen) VALUES (@usuario, @password, @nombre, @apellido, @correo, @id_tipo, ?rawData)";
            MySqlParameter imagen = new MySqlParameter("?rawData", MySqlDbType.Blob, usuario.getImagen().Length);
            imagen.Value = usuario.getImagen();
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@usuario", usuario.getUsuario());
            comadoSQL.Parameters.AddWithValue("@password", usuario.getPassword());
            comadoSQL.Parameters.AddWithValue("@nombre", usuario.getNombre());
            comadoSQL.Parameters.AddWithValue("@apellido", usuario.getApellido());
            comadoSQL.Parameters.AddWithValue("@correo", usuario.getCorreo());
            comadoSQL.Parameters.AddWithValue("@id_tipo", usuario.getId_tipo());
            comadoSQL.Parameters.Add(imagen);
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void eliminar(Usuarios usuario)
        {
            String sql = "DELETE FROM Usuarios WHERE Usuario LIKE @usuario";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@usuario", usuario.getUsuario());
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static void actualizar(Usuarios usuario)
        {
            String sql = "UPDATE Usuarios SET Usuario=@usuario, Password=@password, Nombre=@nombre, Apellido=@apellido, Correo=@correo, Id_Tipo=@idTipo, Imagen=?rawData WHERE Id=@id";
            MySqlParameter imagen = new MySqlParameter("?rawData", MySqlDbType.Blob, usuario.getImagen().Length);
            imagen.Value = usuario.getImagen();

            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@usuario", usuario.getUsuario());
            comadoSQL.Parameters.AddWithValue("@password", usuario.getPassword());
            comadoSQL.Parameters.AddWithValue("@nombre", usuario.getNombre());
            comadoSQL.Parameters.AddWithValue("@apellido", usuario.getApellido());
            comadoSQL.Parameters.AddWithValue("@correo", usuario.getCorreo());
            comadoSQL.Parameters.AddWithValue("@idTipo", usuario.getId_tipo());
            comadoSQL.Parameters.AddWithValue("@id", usuario.getId());
            comadoSQL.Parameters.Add(imagen);
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
        public static List<Usuarios> buscar(String id, String campo)
        {
            String sql = "SELECT * FROM Usuarios WHERE " + campo + " like '%"+id+"%'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Usuarios> usuarios = new List<Usuarios>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.setId(reader.GetInt32(0));
                    usuario.setUsuario(reader.GetString(1));
                    usuario.setPassword(reader.GetString(2));
                    usuario.setNombre(reader.GetString(3));
                    usuario.setApellido(reader.GetString(4));
                    usuario.setCorreo(reader.GetString(5));
                    usuario.setId_tipo(reader.GetInt32(6));
                    byte[] imagen = null;
                    imagen = (byte[])reader.GetValue(7);
                    usuario.setImagen(imagen);
                    usuario.setSesion(reader.GetString(8));
                    usuarios.Add(usuario);
                }
            }
            conexionBD.Close();
            return usuarios;
        }
        public static List<Usuarios> listar()
        {
            String sql = "SELECT * FROM Usuarios";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            List<Usuarios> usuarios = new List<Usuarios>();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.setId(reader.GetInt32(0));
                    usuario.setUsuario(reader.GetString(1));
                    usuario.setPassword(reader.GetString(2));
                    usuario.setNombre(reader.GetString(3));
                    usuario.setApellido(reader.GetString(4));
                    usuario.setCorreo(reader.GetString(5));
                    usuario.setId_tipo(reader.GetInt32(6));
                    byte[] imagen = null;
                    imagen = (byte[])reader.GetValue(7);
                    usuario.setImagen(imagen);
                    //usuario.setSesion(reader.GetString(8));
                    usuarios.Add(usuario);
                }
            }
            conexionBD.Close();
            return usuarios;
        }
        public static DataTable buscarDinamico()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM Usuarios", conexion());
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            return datos;
        }
        public static void crearSesion(String usuario, String sesion)
        {
            String sql = "UPDATE Usuarios SET Sesion=@sesion WHERE Usuario like @usuario";
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            comadoSQL.Parameters.AddWithValue("@sesion", sesion);
            comadoSQL.Parameters.AddWithValue("@usuario", usuario);
            comadoSQL.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
