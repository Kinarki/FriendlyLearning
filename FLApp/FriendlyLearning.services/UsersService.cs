using FriendlyLearning.Models.cs.Domain;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System;

namespace FriendlyLearning.services
{
    public class UsersService
    {
        public List<Users> SelectAll()
        {
            List<Users> userList = new List<Users>();

            //string sqlConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.Users_SelectAll", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Users model = Mapper(reader);
                        userList.Add(model);
                    }
                }
                conn.Close();
            }
            return userList;
        }

        private Users Mapper(SqlDataReader reader)
        {
            Users model = new Users();
            int index = 0;

            model.UserId = reader.GetInt32(index++);
            model.FirstName = reader.GetString(index++);
            model.LastName = reader.GetString(index++);
            if (!reader.IsDBNull(index))
            {
                model.Gender = reader.GetString(index++);
            }
            else
            {
                index++;
            }
            if (!reader.IsDBNull(index))
            {
                model.Age = reader.GetInt32(index++);
            }
            else
            {
                index++;
            }
            if (!reader.IsDBNull(index))
            {
                model.FavoriteColor = reader.GetString(index++);
            }
            else
            {
                index++;
            }
            model.AccountId = reader.GetInt32(index++);

            return model;
        }
    }
}
