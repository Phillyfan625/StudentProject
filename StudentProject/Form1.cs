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
        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int index = 0;

        //this was for the list to hold all of the developers
        //Developer d1 = new Developer { firstName = "Peter", lastName = "Johnson", phoneExtension = 1, gender = "Male" };
        //Developer d2 = new Developer { firstName = "John", lastName = "Posho", phoneExtension = 2, gender = "Female" };
        //Developer d3 = new Developer { firstName = "Boy", lastName = "Yollow", phoneExtension = 3, gender = "Female" };



        public Form1()
        {
            InitializeComponent();

            //fullname textbox        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.DeveloperConnectionString;


                objConnect.connection_string = conString;

                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;

                NavigateRecords();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[index];

            fNText.Text = dRow.ItemArray.GetValue(1).ToString();
            lName.Text = dRow.ItemArray.GetValue(2).ToString();
            phoneText.Text = dRow.ItemArray.GetValue(3).ToString();
            genderText.Text = dRow.ItemArray.GetValue(4).ToString();
            //txtDepartment.Text = dRow.ItemArray.GetValue(4).ToString();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

            //without SQL

            //List<Developer> developers = new List<Developer>();
            //developers.Add(d1);
            //developers.Add(d2);
            //developers.Add(d3);

            //developers.ElementAt(index);
            //Developer d = developers.ElementAt(index);
            //fNText.Text = d.firstName;
            //phoneText.Text = d.phoneExtension.ToString();
            //genderText.Text = d.gender;

            //index++;

            //with SQL
            if (index != MaxRows - 1)
            {
                index++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No more rows");
            }

        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            //without sql

            //List<Developer> developers = new List<Developer>();
            //developers.Add(d1);
            //developers.Add(d2);
            //developers.Add(d3);


            //developers.ElementAt(index);
            //Developer d = developers.ElementAt(index);
            //fNText.Text = d.firstName;
            //phoneText.Text = d.phoneExtension.ToString();
            //genderText.Text = d.gender;

            //index--;

            //with sql
            if (index > 0)
            {
                index--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First Record!");
            }

        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //List<Developer> developers = new List<Developer>();
            //developers.Add(d1);
            //developers.Add(d2);
            //developers.Add(d3);
            //// The Remove button was clicked.
            //int selectedIndex = listBox1.SelectedIndex;

            //try
            //{
            //    // Remove the item in the List.
            //   developers.RemoveAt(selectedIndex);
            //}
            //catch
            //{
            //    developers.Count();
            //}

            //listBox1.DataSource = null;
            //listBox1.DataSource = developers;
          
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
            //List<Developer> developers = new List<Developer>();
            //developers.Add(d1);
            //developers.Add(d2);
            //developers.Add(d3);
            //foreach (Developer child in developers)
            //{
            //    listBox1.Items.Add(child.ToString());
            //}
                
        }

        private void DisplayWomenBtn_Click(object sender, EventArgs e)
        {
            //List<Developer> developers = new List<Developer>();
            //developers.Add(d1);
            //developers.Add(d2);
            //developers.Add(d3);
            
            //foreach (Developer child in developers)
            //{               
            //    if (child.gender == "Female")
            //    {
            //        listBox1.Items.Add(child.ToString());                   
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nothing here");
            //    }
            //}
        }

            private void DisplayMenBtn_Click(object sender, EventArgs e)
        {
            //List<Developer> developers = new List<Developer>();
            //developers.Add(d1);
            //developers.Add(d2);
            //developers.Add(d3);

            //foreach (Developer child in developers)
            //{
            //    if (child.gender == "Male")
            //    {
            //        listBox1.Items.Add(child.ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nothing here");
            //    }
            //}
        }     
    }
}
