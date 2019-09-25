using System;
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
        public Form1()
        {
            InitializeComponent();
            Developer d1 = new Developer { firstName = "Peter", lastName = "Johnson", phoneExtension = 1, gender = "male" };
            //fullname textbox
            fNText.Text = d1.firstName.ToString();
            phoneText.Text = d1.phoneExtension.ToString();
            genderText.Text = d1.gender.ToString();
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

        }

        private void DisplayWomenBtn_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMenBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
