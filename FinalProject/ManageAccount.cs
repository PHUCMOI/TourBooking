using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class ManageAccount
    {
        public static class Account
        {
            private static List<string> Hoten = new List<string>();
            private static List<string> SĐT = new List<string>();
            private static List<string> Email = new List<string>();
            private static List<string> Password = new List<string>();


            public static List<string> GlobalHoten
            {
                get
                {
                    return Hoten;
                }
                set
                {
                    Hoten.Add(value.ToString());
                }
            }

            public static List<string> GlobalSĐT
            {
                get
                {
                    return SĐT;
                }
                set
                {
                    SĐT.Add(value.ToString());
                }
            }

            public static List<string> GlobalEmail
            {
                get
                {
                    return Email;
                }
                set
                {
                    Email.Add(value.ToString());
                }
            }
            public static List<string> GlobalPassword
            {
                get
                {
                    return Password;
                }
                set
                {
                    Password.Add(value.ToString());
                }
            }
        }
    }
}
