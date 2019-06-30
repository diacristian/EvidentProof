using EvidentProof.ViewModels;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EvidentProof.UserControls
{
    public partial class CreateAccount : UserControl
    { 

        public CreateAccount()
        {
            Vm = new CreateAccountVM();
            DataContext = Vm;
            InitializeComponent();
        }

        public CreateAccountVM Vm { get; set; }


        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }


        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //do stuff with elements in vm
        }
    }
}