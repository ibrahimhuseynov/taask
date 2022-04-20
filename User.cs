using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        private string _password;
        private string _username;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if(value.Length > 6)
                {
                    _username= value;   
                }
            }
        } 
        public string Password
        {
            get { return _password; }
            set
            {
                if (value==CheckPassword(value))
                {
                     _password= value;
                }
            }
        }
        public string CheckPassword(string txt)
        {
            for(int i = 0; i < txt.Length; i++)
            {
                if (char.IsDigit(txt[i]))
                {
                    for (int j = 0; j <txt.Length; j++)
                    {
                        if (char.IsUpper(txt[i]))
                        {
                            return txt;
                        }
                    }
                }
            }
            return $"pasvorrd sertlerine uygun deyl";
        }
       
    }
}
