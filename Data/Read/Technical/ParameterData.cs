using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Archetypes;

namespace Data.Read.Technical
{
    public class ParameterData
    {
        public List<ParamsDescription> getAll()
        {
            var result = new List<ParamsDescription>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Configuration.AxConnectionString))
                {
                    conn.Open();
                    var query = getAllSql;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var readParam = new ParamsDescription()
                                {
                                    Id = reader["id"].ToString(),
                                    Name = reader["name"].ToString(),
                                    Value = reader["description"].ToString()
                                };
                                result.Add(readParam);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return result;
        }

        private string getAllSql = $@"SELECT * FROM {Configuration.ParamsDescriptionDefaultTable}";
    }
}
