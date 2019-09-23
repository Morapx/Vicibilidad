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

namespace Vicibilidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboFigura.SelectedIndex)
            {
                case 0: //circulo
                    TextoRadio.Visibility =
                        Visibility.Visible;
                    LabelRadio.Visibility =
                        Visibility.Visible;

                    LabelBase.Visibility =
                       Visibility.Hidden;
                    TextoBase.Visibility =
                        Visibility.Hidden;

                    LabelAltura.Visibility =
                        Visibility.Hidden;
                    TextoAltura.Visibility =
                        Visibility.Hidden;

                    break;
                case 1: //triangulo
                    LabelBase.Visibility =
                        Visibility.Visible;
                    TextoBase.Visibility =
                        Visibility.Visible;

                    LabelAltura.Visibility =
                        Visibility.Visible;
                    TextoAltura.Visibility =
                        Visibility.Visible;

                    TextoRadio.Visibility =
                      Visibility.Hidden;
                    LabelRadio.Visibility =
                        Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }
    }
}
