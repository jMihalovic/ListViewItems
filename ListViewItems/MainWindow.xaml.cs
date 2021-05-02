using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ListViewItems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.InitPeople();
            Person p = new Person();
            DataContext = p;
        }


        private void People_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person pc = (Person)((sender as ListView).SelectedItem);
            DataContext = pc;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            People.SelectedIndex = 0;
        }

        private void People_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person pc = (Person)((sender as ListView).SelectedItem);
            EditPeople ep = new EditPeople(pc);
            ep.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            EditPeople ep = new EditPeople();
            ep.ShowDialog();
        }
    }

}
