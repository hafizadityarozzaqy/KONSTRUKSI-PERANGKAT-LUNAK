using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Software_Construction_BEN_ID
{
    class Parameter
    {
        static string Uname;
        static string Email;
        static string Pass;
        static string NamaLengkap;
        public static string uname
        {
            get
            {
                return Uname;
            }
            set
            {
                Uname = value;
            }
        }
        public static string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public static string pass
        {
            get
            {
                return Pass;
            }
            set
            {
                Pass = value;
            }
        }
        public static string namalengkap
        {
            get
            {
                return NamaLengkap;
            }
            set
            {
                NamaLengkap = value;
            }
        }
    }
}
