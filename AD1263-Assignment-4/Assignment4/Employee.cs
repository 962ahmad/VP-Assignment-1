using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    internal class Employee
    {
        public int nationalNumber { get; set; }
        public string fullName { get; set; }
        public int birth { get; set; }
        public string country  { get; set; }
        public string city  { get; set; }
        public string gender  { get; set; }
        public string skills  { get; set; }
        public CheckedListBox CheckedItems { get; set; }

        public Employee(int nationalNumber,string fullName,int birth, string country, string city, string gender, CheckedListBox checkedItems) 
        {
            this.nationalNumber = nationalNumber;
            this.fullName = fullName;
            this.birth = birth;
            this.country = country;
            this.city = city;
            this.gender = gender;
            this.skills = skills;
            CheckedItems = checkedItems;
        }
        public void summary()
        {
            string skills="";
            string str;
            for (int i = 0; i < CheckedItems.Items.Count; i++)
            {
                if (CheckedItems.GetItemChecked(i))
                {
                    str = (string)CheckedItems.Items[i];
                    skills += str + "\n";
                }
            }
            MessageBox.Show("ID: " + nationalNumber + "\n" + "Name: " + fullName + "\n" + "Age " + birth + "\n" + "Country: "+ country+"\n"+"City: " +city+ "\n" + "Gender: "+gender+"\n" + "Skills: \n"+skills);
        
        }
    }
}
