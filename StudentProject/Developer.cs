using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Developer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneExtension { get; set; }
        public string gender { get; set; }
        public string fullName { get; set; }

        
        public Developer()
        {
            firstName = "default";
            lastName = "default";
            phoneExtension = 000;
            gender = "unknown";
           
        }
        public Developer(string fN, string lN, int phoneExt, string gen, string fullN)
        {
            fN = firstName;
            lN = lastName;
            phoneExt = phoneExtension;
            gen = gender;
            fullN = fullName;
        }

        public override string ToString()
        {
            return "Full Name: " + firstName + " " + lastName + "\nPhone Extension: " + phoneExtension + "\nGender: " + gender;
        }
        

        //Developer d1 = new Developer { firstName = "Peter", lastName = "Johnson", phoneExtension = 1, gender = "Male" };
        //Developer d2 = new Developer { firstName = "John", lastName = "Posho", phoneExtension = 2, gender = "Male" };


        //int count = 0;

        //public ArrayList dev
        //{
        //    get { return dev; }
        //}
        //public void arrayInfo()
        //{
        //    dev.Add(d1);
        //    dev.Add(d2);

        //}

    }


       

}
