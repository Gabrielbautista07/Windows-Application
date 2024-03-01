using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string day = DateCombo.GetItemText(DateCombo.SelectedItem);
            string month = MonthCombo.GetItemText(MonthCombo.SelectedItem);
            string year = YearCombo.GetItemText(YearCombo.SelectedItem);
            string gender = radioButton1.Checked == true ? "Male" : "Female";

            string lastname, firstname, middlename;

            lastname = LastBox.Text;
            firstname = FirstBox.Text;
            middlename = MiddleBox.Text;


            MessageBox.Show("Student: " + firstname + " " + middlename + " " + lastname + "\nGender: " + gender + " \nDateofBirth: " + day + "/" + month + "/" + year);

        }

        private void DateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DateCombo.Items.Add(i.ToString());
            }   
            for (int i = 1; i <= 12; i++)
            {
                MonthCombo.Items.Add(i.ToString());
            }
            for (int i = 1900; i <= 2023; i++)
            {
                YearCombo.Items.Add(i.ToString());
            }
        }
    }
}
