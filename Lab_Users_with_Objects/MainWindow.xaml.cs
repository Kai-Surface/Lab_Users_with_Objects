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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_Users_with_Objects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User _currentUser;

        public MainWindow()
        {
            InitializeComponent();

            // shape combo box
            cmbShape.ItemsSource = Enum.GetValues(typeof(Shape));

            // material combo box
            cmbMaterial.ItemsSource = Enum.GetValues(typeof(Material));

            _currentUser = new User("Kai", "Surface", new List<JamSession>());
        }

        private void btnAddToJam_Click(object sender, RoutedEventArgs e)
        {
            // get user input
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            GuitarPick.Material material = (GuitarPick.Material)cmbMaterial.SelectedItem;
            GuitarPick.Shape shape = (GuitarPick.Shape)cmbShape.SelectedItem;
            List<string> selectedStrings = GetSelectedStrings();
        }

        private List<string> GetSelectedStrings()
        {
            List<string> selectedStrings = new List<string>();

            if (btnE.IsPressed)
                selectedStrings.Add("E");
            if (btnA.IsPressed)
                selectedStrings.Add("A");
            if (btnD.IsPressed)
                selectedStrings.Add("D");
            if (btnG.IsPressed)
                selectedStrings.Add("G");
            if (btnB.IsPressed)
                selectedStrings.Add("B");
            if (btne.IsPressed)
                selectedStrings.Add("e");

            return selectedStrings;
        }

        private void StringButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Content.ToString();

            if (SelectedStrings.Contains(buttonText))
            {
                SelectedStrings.Remove(buttonText);
            }
            else
            {
                SelectedStrings.Add(buttonText);
            }
        }

    }
}
