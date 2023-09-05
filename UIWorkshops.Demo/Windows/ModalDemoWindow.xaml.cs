using System.Windows;

namespace UIWorkshops.Demos.Windows
{
    public partial class ModalDemoWindow : Window
    {
        public ModalDemoWindow()
        {
            InitializeComponent();
        }

        private void OnShowModalClick(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = true;
        }

        private void OnCloseModalClick(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = false;
        }
    }
}
