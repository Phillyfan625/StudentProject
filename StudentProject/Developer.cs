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
        public string firstName;
        public string lastName;
        public int phoneExtension;
        public string gender;
        public string fullName;

        public Developer()
        {
            firstName = "default";
            lastName = "default";
            phoneExtension = 000;
            gender = "unknown";
            fullName = firstName + lastName;
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
            return string.Format("Full Name: " + fullName + "\n Phone Extension: " + phoneExtension + "\n Gender: " + gender);
        }

    }


       

}
