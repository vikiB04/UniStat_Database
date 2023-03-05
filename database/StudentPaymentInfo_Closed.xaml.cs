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
    /// Interaction logic for StudentPaymentInfo_Closed.xaml
    /// </summary>
    public partial class StudentPaymentInfo_Closed : Window
    {
        public StudentPaymentInfo_Closed()
        {
            InitializeComponent();
        }

        private void Button_Back_StudentMenuClosed_Log_In_Click(object sender, RoutedEventArgs e)
        {
            StudentPaymentInfo_Open studentPaymentInfo_Open = new StudentPaymentInfo_Open();
            studentPaymentInfo_Open.Show();
            this.Close();
        }

        private void Button_LogOut_StudentPaymentInfo_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Logo_StudentPayment_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
