using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Управление_базой_данных
{
    public partial class LoginForm : Form
    {
        private int Role;
        private String Login;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            Login = loginField.Text;
            String password = passwordField.Text;

            DataBase db = new DataBase();

            db.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("select * from users where users.userLogin = @Login and userPassword = @Password", db.GetConnection());
            command.Parameters.Add("@Login", SqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);



            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно авторизовались");


                command.CommandText = "select p.PositionID from Positions p inner join Staff s on p.PositionID = s.PositionID inner join Users u on u.staffID = s.StaffID where u.userLogin = @Login";

                Role = (int)command.ExecuteScalar();

                switch (Role)
                {
                    case 1:
                        DirectorForm directorForm = new DirectorForm();
                        directorForm.Show();
                        break;
                    case 2:
                    case 4:
                    case 8:
                    case 10:
                        ExDirectorForm fincaceForm = new ExDirectorForm();
                        fincaceForm.Show();
                        break;
                    case 3:
                    case 9:
                    case 11:
                    case 13:
                        StaffForm fincaceStaffForm = new StaffForm();
                        fincaceStaffForm.Show();
                        break;
                    case 5:
                        TechnologForm technologForm = new TechnologForm();
                        technologForm.Show();
                        break;
                    case 14:
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неправильно логин либо пароль");
            }
        }

        public int getRole()
        {
            return this.Role;
        }
        public String getLogin()
        {
            return this.Login;
        }
    }
}
