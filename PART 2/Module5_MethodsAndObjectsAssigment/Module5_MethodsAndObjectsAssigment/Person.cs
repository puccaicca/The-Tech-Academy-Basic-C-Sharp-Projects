﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_MethodsAndObjectsAssigment
{
   public class Person 
    {
        // Create a class called Person and give it to two properties, each of data types string 
        //One called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Give the class a void method called SayName() that takes no parameters and simply writes
        // the person's full name to the console in the format of: "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
