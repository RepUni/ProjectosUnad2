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

namespace ejer10
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                int somma = 0;
                int residuo;

                do
                {
                    residuo = numero % 10;
                    somma += residuo;
                    numero /= 10;
                } while (numero != 0);

                lblSomma.Content = $"La somma delle cifre è: {somma}";
            }
            else
            {
                lblSomma.Content = "Inserisci un numero valido.";
            }
        }
    }
}