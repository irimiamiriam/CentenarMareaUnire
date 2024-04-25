using CentenarMareaUnire.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CentenarMareaUnire.DataAccess
{
    internal class DatabaseHelper
    {
        private static readonly string _connectionstring = DataAccess.GetConnectionPath();
        private static readonly string _userspath = DataAccess.GetUsersPath();
        private static readonly string _lectiipath = DataAccess.GetLectiiPath();

        public static void Initialisation()
        {
            DeleteData();
            FillUsers();
            FillLectii();
        }

        private static void FillLectii()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Lectii (IdUtilizator, TitluLectie, Regiune, DataCreare, NumeImagine) values (@id, @titlu, @reg, @data,@nume)";
                using (StreamReader reader = new StreamReader(_lectiipath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split('*');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            if (split.Length == 5)
                            {
                                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(split[0]));
                                cmd.Parameters.AddWithValue("@titlu", split[1]);
                                cmd.Parameters.AddWithValue("@reg", split[2]);
                                DateTime data = DateTime.ParseExact(split[4], "M/d/yyyy h:mm:ss tt", null);
                                cmd.Parameters.AddWithValue("@data", data);
                                cmd.Parameters.AddWithValue("@nume", split[3]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(split[0]));
                                cmd.Parameters.AddWithValue("@titlu", split[1]);
                                cmd.Parameters.AddWithValue("@reg", split[1]);
                                DateTime data = DateTime.ParseExact(split[3], "M/d/yyyy h:mm:ss tt", null);
                                cmd.Parameters.AddWithValue("@data", data);
                                cmd.Parameters.AddWithValue("@nume", split[2]);
                            }
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private static void FillUsers()
        {
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Utilizatori (Nume,  Parola,Email) values (@nume, @parola, @email)";
                using(StreamReader reader = new StreamReader(_userspath)) {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split('*');
                        using(SqlCommand cmd = new SqlCommand(cmdText,con))
                        {
                            cmd.Parameters.AddWithValue("@nume", split[0]);
                            cmd.Parameters.AddWithValue("@parola", split[1]);
                            cmd.Parameters.AddWithValue("@email", split[2]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private static void DeleteData()
        {
            using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                SqlCommand cmdDel1 = new SqlCommand("Delete from Utilizatori", con);
                SqlCommand cmdDel2 = new SqlCommand("Delete from Lectii", con);
                SqlCommand cmdReseed1 = new SqlCommand("DBCC CHECKIDENT(Utilizatori, RESEED,0)", con);
                SqlCommand cmdReseed2 = new SqlCommand("DBCC CHECKIDENT(Lectii, RESEED,0)", con);
                cmdDel1.ExecuteNonQuery();
                cmdDel2.ExecuteNonQuery();
                cmdReseed1.ExecuteNonQuery();
                cmdReseed2.ExecuteNonQuery();
            }
        }

        internal static UserModel FindUser(UserModel user)
        { UserModel userGasit = new UserModel();
            using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where Email= @email and Parola=@parola ";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@parola", user.Parola);
                    using (SqlDataReader reader= cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            userGasit.Id = Convert.ToInt32(reader[0]);
                            userGasit.Email = user.Email;
                            userGasit.Parola= user.Parola;
                            userGasit.Nume = reader[1].ToString();
                        }
                    }

                }
            }
            return userGasit;
        }

        internal static UserModel FindUserByEmail(string email)
        {
            UserModel userGasit = new UserModel();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where Email= @email ";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            userGasit.Id = Convert.ToInt32(reader[0]);
                            userGasit.Email = reader[3].ToString();
                            userGasit.Parola = reader[2].ToString();
                            userGasit.Nume = reader[1].ToString();
                        }
                    }

                }
            }
            return userGasit;
        }

        internal static void UpdateParola(UserModel userEmail)
        {
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Update Utilizatori set Parola=@parola where IdUtilizator=@id";
                using(SqlCommand cmd= new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@parola", userEmail.Parola);
                    cmd.Parameters.AddWithValue("@id", userEmail.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal static List<LectieModel> GetLectii()
        {
            List<LectieModel> lectii = new List<LectieModel>();
            using(SqlConnection con= new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Lectii";
                using(SqlCommand cmd =  new SqlCommand(cmdText, con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LectieModel lectie = new LectieModel();
                            lectie.Id = Convert.ToInt32(reader[0]);
                            lectie.IdUtilizator = Convert.ToInt32(reader[1]);
                            lectie.Titlu= reader[2].ToString();
                            lectie.Regiune= reader[3].ToString();
                            lectie.Data = DateTime.Parse(reader[4].ToString());
                            lectie.File= reader[5].ToString();
                            lectii.Add(lectie);
                        }
                    }
                }
            }
            return lectii;
        }

        internal static UserModel FindUserById(int idUtilizator)
        {
            UserModel userGasit = new UserModel();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where IdUtilizator= @id";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@id", idUtilizator);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            userGasit.Id = Convert.ToInt32(reader[0]);
                            userGasit.Email = reader[3].ToString();
                            userGasit.Parola = reader[2].ToString();
                            userGasit.Nume = reader[1].ToString();
                        }
                    }

                }
            }
            return userGasit;
        }
    }
}
