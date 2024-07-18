using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operator_Overlloding
{
    internal class UserViewModel
    {

        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public static explicit operator UserViewModel(User user)
        {
            string[]? names = user.FullName?.Split(" ");
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                Fname = names?.Length > 0 ? names[0] : string.Empty,
                Lname = names?.Length > 0 ? names[1] : string.Empty,

                Email = user?.Email ?? string.Empty,
                Password = user?.Password ?? string.Empty
            };
        }
    }
}
