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
    /// Interaction logic for StudentMajorInfo_Closed.xaml
    /// </summary>
    public partial class StudentMajorInfo_Closed : Window
    {
        public StudentMajorInfo_Closed()
        {
            InitializeComponent();
        }

        private void Button_Back_StudentMenuClosed_Log_In_Click(object sender, RoutedEventArgs e)
        {
            
            StudentMajorInfo_Open studentMajorInfo_Open = new StudentMajorInfo_Open();
            studentMajorInfo_Open.Show();
            this.Close();
        }

        

        private void Button_Department_Click(object sender, RoutedEventArgs e)
        {
            DepartmentIInfo departmentIInfo = new DepartmentIInfo();
            departmentIInfo.Show();
            this.Close();
        }

        private void Button_LogOut_StudentMajorInfo_Closed_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
