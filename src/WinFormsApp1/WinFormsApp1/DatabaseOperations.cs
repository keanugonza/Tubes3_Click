using System;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class DatabaseOperations
    {
        private const string ConnectionString = "server=localhost;user=root;database=t;port=3306;password=your password";

        public string GetNamaSidikJari(string berkas_citra)
        {
            string nama = null;

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT nama FROM sidik_jari  WHERE berkas_citra = @berkas_citra";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@berkas_citra", berkas_citra);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nama = $"{reader["nama"]}";
                        }
                    }
                }
            }

            return nama;
        }

        public List<string> GetBiodataEntries_NamaOnly()
        {
            var namaBiodataList = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string querybiodata = "SELECT nama FROM biodata";
                using (MySqlCommand cmdbiodata = new MySqlCommand(querybiodata, conn))
                using (MySqlDataReader reader = cmdbiodata.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namaBiodataList.Add(reader["nama"].ToString());
                    }
                }
                conn.Close();
            }

            return namaBiodataList;
        }

        public  Dictionary<string, string> GetBiodata(string nama)
        {
            var biodata = new Dictionary<string, string>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string queryBiodata = "SELECT * FROM biodata WHERE nama = @nama";
                using (MySqlCommand cmdBiodata = new MySqlCommand(queryBiodata, conn))
                {
                    cmdBiodata.Parameters.AddWithValue("@nama", nama);
                    using (MySqlDataReader reader = cmdBiodata.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                biodata[reader.GetName(i)] = reader[i].ToString();
                            }
                        }
                    }
                }
                conn.Close();
            }

            return biodata;
        }
    }
}
