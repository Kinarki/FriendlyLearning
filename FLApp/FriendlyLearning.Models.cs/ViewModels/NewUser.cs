using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyLearning.Models.cs.ViewModels
{
    public class NewUser
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
    }
}
