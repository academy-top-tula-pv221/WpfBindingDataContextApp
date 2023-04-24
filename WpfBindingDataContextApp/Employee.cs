using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBindingDataContextApp
{
    public class Employee : INotifyPropertyChanged
    {
        string? name;
        int age;

        public string? Name 
        {
            set
            {
                if(name != value)
                {
                    name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
            get => name;
        }
        public int Age 
        { 
            set
            {
                if (age != value)
                {
                    age = value;
                    NotifyPropertyChanged(nameof(Age));
                }
            }
            get => age;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    //public class Employee
    //{

    //    public string? Name { set; get; }
    //    public int Age { set; get; }

    //}

    //public class Employee : DependencyObject
    //{
    //    public static DependencyProperty NameProperty;
    //    public static DependencyProperty AgeProperty;
    //    static Employee()
    //    {
    //        NameProperty = DependencyProperty.Register(
    //            "Name",
    //            typeof(string),
    //            typeof(Employee)
    //            );
    //        AgeProperty = DependencyProperty.Register(
    //            "Age",
    //            typeof(int),
    //            typeof(Employee)
    //            );
    //    }

    //    public string? Name
    //    {
    //        get { return (string?)GetValue(NameProperty); }
    //        set { SetValue(NameProperty, value); }
    //    }
    //    //public Company? Company { get; set; }
    //    public int Age
    //    {
    //        get { return (int)GetValue(AgeProperty); }
    //        set { SetValue(AgeProperty, value); }
    //    }
    //}

    public class Company
    {
        public string? Title { get; set; }
    }
}
