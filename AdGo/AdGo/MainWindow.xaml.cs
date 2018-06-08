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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdGo
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

        private void add_Cat_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow category = new CategoryWindow();
            category.Show();
            this.Close();

        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            ScheduleWindow schedule = new ScheduleWindow();
            schedule.Show();
            this.Close();
        }

        private void btnInput(object sender, RoutedEventArgs e)
        {
            InputWindow input = new InputWindow();
            input.Show();
            this.Close();
        }

        private void btnUserSettings(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow();
            userWindow.Show();
            this.Close();
           
        }
    }
}
