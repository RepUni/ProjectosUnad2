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

namespace ejer29
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
        private void CalcularPromedio_Click(object sender, RoutedEventArgs e)
        {
            double nota1, nota2, promedio;

            if (double.TryParse(Nota1TextBox.Text, out nota1) && double.TryParse(Nota2TextBox.Text, out nota2))
            {
                promedio = (nota1 + nota2) / 2;

                if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
                {
                    if (promedio >= 10.5 && promedio <= 20)
                    {
                        ResultadoTextBox.Text = $"\nPromedio: {promedio}\naprobado";
                    }
                    else
                    {
                        ResultadoTextBox.Text = $"\nPromedio: {promedio}\ndesaprobado";
                    }
                }
                else
                {
                    ResultadoTextBox.Text = "\nEROR... Las notas ingresadas no se encuentran en la escala vigesimal (0-20)";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para las notas.");
            }
        }
    }
}