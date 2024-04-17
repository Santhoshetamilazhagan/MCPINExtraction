using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPINExtraction
{
    class UserLogName
    {
        static string username;
        public static string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
    }
}
