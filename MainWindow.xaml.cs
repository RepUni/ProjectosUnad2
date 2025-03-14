using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ejer22
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
        private void CalcularArea_Click(object sender, RoutedEventArgs e)
        {
            double ladoa, ladob, ladoc, sm, areatriangulo;

            if (double.TryParse(LadoATextBox.Text, out ladoa) &&
                double.TryParse(LadoBTextBox.Text, out ladob) &&
                double.TryParse(LadoCTextBox.Text, out ladoc))
            {
                sm = (ladoa + ladob + ladoc) / 2;
                areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm * (sm - ladoc), 0.5), 2);

                ResultadoTextBox.Text = "El area del triangulo es: " + areatriangulo;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.");
            }
        }
    }
}