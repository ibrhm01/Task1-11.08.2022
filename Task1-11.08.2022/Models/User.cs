using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_11._08._2022.Models
{
    class User
    {
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25) _userName = value;
            }
        }
        private string _password;
        public string Password {
            get
            {
                return _password;
            }
            set 
            {
                if (HasDigit(value) && HasUpper(value) && HasLower(value) && value.Length >= 8 && value.Length <=  25) _password = value;
            }
        }
        public User(string Username)
        {
            this.UserName = Username;
        }
        public User(string Username, string Password):this(Username)
        {
            this.Password = Password;
        }
        public bool HasDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 48 && value[i] <= 57) return true;   
            }
            return false;

        }
        public bool HasUpper(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 65 && value[i] <= 90) return true;
            }
            return false;

        }
        public bool HasLower(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 97 && value[i] <= 122) return true;
            }
            return false;
        }
    }
}
