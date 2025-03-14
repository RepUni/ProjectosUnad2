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

namespace ejer27
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
        private void CalcularSuma_Click(object sender, RoutedEventArgs e)
        {
            int numero, suma, x;
            suma = 0;

            if (int.TryParse(NumeroTextBox.Text, out numero))
            {
                if (numero < 8)
                {
                    ResultadoTextBox.Text = "Error el numero ingresado es menor a 8";
                }
                else
                {
                    for (x = 8; x <= numero; x = x + 1)
                    {
                        suma = suma + x;
                    }
                    ResultadoTextBox.Text = $"La suma de la serie de rango 8 hasta {numero}, con un incremento de 1 es: {suma}";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.");
            }
        }
    }
}