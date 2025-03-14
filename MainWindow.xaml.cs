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

namespace ejer13
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

        private void CalcularFactorial_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumeroTextBox.Text, out int numero))
            {
                int factorial = 1;
                int i;

                for (i = 1; i <= numero; i++)
                {
                    factorial = factorial * i; // factorial *= i
                }

                ResultadoTextBox.Text = $"{numero}! = {factorial}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.");
            }
        }
    }
}