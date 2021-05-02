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

namespace ListViewItems
{
    /// <summary>
    /// Interaction logic for EditPeople.xaml
    /// </summary>
    public partial class EditPeople : Window
    {
        bool IsUpdating { get; set; }

        public EditPeople()
        {
            InitializeComponent();
            DataContext = new Person();
            IsUpdating = false;
        }

        public EditPeople(Person u)
        {
            InitializeComponent();
            DataContext = u;
            IsUpdating = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                Person.AllPeople.Add((Person)DataContext);
            }
            this.Close();
        }
    }
}
