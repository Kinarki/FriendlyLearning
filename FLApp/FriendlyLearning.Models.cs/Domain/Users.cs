using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyLearning.Models.cs.Domain
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string FavoriteColor { get; set; }
        public int AccountId { get; set; }
    }
}
