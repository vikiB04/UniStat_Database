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
    /// Interaction logic for StudentPersonalInfo_Open.xaml
    /// </summary>
    public partial class StudentPersonalInfo_Open : Window
    {

        public StudentPersonalInfo_Open()
        {
            InitializeComponent();
           
        }

        private void Button_Back_StudentMenuClosed_Log_In_Click(object sender, RoutedEventArgs e)
        {
            StudentPersonalInfo_Closed studentPersonalInfo_Closed = new StudentPersonalInfo_Closed();
            studentPersonalInfo_Closed.Show();
            this.Close();   
        }


        private void Button_PersonalInfo_StudentPersonalInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentPersonalInfo_Closed studentPersonalInfo_Closed = new StudentPersonalInfo_Closed();
            studentPersonalInfo_Closed.Show();
            this.Close();
        }

        private void Button_MajorInfo_StudentPersonalInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMajorInfo_Closed studentMajorInfo_Closed= new StudentMajorInfo_Closed(); 
            studentMajorInfo_Closed.Show();
            this.Close();

        }

        private void Button_PaymentInfo_StudentPersonalInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentPaymentInfo_Closed studentPaymentInfo_Closed=new StudentPaymentInfo_Closed();
            studentPaymentInfo_Closed.Show();
            this.Close();
        }

        private void Button_Home_StudentPersonalInfo_Closed_Click(object sender, RoutedEventArgs e)
        {
            StudentMenuClosed studentMenuClosed= new StudentMenuClosed();
            studentMenuClosed.Show();
            this.Close();

        }

        private void Button_LogOut_StudentPersonalInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Logo_StudentPersonalInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
