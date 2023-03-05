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
    /// Interaction logic for DepartmentIInfo.xaml
    /// </summary>
    public partial class DepartmentIInfo : Window
    {
        public DepartmentIInfo()
        {
            InitializeComponent();
        }

        private void Button_Back_DepartmentInfo_Click(object sender, RoutedEventArgs e)
        {
            StudentMajorInfo_Closed studentMajorInfo_Closed = new StudentMajorInfo_Closed();
            studentMajorInfo_Closed.Show();
            this.Close();
        }
    }
}
