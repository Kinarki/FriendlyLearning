using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Services;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace FriendlyLearning.services
{
    public class LettersService : BaseService
    {
        static public List<Letters> SelectAll()
        {
            List<Letters> letterList = new List<Letters>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.CapitalCharacters_SelectAll", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Letters model = new Letters();
                        int index = 0;

                        model.CharId = reader.GetInt32(index++);
                        model.Character = reader.GetString(index++);
                        letterList.Add(model);
                    }
                }
                conn.Close();
            }
            return letterList;
        }
    }
}
