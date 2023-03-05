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
    /// Interaction logic for StudentMenuOpen.xaml
    /// </summary>
    public partial class StudentMenuOpen : Window
    {
        
        public StudentMenuOpen()
        {
            InitializeComponent();
           

        }

  
        private void Button_Back_StudentMenuClosed_Log_In_Click(object sender, RoutedEventArgs e)
        {
            StudentMenuClosed page2= new StudentMenuClosed();
            page2.Show();
            this.Close();
        }

 

        private void Button_Home_StudentMenu_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMenuClosed studentMenuClosed1 = new StudentMenuClosed();
            studentMenuClosed1.Show();
            this.Close();
        }

        private void Button_PersonalInfo_StudentMenu_Open2_Click(object sender, RoutedEventArgs e)
        {
            StudentPersonalInfo_Closed studentPersonalInfoClosed1 = new StudentPersonalInfo_Closed();
            studentPersonalInfoClosed1.Show();
            this.Close();
        }

        private void Button_MajorInfo_StudentMenu_Open2_Click(object sender, RoutedEventArgs e)
        {
            StudentMajorInfo_Closed studentMajorInfo_Closed1= new StudentMajorInfo_Closed();
            studentMajorInfo_Closed1.Show();
            this.Close();

        }

        private void Button_PaymentInfo_StudentMenu_Open2_Click(object sender, RoutedEventArgs e)
        {
            StudentPaymentInfo_Closed studentPaymentInfo_Closed1= new StudentPaymentInfo_Closed();
            studentPaymentInfo_Closed1.Show();
            this.Close();
        }

        private void Button_Logo_StudentMenu_Open_Click2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_LogOut_StudentMenu_Open2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
