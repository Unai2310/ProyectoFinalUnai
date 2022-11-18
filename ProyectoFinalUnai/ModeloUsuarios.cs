using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using Newtonsoft.Json;
using System.Net.Mail;

namespace ProyectoFinalUnai
{
    class ModeloUsuarios
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
        public static Boolean existeUsuario(String usuario)
        {
            String sql = "SELECT Id FROM Usuarios WHERE usuario LIKE '" + usuario + "'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            if (reader.HasRows)
            {
                conexionBD.Close();
                return true;
            }
            else
            {
                conexionBD.Close();
                return false;
            }
        }
        public static Usuarios porUsuario(String usuario)
        {
            String sql = "SELECT *  FROM Usuarios WHERE usuario LIKE '" + usuario + "'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            Usuarios usr = new Usuarios();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usr.setId(reader.GetInt32(0));
                    usr.setUsuario(reader.GetString(1));
                    usr.setPassword(reader.GetString(2));
                    usr.setNombre(reader.GetString(3));
                    usr.setApellido(reader.GetString(4));
                    usr.setCorreo(reader.GetString(5));
                    usr.setId_tipo(reader.GetInt32(6));
                    byte[] imagen = null;
                    imagen = (byte[])reader.GetValue(7);
                    usr.setImagen(imagen);
                }
            }
            conexionBD.Close();
            return usr;
        }
        public static Usuarios porSesion(String sesion)
        {
            String sql = "SELECT *  FROM Usuarios WHERE Sesion LIKE '" + sesion + "'";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = conexion();
            conexionBD.Open();
            MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
            reader = comadoSQL.ExecuteReader();
            Usuarios usr = new Usuarios();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usr.setId(reader.GetInt32(0));
                    usr.setUsuario(reader.GetString(1));
                    usr.setPassword(reader.GetString(2));
                    usr.setNombre(reader.GetString(3));
                    usr.setApellido(reader.GetString(4));
                    usr.setCorreo(reader.GetString(5));
                    usr.setId_tipo(reader.GetInt32(6));
                    byte[] imagen = null;
                    imagen = (byte[])reader.GetValue(7);
                    usr.setSesion(reader.GetString(8));
                    usr.setImagen(imagen);
                }
            }
            conexionBD.Close();
            return usr;
        }
        public static String generarSHA1(String cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i<result.Length; i++)
            {
                if (result[i] < 16) { }
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
        public static MemoryStream ByteImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            return ms;
        }
        public static byte[] ImageByte(Image imagen, String formato)
        {
            MemoryStream ms = new MemoryStream();
            if (formato.Equals("png"))
            {
                imagen.Save(ms, ImageFormat.Png);
            }
            else
            {
                imagen.Save(ms, ImageFormat.Jpeg);
            }
            ms.Close();
            return ms.ToArray();
        }
        public static byte[] ImageByte(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, ImageFormat.Png);
            ms.Close();
            return ms.ToArray();
        }
        public static Boolean emailRegex(String email)
        {
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3}))$");
        }
        public static void jsonWriter(int recordar, String sesion)
        {
            JsonClass jsonc = new JsonClass();
            jsonc.setRecordar(recordar);
            jsonc.setSesion(sesion);
            String json = JsonConvert.SerializeObject(jsonc);
            System.IO.File.WriteAllText("../../resources/Sesion.json", json);
        }
        public static JsonClass jsonReader()
        {
            StreamReader r = new StreamReader("../../resources/Sesion.json");
            String jsonString = r.ReadToEnd();
            r.Close();
           JsonClass session = JsonConvert.DeserializeObject<JsonClass>(jsonString);
            return session;
        }
        public static void enviarCorreo(String usuario, String mail)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("animoment1751@gmail.com", "Equipo de Animoment");
            correo.To.Add(mail);
            correo.Subject = "Creacion de cuenta";
            string body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:darkorange;}
                            </style>
                            <h1>Cuenta con el nombre de usuario " + usuario + " ha sido creada</h1></br><h2>Este es un mensaje de prueba para confirmar el correo</h2><img src = https://files.catbox.moe/tin50m.png>";
            correo.Body = body;
            correo.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("animoment1751@gmail.com", "dtobzuxedicgvgzq");
            smtp.EnableSsl = true;
            smtp.Send(correo);
        }
    }
}
