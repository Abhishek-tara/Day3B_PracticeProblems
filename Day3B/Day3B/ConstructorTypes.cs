﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B
{
    public class ConstructorTypes
    {
        public string name;
        public int age;
        //Default Constructor
        public ConstructorTypes()
        {
            Console.WriteLine($"This is Default Constructor.....");
        }
        //Parameterized Constructor
        public ConstructorTypes(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        //To get the Output of the Parameterized Constructor.
        public void Output()
        {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"Age : {age}");
        }

        //Copy Constructor: The constructor which creates an object by copying variables from another object is called a copy constructor
        public string car;
        public string Hp;
        public ConstructorTypes(string Model, string Hp)
        {
            this.car = Model;
            this.Hp = Hp;
        }
        public ConstructorTypes(ConstructorTypes typ)
        {
            car = typ.car;
            Hp = typ.Hp;
        }
    }
}
