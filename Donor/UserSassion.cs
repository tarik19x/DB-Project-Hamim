using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Donor
{
    internal static class UserSassion
    {
        public static int Id { get; set; }

        public static string Username { get; set; }

        public static string BloodGroup { get; set; }
    }


}