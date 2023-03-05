using System.Windows;

namespace database
{
    /// <summary>
    /// Interaction logic for StudentMajorInfo_Open.xaml
    /// </summary>
    public partial class StudentMajorInfo_Open : Window
    {
      

        public StudentMajorInfo_Open()
        {
            
        InitializeComponent();
            
        }

        private void Button_PersonalInfo_StudentMajorInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentPersonalInfo_Closed studentPersonalInfo_Closed = new StudentPersonalInfo_Closed();
            studentPersonalInfo_Closed.Show();
            this.Close();
        }


        private void Button_Home_StudentMajorInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMenuClosed studentMenuClosed = new StudentMenuClosed();
            studentMenuClosed.Show();
            this.Close();
        }

       

        private void Button_BackMenu_StudentMajorInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMajorInfo_Closed studentMajorInfo_Closed= new StudentMajorInfo_Closed();
            studentMajorInfo_Closed.Show();
            this.Close();

        }

        private void Button_MajorInfo_StudentMajorInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            StudentMajorInfo_Closed studentMajorInfo_Closed=new StudentMajorInfo_Closed();
            studentMajorInfo_Closed.Show();
            this.Close();
        }

        private void Button_PaymentInfo_StudentMajorInfo_Open_Click_1(object sender, RoutedEventArgs e)
        {
            StudentPaymentInfo_Closed studentPaymentInfo_Closed=new StudentPaymentInfo_Closed();
            studentPaymentInfo_Closed.Show();
            this.Close();
        }

        private void Button_Logo_StudentMajorInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_LogOut_StudentMajorInfo_Open_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
