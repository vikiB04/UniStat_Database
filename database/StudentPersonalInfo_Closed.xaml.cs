using database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace database
{
    /// <summary>
    /// Interaction logic for StudentPersonalInfo_Closed.xaml
    /// </summary>
    public partial class StudentPersonalInfo_Closed : Window
    {
       
      
        public StudentPersonalInfo_Closed()
        {
            InitializeComponent();
            
        }


     
        private void Button_BackMenu_StudentPersonalInfo_Closed_Click(object sender, RoutedEventArgs e)
        {
            StudentPersonalInfo_Open studentPersonalInfo_Open = new StudentPersonalInfo_Open();
            studentPersonalInfo_Open.Show();
            this.Close();
        }

        private void Button_LogOut_StudentPersonalInfo_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Logo_Student_PersonalInfo_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Submit_Result_Click(object sender, RoutedEventArgs e)
        {
           
           
            
        }
    }
}


 