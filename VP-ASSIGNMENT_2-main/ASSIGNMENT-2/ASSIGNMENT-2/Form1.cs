using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT_2
{
    public partial class frmLogin : Form
    {

        private User user1;
        private User user2;
        private User user3;
        private User user4;
        private User user5;

        private List<User> users;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            user1 = new User();
            user1.UserId = 1;
            user1.FullName = "Khaled Mohammad";
            user1.Username = "KM";
            user1.Password = "1234";

            user2 = new User();
            user2.UserId = 2;
            user2.FullName = "AHMAD SHRAIM";
            user2.Username = "AS";
            user2.Password = "1234";

            user3 = new User();
            user3.UserId = 3;
            user3.FullName = "AMMAR JABER";
            user3.Username = "AJ";
            user3.Password = "1234";

            user4 = new User();
            user4.UserId = 4;
            user4.FullName = "Ibrahem Awad";
            user4.Username = "IA";
            user4.Password = "1234";

            user5 = new User();
            user5.UserId = 5;
            user5.FullName = "Suad Ahmad";
            user5.Username = "SA";
            user5.Password = "1234";

            users = new List<User>();

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Username.ToLower() != txtUserName.Text.ToLower())
                {
                    index = -1;
                    
                }
                else
                {
                    if (users[i].Password == txtPassWord.Text)
                    {
                        index = 0;
                        MessageBox.Show("Welcome " + users[i].FullName);
                        break;
                    }
                    else
                    {
                        index = -2;
                        break;
                    }
                }
            }
            if (index == -1) 
            {
                MessageBox.Show("User Dosen't exist");
            }
            else if (index == -2)
            {
                MessageBox.Show("Wrong Password");
            }

            
        }
    }
}
