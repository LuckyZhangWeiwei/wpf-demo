using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace UIWorkshops.Demos.Windows
{
    /// <summary>
    /// Interaction logic for DropdownMenuDemoWindow.xaml
    /// </summary>
    public partial class DropdownMenuDemoWindow : Window
    {
        public DropdownMenuDemoWindow()
        {
            InitializeComponent();

            lvNames.ItemsSource = new List<string>()
            {
                "Joe",
                "Sean",
                "Mary"
            };
        }

        private void OnEditClick(object sender, RoutedEventArgs e)
        {
            var value = ((Button)e.Source).DataContext;
            MessageBox.Show(value.ToString());
        }

        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
