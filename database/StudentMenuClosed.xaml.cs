using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace database
{
    /// <summary>
    /// Interaction logic for StudentMenuClosed.xaml
    /// </summary>
    public partial class StudentMenuClosed : Window
    {
       
       
        public StudentMenuClosed()
        {
            InitializeComponent();

            
        }

        private void Button_Back_StudentMenuClosed_Log_In_Click(object sender, RoutedEventArgs e)
        {
            StudentMenuOpen page1 = new StudentMenuOpen();
            page1.Show();
            this.Close();

        }

        private void Button_LogOut_Student_Menu_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }

        private void Button_Logo_Student_Menu_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
