using FriendlyLearning.Models.cs.Domain;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System;
using FriendlyLearning.Services.Interfaces;
using System.Data;
using FriendlyLearning.Models.cs.ViewModels;

namespace FriendlyLearning.Services
{
    public class UsersService : BaseService, IUsersService
    {
        public int Insert(NewUser model)
        {
            int id = 0;
            string salt;
            string hashedPassword;
            string password = model.Password;

            CryptographyService svc = new CryptographyService();
            salt = svc.GenerateRandomString(16);
            hashedPassword = svc.Hash(password, salt);
            model.HashedPassword = hashedPassword;
            model.Salt = salt;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.Users_InsertNew", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@HashedPassword", model.HashedPassword);
                    cmd.Parameters.AddWithValue("@Salt", model.Salt);

                    SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                    id = (int)cmd.Parameters["@Id"].Value;
                }
                conn.Close();
            }
            return id;
        }

        public Users SelectById(int id)
        {
            Users model = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.Users_SelectAll", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        model = Mapper(reader);
                    }
                }
                conn.Close();
            }
            return model;
        }

        public List<Users> SelectAll()
        {
            List<Users> userList = new List<Users>();

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

        public void Update(Users model)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Users_Update", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameterCollection paramCol = cmd.Parameters;
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@UserId";
                    param.SqlDbType = System.Data.SqlDbType.Int;
                    param.Direction = System.Data.ParameterDirection.Output;
                    paramCol.Add(param);

                    paramCol.AddWithValue("@FirstName", model.FirstName);
                    paramCol.AddWithValue("@LastName", model.LastName);
                    paramCol.AddWithValue("@Gender", model.Gender);
                    paramCol.AddWithValue("@Age", model.Age);
                    paramCol.AddWithValue("@FavoriteColor", model.FavoriteColor);
                    paramCol.AddWithValue("@AccountId", model.AccountId);
                }
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.Users_Delete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                conn.Close();
            }
        }

        private Users Mapper(SqlDataReader reader)
        {
            Users model = new Users();
            int index = 0;

            model.UserId = reader.GetInt32(index++);


            return model;
        }
    }
}
