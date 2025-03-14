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

namespace ejer17
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
        private void Verificar_Click(object sender, RoutedEventArgs e)
        {
            double numero, pf;
            if (double.TryParse(NumeroTextBox.Text, out numero))
            {
                pf = Math.Truncate(numero);
                if (numero == pf)
                    ResultadoTextBox.Text = "no tiene parte fraccionaria";
                else
                    ResultadoTextBox.Text = "tiene parte fraccionaria";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}