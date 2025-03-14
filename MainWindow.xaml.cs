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

namespace ejer26
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
        private void Calcular_click(object sender, RoutedEventArgs e)
        {
            double pi, area,radio, volumen, longitud;
            pi = 3.14;

            if (double.TryParse(RadioTextBox.Text, out radio))
            {
                longitud = 2 * pi * radio;
                area = Math.Round(pi * Math.Pow(radio, 2), 2);
                volumen = Math.Round((4.0 / 3.0) * pi * Math.Pow(radio, 3), 2);

                ResultadoTextBox.Text = $"Longitud de la circunferencia: {longitud}\n";
                ResultadoTextBox.Text += $"Area de la circunferencia: {area}\n";
                ResultadoTextBox.Text += $"Volumen de la circunferencia: {volumen}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el radio.");
            }


        }

    }
}