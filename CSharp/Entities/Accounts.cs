using System;

namespace CSharp.Entities
{

    class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string document { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Account(String name)
        {
            this.name = name;
        }

    }
}