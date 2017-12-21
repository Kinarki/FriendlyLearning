using System.Collections.Generic;
using FriendlyLearning.Models.cs.Domain;
using System.Data.SqlClient;
using FriendlyLearning.Models.cs.ViewModels;

namespace FriendlyLearning.Services.Interfaces
{
    public interface IUsersService
    {
        Users SelectById(int id);
        List<Users> SelectAll();
        int Insert(NewUser model);
        void Update(Users model);
        void Delete(int id);
    }
}