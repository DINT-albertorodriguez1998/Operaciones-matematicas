using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Operaciones_matemáticas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            SumaRadioButton.IsChecked = true;
        }

        

        private void Operando1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OperacionRealizada();
        }

        private void Operando2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OperacionRealizada();
        }

        private void SumaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            OperacionRealizada();
        }

        private void RestaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            OperacionRealizada();
        }

        private void MultiplicacionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            OperacionRealizada();
        }

        private void DivisionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            OperacionRealizada();
        }

        private void OperacionRealizada()
        {
            if (Operando1TextBox.Text != "" && Operando2TextBox.Text != "")
            {
                float operando1 = float.Parse(Operando1TextBox.Text);
                float operando2 = float.Parse(Operando2TextBox.Text);

                if ((bool)SumaRadioButton.IsChecked)
                    ResultadoTextBox.Text = (operando1 + operando2).ToString();
                else if ((bool)RestaRadioButton.IsChecked)
                    ResultadoTextBox.Text = (operando1 - operando2).ToString();
                else if ((bool)MultiplicacionRadioButton.IsChecked)
                    ResultadoTextBox.Text = (operando1 * operando2).ToString();
                else
                {
                    if (operando2 != 0)
                        ResultadoTextBox.Text = (operando1 / operando2).ToString();
                    else
                        ResultadoTextBox.Text = "Error";
                }
            }
        }
    }
}
