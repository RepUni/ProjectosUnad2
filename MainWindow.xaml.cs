using Microsoft.VisualBasic;
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

namespace ejer16
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
        private void IngresarCaracteres_Click(object sender, RoutedEventArgs e)
        {
            string[] ordinals = new string[] { "first","second","third","forth","fiveth","sixth","seventh"};
            string caracter;
            int x;
            x = 1;

            do
            {
                string input = Interaction.InputBox("ingrese caracter", "Entrada de Caracter");
                caracter = input;

                if (caracter.Equals("a") || caracter.Equals("e") ||
                    caracter.Equals("i") || caracter.Equals("o") || caracter.Equals("u"))
                {
                    x = 0;
                }
            }
            while (x == 1);

            ResultadoTextBox.Text = $"\nLa {ordinals[x - 1]} vocal ingresada fue: " + caracter;
            x++;
        }
    }
}