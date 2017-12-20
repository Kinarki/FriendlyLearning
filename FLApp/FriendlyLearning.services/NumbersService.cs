using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyLearning.services
{
    public class NumbersService : BaseService
    {
        static public List<NumbersModel> SelectAll()
        {
            List<NumbersModel> numList = new List<NumbersModel>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.Numbers_SelectAll", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        NumbersModel model = new NumbersModel();
                        int index = 0;

                        model.NumId = reader.GetInt32(index++);
                        model.Number = reader.GetInt32(index++);
                        numList.Add(model);
                    }
                }
                conn.Close();
            }
            return numList;
        }
    }
}
