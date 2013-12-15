﻿using MAP_Lab8.Controller;
using MAP_Lab8.Model;
using MAP_Lab8.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Student> repo = new Repository<Student>();
            Validator val = new Validator(repo);
            Controller.Controller ctrl = new Controller.Controller(repo, val);
            UI.Console cons = new UI.Console(ctrl);
        }
    }
}
