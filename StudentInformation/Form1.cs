using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class StudentInformationUI : Form
    {

        private  Student aStudent = new Student();
        public StudentInformationUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regTextBox.Text;
            aStudent.firstName = firstTextBox.Text;
            aStudent.lastName = lastTextBox.Text;

            ClearTextBox();

            MessageBox.Show("Hello " + aStudent.GetFullName()
                + "your reg no is: " + " " 
                + aStudent.regNo);
            
        }

        private void ClearTextBox()
        {
            regTextBox.Text = string.Empty;
            firstTextBox.Text = string.Empty;
            lastTextBox.Text = string.Empty;
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regTextBox.Text = aStudent.regNo;
            firstTextBox.Text = aStudent.firstName;
            lastTextBox.Text = aStudent.lastName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
             aStudent = new Student();

            ClearTextBox();

            MessageBox.Show("Cleared");
        }
    }
}
