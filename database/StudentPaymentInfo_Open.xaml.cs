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
    /// Interaction logic for StudentPaymentInfo_Open.xaml
    /// </summary>
    public partial class StudentPaymentInfo_Open : Window
    {
        public StudentPaymentInfo_Open()
        {
            InitializeComponent();
        }

        private void Button_BackMenu_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentPaymentInfo_Closed studentPaymentInfo_Closed = new StudentPaymentInfo_Closed();
            studentPaymentInfo_Closed.Show();
            this.Close();
        }

        private void Button_Home_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMenuClosed studentMenuClosed= new StudentMenuClosed();
            studentMenuClosed.Show();
            this.Close();
        }

        private void Button_PersonalInfo_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentPersonalInfo_Closed studentPersonalInfo_Closed= new StudentPersonalInfo_Closed();
            studentPersonalInfo_Closed.Show();
            this.Close();
        }

        private void Button_MajorInfo_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMajorInfo_Closed studentMajorInfo_Closed = new StudentMajorInfo_Closed();
            studentMajorInfo_Closed.Show();
            this.Close();
        }

        private void Button_PaymentInfo_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentPaymentInfo_Closed studentPaymentInfo_Closed=new StudentPaymentInfo_Closed();
            studentPaymentInfo_Closed.Show();   
                this.Close();
        }

        private void Button_LogOut_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Logo_StudentPaymentInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
