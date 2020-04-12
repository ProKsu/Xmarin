using System;
using SQLite;

using Xamarin.Forms;

namespace Task1.BD
{
    public class AccountList 
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }


        [MaxLength(10)]
        public string Password
        {
            get;
            set;
        }
    }
}

