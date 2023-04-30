﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B
{
    public class AccessModifierTypes
    {
        //Public Access Modifier.
        //The code is accessible for all classes
        public int age = 20;

        //Private Access Modifier.
        //The code is only accessible within the same class
        private string name = "Bruce";
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        //Protected
        //The code is accessible within the same class, or in a class that is inherited from that class.
        protected string brand = "Volvo";
        public string Brand
        {
            get { return Brand; }
            set { Brand = value; }
        }       
    }
    //Internal
    internal class InternalDemo
    {
        public string brand = "BMW";
    }
    
}

