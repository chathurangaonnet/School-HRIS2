﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class account
    {
        int id, type;
        string name;

        public account(int id, string name, int type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            string account_type;
            if (type == 0)
                account_type = "Staff";
            else if (type == 1)
                account_type = "Student";
            else
                account_type = "Admin";

            return account_type + ":" + id.ToString() + " - " + name;
        }

        public int getID() { return id; }
    }
}