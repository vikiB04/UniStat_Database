using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_LogIn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-AAOO2UI; Initial Catalog=project_FINAL; Integrated Security=True");
            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                //filter only ID's between 50 and 101 in the query because the rest are for instructors and parents
               
                SqlCommand check_User_ID = new SqlCommand("SELECT COUNT(1) FROM Access_Information WHERE " +
                    "(User_ID = @User_ID and User_ID >=50 and User_ID<=101)", sqlCon); 
                SqlCommand check_Password = new SqlCommand("SELECT COUNT(1) FROM Access_Information WHERE (Password = @Password)", sqlCon);

                check_User_ID.Parameters.AddWithValue("@User_ID", TextBox_UserID.Text);
                int UserIDExist = (int)check_User_ID.ExecuteScalar();

                check_Password.Parameters.AddWithValue("@Password", PasswordBox_LogIn.Password);
                int PasswordExist = (int)check_Password.ExecuteScalar();

                string User_ID = TextBox_UserID.Text;
                string Password = PasswordBox_LogIn.Password;




                if (UserIDExist > 0 && PasswordExist > 0)
                {
                    StudentMenuClosed page1 = new StudentMenuClosed();

                    page1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


        }
    }
}
  
    
