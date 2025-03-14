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

namespace ejer6
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
        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumberTextBox.Text, out int numero))
            {
                int suma = 0;
                string seriesOutput = "";

                for (int x = 1; x <= numero; x++)
                {
                    suma += x;
                    seriesOutput += $"n{x}: {x}\n";
                }

                SeriesTextBox.Text = seriesOutput;
                SumTextBox.Text = suma.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}