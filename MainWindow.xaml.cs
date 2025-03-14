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

namespace ejer23
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
        private void CalcularHipotenusa_Click(object sender, RoutedEventArgs e)
        {
            double catetoa, catetob, hipotenusa;

            if (double.TryParse(CatetoATextBox.Text, out catetoa) &&
                double.TryParse(CatetoBTextBox.Text, out catetob))
            {
                hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2), 0.5), 2);

                ResultadoTextBox.Text = $"La hipotenusa es: {hipotenusa}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los catetos.");
            }
        }
    }
}