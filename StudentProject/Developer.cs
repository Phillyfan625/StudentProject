using System;
using System.Collections.Generic;
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
            firstName = "Peter";
            lastName = "Johnson";
            phoneExtension = 856;
            gender = "Male";
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

    }

}
