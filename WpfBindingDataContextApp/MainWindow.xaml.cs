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

namespace WpfBindingDataContextApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee;

        //public static DependencyProperty EmployeeProperty;

        //public Employee Employee
        //{
        //    set
        //    {
        //        employee = value;
        //        //SetValue(EmployeeProperty, value);
        //    }
        //    get 
        //    { 
        //        return employee;
        //        //return (Employee)GetValue(EmployeeProperty);
        //    }
        //}

        //static MainWindow()
        //{
        //    EmployeeProperty = DependencyProperty.Register(
        //        "Employee",
        //        typeof(Employee),
        //        typeof(MainWindow)
        //        );
        //}
        public MainWindow()
        {
            InitializeComponent();

            employee = new()
            {
                Name = "Joe",
                //Company = new() { Title = "Yandex" },
                Age = 35
            };

            this.DataContext = employee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = "Sam";
            employee.Age = 44;
            //Employee employee = (Employee)this.Resources["employee"];
            //MessageBox.Show($"{employee.Name} {employee.Age}");
            //((Employee)this.Resources["employee"]).Name = "Sam";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{employee.Name} {employee.Age}");
        }
    }
}
