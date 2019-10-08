using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject 
{
    public partial class Form1 : Form
    {

        //private ArrayList dev = new ArrayList();
        //int count = 0;

        Developer d1 = new Developer { firstName = "Peter", lastName = "Johnson", phoneExtension = 1, gender = "Male" };
        Developer d2 = new Developer { firstName = "John", lastName = "Posho", phoneExtension = 2, gender = "Male" };
        Developer d3 = new Developer { firstName = "Boy", lastName = "Yollow", phoneExtension = 3, gender = "Female" };

       
        


        public Form1()
        {
            InitializeComponent();

            //fullname textbox
           
            //fNText.Text = d1.firstName.ToString();
            //phoneText.Text = d1.phoneExtension.ToString();
            //genderText.Text = d1.gender.ToString();
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>();
            developers.Add(d1);
            developers.Add(d2);
            developers.Add(d3);

            int index = 0;
            index = developers.Count;

            foreach (Developer child in developers)
            {
                //listBox1.Items.Add(child.firstName);
                string fn;
                fn = fNText.Text;
                fNText.Text = child.firstName;

                string pn;
                pn = phoneText.Text;
                phoneText.Text = child.phoneExtension.ToString();

                string gen;
                gen = genderText.Text;
                genderText.Text = child.gender;

                index++;
                
                //MessageBox.Show(d2.ToString());
                //MessageBox.Show(d3.ToString());

            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>();
            developers.Add(d1);
            developers.Add(d2);
            developers.Add(d3);
            int index = 0;
            index = developers.Count;
            foreach (Developer child in developers)
            {
                child.ToString();
                index--;                             
            }
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>();
            developers.Add(d1);
            developers.Add(d2);
            developers.Add(d3);
            // The Remove button was clicked.
            int selectedIndex = listBox1.SelectedIndex;

            try
            {
                // Remove the item in the List.
               developers.RemoveAt(selectedIndex);
            }
            catch
            {
                developers.Count();
            }

            listBox1.DataSource = null;
            listBox1.DataSource = developers;
            
              

        }




        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FNLabel_Click(object sender, EventArgs e)
        {

        }

        private void FNText_TextChanged(object sender, EventArgs e)
        {
           
            //fullname textbox
                 
        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {
            //phone extension textbox
        }

        private void GenderText_TextChanged(object sender, EventArgs e)
        {
            //gender textbox
        }

        private void DisplayAllBtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>();
            developers.Add(d1);
            developers.Add(d2);
            developers.Add(d3);
            foreach (Developer child in developers)
            {
                listBox1.Items.Add(child.ToString());
            }
                
        }

        private void DisplayWomenBtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>();
            developers.Add(d1);
            developers.Add(d2);
            developers.Add(d3);
            
            foreach (Developer child in developers)
            {
                
                if (child.gender == "Female")
                {
                    listBox1.Items.Add(child.ToString());
                    
                }
                else
                {
                    Console.WriteLine("Nothing here");
                }

            }
        }

            private void DisplayMenBtn_Click(object sender, EventArgs e)
        {
            List<Developer> developers = new List<Developer>();
            developers.Add(d1);
            developers.Add(d2);
            developers.Add(d3);

            foreach (Developer child in developers)
            {

                if (child.gender == "Male")
                {
                    listBox1.Items.Add(child.ToString());

                }
                else
                {
                    Console.WriteLine("Nothing here");
                }

            }

        }

        
    }
}
