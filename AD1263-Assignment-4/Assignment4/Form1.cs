using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class HumanResources : Form
    {
        public HumanResources()
        {
            InitializeComponent();
        }
        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the key wasn't letter or control charachter ignor it 
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                // don't write
                e.Handled = true;
        }

        private void cbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex == 0)
            {
                cbCity.SelectedItem = null; ;
                cbCity.Items.Clear();
                cbCity.Items.Add("Amman");
                cbCity.Items.Add("Irbid");
                cbCity.Items.Add("Jerash");
                cbCity.Items.Add("Aqaba");
            }
            else if (cbCountry.SelectedIndex == 1)
            {
                cbCity.SelectedItem = null;
                cbCity.Items.Clear();
                cbCity.Items.Add("Cairo");
                cbCity.Items.Add("Giza");
                cbCity.Items.Add("Mansoura");
                
            }
            else
            {
                cbCity.SelectedItem = null;
                cbCity.Items.Clear();
                cbCity.Items.Add("Daraa");
                cbCity.Items.Add("Idlib");
                cbCity.Items.Add("Homs");
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {

            int age = DateTime.Now.Year - dtpBirth.Value.Year;
            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else
                gender = "Female";
            Employee employee = new Employee(int.Parse(txtNationalNumber.Text), txtFullName.Text, age, cbCountry.Text,cbCity.SelectedItem.ToString(),gender, clbListOfSkills);
            employee.summary();
        }  
    }
}
