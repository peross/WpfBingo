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
using System.Windows.Threading;

namespace WpBingo
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

        String izvuceniBrojevi = "{0, -10}{1, -20}{2, -20}{3, -20}{4, -20}{5, -20}{6, -20}{7, -20}";
        BitmapImage img = new BitmapImage();

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        DispatcherTimer dispatcherTimer2 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer3 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer4 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer5 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer6 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer7 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer8 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer9 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer10 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer11 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer12 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer13 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer14 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer15 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer16 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer17 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer18 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer19 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer20 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer21 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer22 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer23 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer24 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer25 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer26 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer27 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer28 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer29 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer30 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer31 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer32 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer33 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer34 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer35 = new DispatcherTimer();
        DispatcherTimer dispatcherTimer36 = new DispatcherTimer();

        private void krajKolaPoruka()
        {
            MessageBox.Show("Završeno kolo!", "Obavještenje", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DispatcherTimer36_Tick(object sender, EventArgs e)
        {
            
        }

        private void DispatcherTimer35_Tick(object sender, EventArgs e)
        {
            tbBroj35.Text = Convert.ToString(lstBrojevi.Items[34]);
            if ((tbBroj35.Text == "1") || (tbBroj35.Text == "8") || (tbBroj35.Text == "15") || (tbBroj35.Text == "22")
                || (tbBroj35.Text == "29") || (tbBroj35.Text == "36") || (tbBroj35.Text == "43"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj35.Text == "2") || (tbBroj35.Text == "9") || (tbBroj35.Text == "16") || (tbBroj35.Text == "23")
                || (tbBroj35.Text == "30") || (tbBroj35.Text == "37") || (tbBroj35.Text == "44"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj35.Text == "3") || (tbBroj35.Text == "10") || (tbBroj35.Text == "17") || (tbBroj35.Text == "24")
                || (tbBroj35.Text == "31") || (tbBroj35.Text == "38") || (tbBroj35.Text == "45"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj35.Text == "4") || (tbBroj35.Text == "11") || (tbBroj35.Text == "18") || (tbBroj35.Text == "25")
                || (tbBroj35.Text == "32") || (tbBroj35.Text == "39") || (tbBroj35.Text == "46"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj35.Text == "5") || (tbBroj35.Text == "12") || (tbBroj35.Text == "19") || (tbBroj35.Text == "26")
                || (tbBroj35.Text == "33") || (tbBroj35.Text == "40") || (tbBroj35.Text == "47"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj35.Text == "6") || (tbBroj35.Text == "13") || (tbBroj35.Text == "20") || (tbBroj35.Text == "27")
                || (tbBroj35.Text == "34") || (tbBroj35.Text == "41") || (tbBroj35.Text == "48"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj35.Text == "7") || (tbBroj35.Text == "14") || (tbBroj35.Text == "21") || (tbBroj35.Text == "28")
                || (tbBroj35.Text == "35") || (tbBroj35.Text == "42") || (tbBroj35.Text == "49"))
            {
                eBroj35.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj35.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer34_Tick(object sender, EventArgs e)
        {
            tbBroj34.Text = Convert.ToString(lstBrojevi.Items[33]);
            if ((tbBroj34.Text == "1") || (tbBroj34.Text == "8") || (tbBroj34.Text == "15") || (tbBroj34.Text == "22")
                || (tbBroj34.Text == "29") || (tbBroj34.Text == "36") || (tbBroj34.Text == "43"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj34.Text == "2") || (tbBroj34.Text == "9") || (tbBroj34.Text == "16") || (tbBroj34.Text == "23")
                || (tbBroj34.Text == "30") || (tbBroj34.Text == "37") || (tbBroj34.Text == "44"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj34.Text == "3") || (tbBroj34.Text == "10") || (tbBroj34.Text == "17") || (tbBroj34.Text == "24")
                || (tbBroj34.Text == "31") || (tbBroj34.Text == "38") || (tbBroj34.Text == "45"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj34.Text == "4") || (tbBroj34.Text == "11") || (tbBroj34.Text == "18") || (tbBroj34.Text == "25")
                || (tbBroj34.Text == "32") || (tbBroj34.Text == "39") || (tbBroj34.Text == "46"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj34.Text == "5") || (tbBroj34.Text == "12") || (tbBroj34.Text == "19") || (tbBroj34.Text == "26")
                || (tbBroj34.Text == "33") || (tbBroj34.Text == "40") || (tbBroj34.Text == "47"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj34.Text == "6") || (tbBroj34.Text == "13") || (tbBroj34.Text == "20") || (tbBroj34.Text == "27")
                || (tbBroj34.Text == "34") || (tbBroj34.Text == "41") || (tbBroj34.Text == "48"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj34.Text == "7") || (tbBroj34.Text == "14") || (tbBroj34.Text == "21") || (tbBroj34.Text == "28")
                || (tbBroj34.Text == "35") || (tbBroj34.Text == "42") || (tbBroj34.Text == "49"))
            {
                eBroj34.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj34.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer33_Tick(object sender, EventArgs e)
        {
            tbBroj33.Text = Convert.ToString(lstBrojevi.Items[32]);
            if ((tbBroj33.Text == "1") || (tbBroj33.Text == "8") || (tbBroj33.Text == "15") || (tbBroj33.Text == "22")
                || (tbBroj33.Text == "29") || (tbBroj33.Text == "36") || (tbBroj33.Text == "43"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj33.Text == "2") || (tbBroj33.Text == "9") || (tbBroj33.Text == "16") || (tbBroj33.Text == "23")
                || (tbBroj33.Text == "30") || (tbBroj33.Text == "37") || (tbBroj33.Text == "44"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj33.Text == "3") || (tbBroj33.Text == "10") || (tbBroj33.Text == "17") || (tbBroj33.Text == "24")
                || (tbBroj33.Text == "31") || (tbBroj33.Text == "38") || (tbBroj33.Text == "45"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj33.Text == "4") || (tbBroj33.Text == "11") || (tbBroj33.Text == "18") || (tbBroj33.Text == "25")
                || (tbBroj33.Text == "32") || (tbBroj33.Text == "39") || (tbBroj33.Text == "46"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj33.Text == "5") || (tbBroj33.Text == "12") || (tbBroj33.Text == "19") || (tbBroj33.Text == "26")
                || (tbBroj33.Text == "33") || (tbBroj33.Text == "40") || (tbBroj33.Text == "47"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj33.Text == "6") || (tbBroj33.Text == "13") || (tbBroj33.Text == "20") || (tbBroj33.Text == "27")
                || (tbBroj33.Text == "34") || (tbBroj33.Text == "41") || (tbBroj33.Text == "48"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj33.Text == "7") || (tbBroj33.Text == "14") || (tbBroj33.Text == "21") || (tbBroj33.Text == "28")
                || (tbBroj33.Text == "35") || (tbBroj33.Text == "42") || (tbBroj33.Text == "49"))
            {
                eBroj33.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj33.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer32_Tick(object sender, EventArgs e)
        {
            tbBroj32.Text = Convert.ToString(lstBrojevi.Items[31]);
            if ((tbBroj32.Text == "1") || (tbBroj32.Text == "8") || (tbBroj32.Text == "15") || (tbBroj32.Text == "22")
                || (tbBroj32.Text == "29") || (tbBroj32.Text == "36") || (tbBroj32.Text == "43"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj32.Text == "2") || (tbBroj32.Text == "9") || (tbBroj32.Text == "16") || (tbBroj32.Text == "23")
                || (tbBroj32.Text == "30") || (tbBroj32.Text == "37") || (tbBroj32.Text == "44"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj32.Text == "3") || (tbBroj32.Text == "10") || (tbBroj32.Text == "17") || (tbBroj32.Text == "24")
                || (tbBroj32.Text == "31") || (tbBroj32.Text == "38") || (tbBroj32.Text == "45"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj32.Text == "4") || (tbBroj32.Text == "11") || (tbBroj32.Text == "18") || (tbBroj32.Text == "25")
                || (tbBroj32.Text == "32") || (tbBroj32.Text == "39") || (tbBroj32.Text == "46"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj32.Text == "5") || (tbBroj32.Text == "12") || (tbBroj32.Text == "19") || (tbBroj32.Text == "26")
                || (tbBroj32.Text == "33") || (tbBroj32.Text == "40") || (tbBroj32.Text == "47"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj32.Text == "6") || (tbBroj32.Text == "13") || (tbBroj32.Text == "20") || (tbBroj32.Text == "27")
                || (tbBroj32.Text == "34") || (tbBroj32.Text == "41") || (tbBroj32.Text == "48"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj32.Text == "7") || (tbBroj32.Text == "14") || (tbBroj32.Text == "21") || (tbBroj32.Text == "28")
                || (tbBroj32.Text == "35") || (tbBroj32.Text == "42") || (tbBroj32.Text == "49"))
            {
                eBroj32.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj32.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer31_Tick(object sender, EventArgs e)
        {
            tbBroj31.Text = Convert.ToString(lstBrojevi.Items[30]);
            if ((tbBroj31.Text == "1") || (tbBroj31.Text == "8") || (tbBroj31.Text == "15") || (tbBroj31.Text == "22")
                || (tbBroj31.Text == "29") || (tbBroj31.Text == "36") || (tbBroj31.Text == "43"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj31.Text == "2") || (tbBroj31.Text == "9") || (tbBroj31.Text == "16") || (tbBroj31.Text == "23")
                || (tbBroj31.Text == "30") || (tbBroj31.Text == "37") || (tbBroj31.Text == "44"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj31.Text == "3") || (tbBroj31.Text == "10") || (tbBroj31.Text == "17") || (tbBroj31.Text == "24")
                || (tbBroj31.Text == "31") || (tbBroj31.Text == "38") || (tbBroj31.Text == "45"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj31.Text == "4") || (tbBroj31.Text == "11") || (tbBroj31.Text == "18") || (tbBroj31.Text == "25")
                || (tbBroj31.Text == "32") || (tbBroj31.Text == "39") || (tbBroj31.Text == "46"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj31.Text == "5") || (tbBroj31.Text == "12") || (tbBroj31.Text == "19") || (tbBroj31.Text == "26")
                || (tbBroj31.Text == "33") || (tbBroj31.Text == "40") || (tbBroj31.Text == "47"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj31.Text == "6") || (tbBroj31.Text == "13") || (tbBroj31.Text == "20") || (tbBroj31.Text == "27")
                || (tbBroj31.Text == "34") || (tbBroj31.Text == "41") || (tbBroj31.Text == "48"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj31.Text == "7") || (tbBroj31.Text == "14") || (tbBroj31.Text == "21") || (tbBroj31.Text == "28")
                || (tbBroj31.Text == "35") || (tbBroj31.Text == "42") || (tbBroj31.Text == "49"))
            {
                eBroj31.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj31.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer30_Tick(object sender, EventArgs e)
        {
            tbBroj30.Text = Convert.ToString(lstBrojevi.Items[29]);
            if ((tbBroj30.Text == "1") || (tbBroj30.Text == "8") || (tbBroj30.Text == "15") || (tbBroj30.Text == "22")
                || (tbBroj30.Text == "29") || (tbBroj30.Text == "36") || (tbBroj30.Text == "43"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj30.Text == "2") || (tbBroj30.Text == "9") || (tbBroj30.Text == "16") || (tbBroj30.Text == "23")
                || (tbBroj30.Text == "30") || (tbBroj30.Text == "37") || (tbBroj30.Text == "44"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj30.Text == "3") || (tbBroj30.Text == "10") || (tbBroj30.Text == "17") || (tbBroj30.Text == "24")
                || (tbBroj30.Text == "31") || (tbBroj30.Text == "38") || (tbBroj30.Text == "45"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj30.Text == "4") || (tbBroj30.Text == "11") || (tbBroj30.Text == "18") || (tbBroj30.Text == "25")
                || (tbBroj30.Text == "32") || (tbBroj30.Text == "39") || (tbBroj30.Text == "46"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj30.Text == "5") || (tbBroj30.Text == "12") || (tbBroj30.Text == "19") || (tbBroj30.Text == "26")
                || (tbBroj30.Text == "33") || (tbBroj30.Text == "40") || (tbBroj30.Text == "47"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj30.Text == "6") || (tbBroj30.Text == "13") || (tbBroj30.Text == "20") || (tbBroj30.Text == "27")
                || (tbBroj30.Text == "34") || (tbBroj30.Text == "41") || (tbBroj30.Text == "48"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj30.Text == "7") || (tbBroj30.Text == "14") || (tbBroj30.Text == "21") || (tbBroj30.Text == "28")
                || (tbBroj30.Text == "35") || (tbBroj30.Text == "42") || (tbBroj30.Text == "49"))
            {
                eBroj30.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj30.Visibility = Visibility.Visible; ;
        }

        private void DispatcherTimer29_Tick(object sender, EventArgs e)
        {
            tbBroj29.Text = Convert.ToString(lstBrojevi.Items[28]);
            if ((tbBroj29.Text == "1") || (tbBroj29.Text == "8") || (tbBroj29.Text == "15") || (tbBroj29.Text == "22")
                || (tbBroj29.Text == "29") || (tbBroj29.Text == "36") || (tbBroj29.Text == "43"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj29.Text == "2") || (tbBroj29.Text == "9") || (tbBroj29.Text == "16") || (tbBroj29.Text == "23")
                || (tbBroj29.Text == "30") || (tbBroj29.Text == "37") || (tbBroj29.Text == "44"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj29.Text == "3") || (tbBroj29.Text == "10") || (tbBroj29.Text == "17") || (tbBroj29.Text == "24")
                || (tbBroj29.Text == "31") || (tbBroj29.Text == "38") || (tbBroj29.Text == "45"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj29.Text == "4") || (tbBroj29.Text == "11") || (tbBroj29.Text == "18") || (tbBroj29.Text == "25")
                || (tbBroj29.Text == "32") || (tbBroj29.Text == "39") || (tbBroj29.Text == "46"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj29.Text == "5") || (tbBroj29.Text == "12") || (tbBroj29.Text == "19") || (tbBroj29.Text == "26")
                || (tbBroj29.Text == "33") || (tbBroj29.Text == "40") || (tbBroj29.Text == "47"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj29.Text == "6") || (tbBroj29.Text == "13") || (tbBroj29.Text == "20") || (tbBroj29.Text == "27")
                || (tbBroj29.Text == "34") || (tbBroj29.Text == "41") || (tbBroj29.Text == "48"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj29.Text == "7") || (tbBroj29.Text == "14") || (tbBroj29.Text == "21") || (tbBroj29.Text == "28")
                || (tbBroj29.Text == "35") || (tbBroj29.Text == "42") || (tbBroj29.Text == "49"))
            {
                eBroj29.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj29.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer28_Tick(object sender, EventArgs e)
        {
            tbBroj28.Text = Convert.ToString(lstBrojevi.Items[27]);
            if ((tbBroj28.Text == "1") || (tbBroj28.Text == "8") || (tbBroj28.Text == "15") || (tbBroj28.Text == "22")
                || (tbBroj28.Text == "29") || (tbBroj28.Text == "36") || (tbBroj28.Text == "43"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj28.Text == "2") || (tbBroj28.Text == "9") || (tbBroj28.Text == "16") || (tbBroj28.Text == "23")
                || (tbBroj28.Text == "30") || (tbBroj28.Text == "37") || (tbBroj28.Text == "44"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj28.Text == "3") || (tbBroj28.Text == "10") || (tbBroj28.Text == "17") || (tbBroj28.Text == "24")
                || (tbBroj28.Text == "31") || (tbBroj28.Text == "38") || (tbBroj28.Text == "45"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj28.Text == "4") || (tbBroj28.Text == "11") || (tbBroj28.Text == "18") || (tbBroj28.Text == "25")
                || (tbBroj28.Text == "32") || (tbBroj28.Text == "39") || (tbBroj28.Text == "46"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj28.Text == "5") || (tbBroj28.Text == "12") || (tbBroj28.Text == "19") || (tbBroj28.Text == "26")
                || (tbBroj28.Text == "33") || (tbBroj28.Text == "40") || (tbBroj28.Text == "47"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj28.Text == "6") || (tbBroj28.Text == "13") || (tbBroj28.Text == "20") || (tbBroj28.Text == "27")
                || (tbBroj28.Text == "34") || (tbBroj28.Text == "41") || (tbBroj28.Text == "48"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj28.Text == "7") || (tbBroj28.Text == "14") || (tbBroj28.Text == "21") || (tbBroj28.Text == "28")
                || (tbBroj28.Text == "35") || (tbBroj28.Text == "42") || (tbBroj28.Text == "49"))
            {
                eBroj28.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj28.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer27_Tick(object sender, EventArgs e)
        {
            tbBroj27.Text = Convert.ToString(lstBrojevi.Items[26]);
            if ((tbBroj27.Text == "1") || (tbBroj27.Text == "8") || (tbBroj27.Text == "15") || (tbBroj27.Text == "22")
                || (tbBroj27.Text == "29") || (tbBroj27.Text == "36") || (tbBroj27.Text == "43"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj27.Text == "2") || (tbBroj27.Text == "9") || (tbBroj27.Text == "16") || (tbBroj27.Text == "23")
                || (tbBroj27.Text == "30") || (tbBroj27.Text == "37") || (tbBroj27.Text == "44"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj27.Text == "3") || (tbBroj27.Text == "10") || (tbBroj27.Text == "17") || (tbBroj27.Text == "24")
                || (tbBroj27.Text == "31") || (tbBroj27.Text == "38") || (tbBroj27.Text == "45"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj27.Text == "4") || (tbBroj27.Text == "11") || (tbBroj27.Text == "18") || (tbBroj27.Text == "25")
                || (tbBroj27.Text == "32") || (tbBroj27.Text == "39") || (tbBroj27.Text == "46"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj27.Text == "5") || (tbBroj27.Text == "12") || (tbBroj27.Text == "19") || (tbBroj27.Text == "26")
                || (tbBroj27.Text == "33") || (tbBroj27.Text == "40") || (tbBroj27.Text == "47"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj27.Text == "6") || (tbBroj27.Text == "13") || (tbBroj27.Text == "20") || (tbBroj27.Text == "27")
                || (tbBroj27.Text == "34") || (tbBroj27.Text == "41") || (tbBroj27.Text == "48"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj27.Text == "7") || (tbBroj27.Text == "14") || (tbBroj27.Text == "21") || (tbBroj27.Text == "28")
                || (tbBroj27.Text == "35") || (tbBroj27.Text == "42") || (tbBroj27.Text == "49"))
            {
                eBroj27.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj27.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer26_Tick(object sender, EventArgs e)
        {
            tbBroj26.Text = Convert.ToString(lstBrojevi.Items[25]);
            if ((tbBroj26.Text == "1") || (tbBroj26.Text == "8") || (tbBroj26.Text == "15") || (tbBroj26.Text == "22")
                || (tbBroj26.Text == "29") || (tbBroj26.Text == "36") || (tbBroj26.Text == "43"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj26.Text == "2") || (tbBroj26.Text == "9") || (tbBroj26.Text == "16") || (tbBroj26.Text == "23")
                || (tbBroj26.Text == "30") || (tbBroj26.Text == "37") || (tbBroj26.Text == "44"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj26.Text == "3") || (tbBroj26.Text == "10") || (tbBroj26.Text == "17") || (tbBroj26.Text == "24")
                || (tbBroj26.Text == "31") || (tbBroj26.Text == "38") || (tbBroj26.Text == "45"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj26.Text == "4") || (tbBroj26.Text == "11") || (tbBroj26.Text == "18") || (tbBroj26.Text == "25")
                || (tbBroj26.Text == "32") || (tbBroj26.Text == "39") || (tbBroj26.Text == "46"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj26.Text == "5") || (tbBroj26.Text == "12") || (tbBroj26.Text == "19") || (tbBroj26.Text == "26")
                || (tbBroj26.Text == "33") || (tbBroj26.Text == "40") || (tbBroj26.Text == "47"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj26.Text == "6") || (tbBroj26.Text == "13") || (tbBroj26.Text == "20") || (tbBroj26.Text == "27")
                || (tbBroj26.Text == "34") || (tbBroj26.Text == "41") || (tbBroj26.Text == "48"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj26.Text == "7") || (tbBroj26.Text == "14") || (tbBroj26.Text == "21") || (tbBroj26.Text == "28")
                || (tbBroj26.Text == "35") || (tbBroj26.Text == "42") || (tbBroj26.Text == "49"))
            {
                eBroj26.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj26.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer25_Tick(object sender, EventArgs e)
        {
            tbBroj25.Text = Convert.ToString(lstBrojevi.Items[24]);
            if ((tbBroj25.Text == "1") || (tbBroj25.Text == "8") || (tbBroj25.Text == "15") || (tbBroj25.Text == "22")
                || (tbBroj25.Text == "29") || (tbBroj25.Text == "36") || (tbBroj25.Text == "43"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj25.Text == "2") || (tbBroj25.Text == "9") || (tbBroj25.Text == "16") || (tbBroj25.Text == "23")
                || (tbBroj25.Text == "30") || (tbBroj25.Text == "37") || (tbBroj25.Text == "44"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj25.Text == "3") || (tbBroj25.Text == "10") || (tbBroj25.Text == "17") || (tbBroj25.Text == "24")
                || (tbBroj25.Text == "31") || (tbBroj25.Text == "38") || (tbBroj25.Text == "45"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj25.Text == "4") || (tbBroj25.Text == "11") || (tbBroj25.Text == "18") || (tbBroj25.Text == "25")
                || (tbBroj25.Text == "32") || (tbBroj25.Text == "39") || (tbBroj25.Text == "46"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj25.Text == "5") || (tbBroj25.Text == "12") || (tbBroj25.Text == "19") || (tbBroj25.Text == "26")
                || (tbBroj25.Text == "33") || (tbBroj25.Text == "40") || (tbBroj25.Text == "47"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj25.Text == "6") || (tbBroj25.Text == "13") || (tbBroj25.Text == "20") || (tbBroj25.Text == "27")
                || (tbBroj25.Text == "34") || (tbBroj25.Text == "41") || (tbBroj25.Text == "48"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj25.Text == "7") || (tbBroj25.Text == "14") || (tbBroj25.Text == "21") || (tbBroj25.Text == "28")
                || (tbBroj25.Text == "35") || (tbBroj25.Text == "42") || (tbBroj25.Text == "49"))
            {
                eBroj25.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj25.Visibility = Visibility.Visible; ;
        }

        private void DispatcherTimer24_Tick(object sender, EventArgs e)
        {
            tbBroj24.Text = Convert.ToString(lstBrojevi.Items[23]);
            if ((tbBroj24.Text == "1") || (tbBroj24.Text == "8") || (tbBroj24.Text == "15") || (tbBroj24.Text == "22")
                || (tbBroj24.Text == "29") || (tbBroj24.Text == "36") || (tbBroj24.Text == "43"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj24.Text == "2") || (tbBroj24.Text == "9") || (tbBroj24.Text == "16") || (tbBroj24.Text == "23")
                || (tbBroj24.Text == "30") || (tbBroj24.Text == "37") || (tbBroj24.Text == "44"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj24.Text == "3") || (tbBroj24.Text == "10") || (tbBroj24.Text == "17") || (tbBroj24.Text == "24")
                || (tbBroj24.Text == "31") || (tbBroj24.Text == "38") || (tbBroj24.Text == "45"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj24.Text == "4") || (tbBroj24.Text == "11") || (tbBroj24.Text == "18") || (tbBroj24.Text == "25")
                || (tbBroj24.Text == "32") || (tbBroj24.Text == "39") || (tbBroj24.Text == "46"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj24.Text == "5") || (tbBroj24.Text == "12") || (tbBroj24.Text == "19") || (tbBroj24.Text == "26")
                || (tbBroj24.Text == "33") || (tbBroj24.Text == "40") || (tbBroj24.Text == "47"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj24.Text == "6") || (tbBroj24.Text == "13") || (tbBroj24.Text == "20") || (tbBroj24.Text == "27")
                || (tbBroj24.Text == "34") || (tbBroj24.Text == "41") || (tbBroj24.Text == "48"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj24.Text == "7") || (tbBroj24.Text == "14") || (tbBroj24.Text == "21") || (tbBroj24.Text == "28")
                || (tbBroj24.Text == "35") || (tbBroj24.Text == "42") || (tbBroj24.Text == "49"))
            {
                eBroj24.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj24.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer23_Tick(object sender, EventArgs e)
        {
            tbBroj23.Text = Convert.ToString(lstBrojevi.Items[22]);
            if ((tbBroj23.Text == "1") || (tbBroj23.Text == "8") || (tbBroj23.Text == "15") || (tbBroj23.Text == "22")
                || (tbBroj23.Text == "29") || (tbBroj23.Text == "36") || (tbBroj23.Text == "43"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj23.Text == "2") || (tbBroj23.Text == "9") || (tbBroj23.Text == "16") || (tbBroj23.Text == "23")
                || (tbBroj23.Text == "30") || (tbBroj23.Text == "37") || (tbBroj23.Text == "44"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj23.Text == "3") || (tbBroj23.Text == "10") || (tbBroj23.Text == "17") || (tbBroj23.Text == "24")
                || (tbBroj23.Text == "31") || (tbBroj23.Text == "38") || (tbBroj23.Text == "45"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj23.Text == "4") || (tbBroj23.Text == "11") || (tbBroj23.Text == "18") || (tbBroj23.Text == "25")
                || (tbBroj23.Text == "32") || (tbBroj23.Text == "39") || (tbBroj23.Text == "46"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj23.Text == "5") || (tbBroj23.Text == "12") || (tbBroj23.Text == "19") || (tbBroj23.Text == "26")
                || (tbBroj23.Text == "33") || (tbBroj23.Text == "40") || (tbBroj23.Text == "47"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj23.Text == "6") || (tbBroj23.Text == "13") || (tbBroj23.Text == "20") || (tbBroj23.Text == "27")
                || (tbBroj23.Text == "34") || (tbBroj23.Text == "41") || (tbBroj23.Text == "48"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj23.Text == "7") || (tbBroj23.Text == "14") || (tbBroj23.Text == "21") || (tbBroj23.Text == "28")
                || (tbBroj23.Text == "35") || (tbBroj23.Text == "42") || (tbBroj23.Text == "49"))
            {
                eBroj23.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj23.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer22_Tick(object sender, EventArgs e)
        {
            tbBroj22.Text = Convert.ToString(lstBrojevi.Items[21]);
            if ((tbBroj22.Text == "1") || (tbBroj22.Text == "8") || (tbBroj22.Text == "15") || (tbBroj22.Text == "22")
                || (tbBroj22.Text == "29") || (tbBroj22.Text == "36") || (tbBroj22.Text == "43"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj22.Text == "2") || (tbBroj22.Text == "9") || (tbBroj22.Text == "16") || (tbBroj22.Text == "23")
                || (tbBroj22.Text == "30") || (tbBroj22.Text == "37") || (tbBroj22.Text == "44"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj22.Text == "3") || (tbBroj22.Text == "10") || (tbBroj22.Text == "17") || (tbBroj22.Text == "24")
                || (tbBroj22.Text == "31") || (tbBroj22.Text == "38") || (tbBroj22.Text == "45"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj22.Text == "4") || (tbBroj22.Text == "11") || (tbBroj22.Text == "18") || (tbBroj22.Text == "25")
                || (tbBroj22.Text == "32") || (tbBroj22.Text == "39") || (tbBroj22.Text == "46"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj22.Text == "5") || (tbBroj22.Text == "12") || (tbBroj22.Text == "19") || (tbBroj22.Text == "26")
                || (tbBroj22.Text == "33") || (tbBroj22.Text == "40") || (tbBroj22.Text == "47"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj22.Text == "6") || (tbBroj22.Text == "13") || (tbBroj22.Text == "20") || (tbBroj22.Text == "27")
                || (tbBroj22.Text == "34") || (tbBroj22.Text == "41") || (tbBroj22.Text == "48"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj22.Text == "7") || (tbBroj22.Text == "14") || (tbBroj22.Text == "21") || (tbBroj22.Text == "28")
                || (tbBroj22.Text == "35") || (tbBroj22.Text == "42") || (tbBroj22.Text == "49"))
            {
                eBroj22.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj22.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer21_Tick(object sender, EventArgs e)
        {
            tbBroj21.Text = Convert.ToString(lstBrojevi.Items[20]);
            if ((tbBroj21.Text == "1") || (tbBroj21.Text == "8") || (tbBroj21.Text == "15") || (tbBroj21.Text == "22")
                || (tbBroj21.Text == "29") || (tbBroj21.Text == "36") || (tbBroj21.Text == "43"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj21.Text == "2") || (tbBroj21.Text == "9") || (tbBroj21.Text == "16") || (tbBroj21.Text == "23")
                || (tbBroj21.Text == "30") || (tbBroj21.Text == "37") || (tbBroj21.Text == "44"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj21.Text == "3") || (tbBroj21.Text == "10") || (tbBroj21.Text == "17") || (tbBroj21.Text == "24")
                || (tbBroj21.Text == "31") || (tbBroj21.Text == "38") || (tbBroj21.Text == "45"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj21.Text == "4") || (tbBroj21.Text == "11") || (tbBroj21.Text == "18") || (tbBroj21.Text == "25")
                || (tbBroj21.Text == "32") || (tbBroj21.Text == "39") || (tbBroj21.Text == "46"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj21.Text == "5") || (tbBroj21.Text == "12") || (tbBroj21.Text == "19") || (tbBroj21.Text == "26")
                || (tbBroj21.Text == "33") || (tbBroj21.Text == "40") || (tbBroj21.Text == "47"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj21.Text == "6") || (tbBroj21.Text == "13") || (tbBroj21.Text == "20") || (tbBroj21.Text == "27")
                || (tbBroj21.Text == "34") || (tbBroj21.Text == "41") || (tbBroj21.Text == "48"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj21.Text == "7") || (tbBroj21.Text == "14") || (tbBroj21.Text == "21") || (tbBroj21.Text == "28")
                || (tbBroj21.Text == "35") || (tbBroj21.Text == "42") || (tbBroj21.Text == "49"))
            {
                eBroj21.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj21.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer20_Tick(object sender, EventArgs e)
        {
            tbBroj20.Text = Convert.ToString(lstBrojevi.Items[19]);
            if ((tbBroj20.Text == "1") || (tbBroj20.Text == "8") || (tbBroj20.Text == "15") || (tbBroj20.Text == "22")
                || (tbBroj20.Text == "29") || (tbBroj20.Text == "36") || (tbBroj20.Text == "43"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj20.Text == "2") || (tbBroj20.Text == "9") || (tbBroj20.Text == "16") || (tbBroj20.Text == "23")
                || (tbBroj20.Text == "30") || (tbBroj20.Text == "37") || (tbBroj20.Text == "44"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj20.Text == "3") || (tbBroj20.Text == "10") || (tbBroj20.Text == "17") || (tbBroj20.Text == "24")
                || (tbBroj20.Text == "31") || (tbBroj20.Text == "38") || (tbBroj20.Text == "45"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj20.Text == "4") || (tbBroj20.Text == "11") || (tbBroj20.Text == "18") || (tbBroj20.Text == "25")
                || (tbBroj20.Text == "32") || (tbBroj20.Text == "39") || (tbBroj20.Text == "46"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj20.Text == "5") || (tbBroj20.Text == "12") || (tbBroj20.Text == "19") || (tbBroj20.Text == "26")
                || (tbBroj20.Text == "33") || (tbBroj20.Text == "40") || (tbBroj20.Text == "47"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj20.Text == "6") || (tbBroj20.Text == "13") || (tbBroj20.Text == "20") || (tbBroj20.Text == "27")
                || (tbBroj20.Text == "34") || (tbBroj20.Text == "41") || (tbBroj20.Text == "48"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj20.Text == "7") || (tbBroj20.Text == "14") || (tbBroj20.Text == "21") || (tbBroj20.Text == "28")
                || (tbBroj20.Text == "35") || (tbBroj20.Text == "42") || (tbBroj20.Text == "49"))
            {
                eBroj20.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj20.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer19_Tick(object sender, EventArgs e)
        {
            tbBroj19.Text = Convert.ToString(lstBrojevi.Items[18]);
            if ((tbBroj19.Text == "1") || (tbBroj19.Text == "8") || (tbBroj19.Text == "15") || (tbBroj19.Text == "22")
                || (tbBroj19.Text == "29") || (tbBroj19.Text == "36") || (tbBroj19.Text == "43"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj19.Text == "2") || (tbBroj19.Text == "9") || (tbBroj19.Text == "16") || (tbBroj19.Text == "23")
                || (tbBroj19.Text == "30") || (tbBroj19.Text == "37") || (tbBroj19.Text == "44"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj19.Text == "3") || (tbBroj19.Text == "10") || (tbBroj19.Text == "17") || (tbBroj19.Text == "24")
                || (tbBroj19.Text == "31") || (tbBroj19.Text == "38") || (tbBroj19.Text == "45"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj19.Text == "4") || (tbBroj19.Text == "11") || (tbBroj19.Text == "18") || (tbBroj19.Text == "25")
                || (tbBroj19.Text == "32") || (tbBroj19.Text == "39") || (tbBroj19.Text == "46"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj19.Text == "5") || (tbBroj19.Text == "12") || (tbBroj19.Text == "19") || (tbBroj19.Text == "26")
                || (tbBroj19.Text == "33") || (tbBroj19.Text == "40") || (tbBroj19.Text == "47"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj19.Text == "6") || (tbBroj19.Text == "13") || (tbBroj19.Text == "20") || (tbBroj19.Text == "27")
                || (tbBroj19.Text == "34") || (tbBroj19.Text == "41") || (tbBroj19.Text == "48"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj19.Text == "7") || (tbBroj19.Text == "14") || (tbBroj19.Text == "21") || (tbBroj19.Text == "28")
                || (tbBroj19.Text == "35") || (tbBroj19.Text == "42") || (tbBroj19.Text == "49"))
            {
                eBroj19.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj19.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer18_Tick(object sender, EventArgs e)
        {
            tbBroj18.Text = Convert.ToString(lstBrojevi.Items[17]);
            if ((tbBroj18.Text == "1") || (tbBroj18.Text == "8") || (tbBroj18.Text == "15") || (tbBroj18.Text == "22")
                || (tbBroj18.Text == "29") || (tbBroj18.Text == "36") || (tbBroj18.Text == "43"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj18.Text == "2") || (tbBroj18.Text == "9") || (tbBroj18.Text == "16") || (tbBroj18.Text == "23")
                || (tbBroj18.Text == "30") || (tbBroj18.Text == "37") || (tbBroj18.Text == "44"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj18.Text == "3") || (tbBroj18.Text == "10") || (tbBroj18.Text == "17") || (tbBroj18.Text == "24")
                || (tbBroj18.Text == "31") || (tbBroj18.Text == "38") || (tbBroj18.Text == "45"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj18.Text == "4") || (tbBroj18.Text == "11") || (tbBroj18.Text == "18") || (tbBroj18.Text == "25")
                || (tbBroj18.Text == "32") || (tbBroj18.Text == "39") || (tbBroj18.Text == "46"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj18.Text == "5") || (tbBroj18.Text == "12") || (tbBroj18.Text == "19") || (tbBroj18.Text == "26")
                || (tbBroj18.Text == "33") || (tbBroj18.Text == "40") || (tbBroj18.Text == "47"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj18.Text == "6") || (tbBroj18.Text == "13") || (tbBroj18.Text == "20") || (tbBroj18.Text == "27")
                || (tbBroj18.Text == "34") || (tbBroj18.Text == "41") || (tbBroj18.Text == "48"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj18.Text == "7") || (tbBroj18.Text == "14") || (tbBroj18.Text == "21") || (tbBroj18.Text == "28")
                || (tbBroj18.Text == "35") || (tbBroj18.Text == "42") || (tbBroj18.Text == "49"))
            {
                eBroj18.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj18.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer17_Tick(object sender, EventArgs e)
        {
            tbBroj17.Text = Convert.ToString(lstBrojevi.Items[16]);
            if ((tbBroj17.Text == "1") || (tbBroj17.Text == "8") || (tbBroj17.Text == "15") || (tbBroj17.Text == "22")
                || (tbBroj17.Text == "29") || (tbBroj17.Text == "36") || (tbBroj17.Text == "43"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj17.Text == "2") || (tbBroj17.Text == "9") || (tbBroj17.Text == "16") || (tbBroj17.Text == "23")
                || (tbBroj17.Text == "30") || (tbBroj17.Text == "37") || (tbBroj17.Text == "44"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj17.Text == "3") || (tbBroj17.Text == "10") || (tbBroj17.Text == "17") || (tbBroj17.Text == "24")
                || (tbBroj17.Text == "31") || (tbBroj17.Text == "38") || (tbBroj17.Text == "45"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj17.Text == "4") || (tbBroj17.Text == "11") || (tbBroj17.Text == "18") || (tbBroj17.Text == "25")
                || (tbBroj17.Text == "32") || (tbBroj17.Text == "39") || (tbBroj17.Text == "46"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj17.Text == "5") || (tbBroj17.Text == "12") || (tbBroj17.Text == "19") || (tbBroj17.Text == "26")
                || (tbBroj17.Text == "33") || (tbBroj17.Text == "40") || (tbBroj17.Text == "47"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj17.Text == "6") || (tbBroj17.Text == "13") || (tbBroj17.Text == "20") || (tbBroj17.Text == "27")
                || (tbBroj17.Text == "34") || (tbBroj17.Text == "41") || (tbBroj17.Text == "48"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj17.Text == "7") || (tbBroj17.Text == "14") || (tbBroj17.Text == "21") || (tbBroj17.Text == "28")
                || (tbBroj17.Text == "35") || (tbBroj17.Text == "42") || (tbBroj17.Text == "49"))
            {
                eBroj17.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj17.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer16_Tick(object sender, EventArgs e)
        {
            tbBroj16.Text = Convert.ToString(lstBrojevi.Items[15]);
            if ((tbBroj16.Text == "1") || (tbBroj16.Text == "8") || (tbBroj16.Text == "15") || (tbBroj16.Text == "22")
                || (tbBroj16.Text == "29") || (tbBroj16.Text == "36") || (tbBroj16.Text == "43"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj16.Text == "2") || (tbBroj16.Text == "9") || (tbBroj16.Text == "16") || (tbBroj16.Text == "23")
                || (tbBroj16.Text == "30") || (tbBroj16.Text == "37") || (tbBroj16.Text == "44"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj16.Text == "3") || (tbBroj16.Text == "10") || (tbBroj16.Text == "17") || (tbBroj16.Text == "24")
                || (tbBroj16.Text == "31") || (tbBroj16.Text == "38") || (tbBroj16.Text == "45"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj16.Text == "4") || (tbBroj16.Text == "11") || (tbBroj16.Text == "18") || (tbBroj16.Text == "25")
                || (tbBroj16.Text == "32") || (tbBroj16.Text == "39") || (tbBroj16.Text == "46"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj16.Text == "5") || (tbBroj16.Text == "12") || (tbBroj16.Text == "19") || (tbBroj16.Text == "26")
                || (tbBroj16.Text == "33") || (tbBroj16.Text == "40") || (tbBroj16.Text == "47"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj16.Text == "6") || (tbBroj16.Text == "13") || (tbBroj16.Text == "20") || (tbBroj16.Text == "27")
                || (tbBroj16.Text == "34") || (tbBroj16.Text == "41") || (tbBroj16.Text == "48"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj16.Text == "7") || (tbBroj16.Text == "14") || (tbBroj16.Text == "21") || (tbBroj16.Text == "28")
                || (tbBroj16.Text == "35") || (tbBroj16.Text == "42") || (tbBroj16.Text == "49"))
            {
                eBroj16.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj16.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer15_Tick(object sender, EventArgs e)
        {
            tbBroj15.Text = Convert.ToString(lstBrojevi.Items[14]);
            if ((tbBroj15.Text == "1") || (tbBroj15.Text == "8") || (tbBroj15.Text == "15") || (tbBroj15.Text == "22")
                || (tbBroj15.Text == "29") || (tbBroj15.Text == "36") || (tbBroj15.Text == "43"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj15.Text == "2") || (tbBroj15.Text == "9") || (tbBroj15.Text == "16") || (tbBroj15.Text == "23")
                || (tbBroj15.Text == "30") || (tbBroj15.Text == "37") || (tbBroj15.Text == "44"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj15.Text == "3") || (tbBroj15.Text == "10") || (tbBroj15.Text == "17") || (tbBroj15.Text == "24")
                || (tbBroj15.Text == "31") || (tbBroj15.Text == "38") || (tbBroj15.Text == "45"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj15.Text == "4") || (tbBroj15.Text == "11") || (tbBroj15.Text == "18") || (tbBroj15.Text == "25")
                || (tbBroj15.Text == "32") || (tbBroj15.Text == "39") || (tbBroj15.Text == "46"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj15.Text == "5") || (tbBroj15.Text == "12") || (tbBroj15.Text == "19") || (tbBroj15.Text == "26")
                || (tbBroj15.Text == "33") || (tbBroj15.Text == "40") || (tbBroj15.Text == "47"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj15.Text == "6") || (tbBroj15.Text == "13") || (tbBroj15.Text == "20") || (tbBroj15.Text == "27")
                || (tbBroj15.Text == "34") || (tbBroj15.Text == "41") || (tbBroj15.Text == "48"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj15.Text == "7") || (tbBroj15.Text == "14") || (tbBroj15.Text == "21") || (tbBroj15.Text == "28")
                || (tbBroj15.Text == "35") || (tbBroj15.Text == "42") || (tbBroj15.Text == "49"))
            {
                eBroj15.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj15.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer14_Tick(object sender, EventArgs e)
        {
            tbBroj14.Text = Convert.ToString(lstBrojevi.Items[13]);
            if ((tbBroj14.Text == "1") || (tbBroj14.Text == "8") || (tbBroj14.Text == "15") || (tbBroj14.Text == "22")
                || (tbBroj14.Text == "29") || (tbBroj14.Text == "36") || (tbBroj14.Text == "43"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj14.Text == "2") || (tbBroj14.Text == "9") || (tbBroj14.Text == "16") || (tbBroj14.Text == "23")
                || (tbBroj14.Text == "30") || (tbBroj14.Text == "37") || (tbBroj14.Text == "44"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj14.Text == "3") || (tbBroj14.Text == "10") || (tbBroj14.Text == "17") || (tbBroj14.Text == "24")
                || (tbBroj14.Text == "31") || (tbBroj14.Text == "38") || (tbBroj14.Text == "45"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj14.Text == "4") || (tbBroj14.Text == "11") || (tbBroj14.Text == "18") || (tbBroj14.Text == "25")
                || (tbBroj14.Text == "32") || (tbBroj14.Text == "39") || (tbBroj14.Text == "46"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj14.Text == "5") || (tbBroj14.Text == "12") || (tbBroj14.Text == "19") || (tbBroj14.Text == "26")
                || (tbBroj14.Text == "33") || (tbBroj14.Text == "40") || (tbBroj14.Text == "47"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj14.Text == "6") || (tbBroj14.Text == "13") || (tbBroj14.Text == "20") || (tbBroj14.Text == "27")
                || (tbBroj14.Text == "34") || (tbBroj14.Text == "41") || (tbBroj14.Text == "48"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj14.Text == "7") || (tbBroj14.Text == "14") || (tbBroj14.Text == "21") || (tbBroj14.Text == "28")
                || (tbBroj14.Text == "35") || (tbBroj14.Text == "42") || (tbBroj14.Text == "49"))
            {
                eBroj14.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj14.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer13_Tick(object sender, EventArgs e)
        {
            tbBroj13.Text = Convert.ToString(lstBrojevi.Items[12]);
            if ((tbBroj13.Text == "1") || (tbBroj13.Text == "8") || (tbBroj13.Text == "15") || (tbBroj13.Text == "22")
                || (tbBroj13.Text == "29") || (tbBroj13.Text == "36") || (tbBroj13.Text == "43"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj13.Text == "2") || (tbBroj13.Text == "9") || (tbBroj13.Text == "16") || (tbBroj13.Text == "23")
                || (tbBroj13.Text == "30") || (tbBroj13.Text == "37") || (tbBroj13.Text == "44"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj13.Text == "3") || (tbBroj13.Text == "10") || (tbBroj13.Text == "17") || (tbBroj13.Text == "24")
                || (tbBroj13.Text == "31") || (tbBroj13.Text == "38") || (tbBroj13.Text == "45"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj13.Text == "4") || (tbBroj13.Text == "11") || (tbBroj13.Text == "18") || (tbBroj13.Text == "25")
                || (tbBroj13.Text == "32") || (tbBroj13.Text == "39") || (tbBroj13.Text == "46"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj13.Text == "5") || (tbBroj13.Text == "12") || (tbBroj13.Text == "19") || (tbBroj13.Text == "26")
                || (tbBroj13.Text == "33") || (tbBroj13.Text == "40") || (tbBroj13.Text == "47"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj13.Text == "6") || (tbBroj13.Text == "13") || (tbBroj13.Text == "20") || (tbBroj13.Text == "27")
                || (tbBroj13.Text == "34") || (tbBroj13.Text == "41") || (tbBroj13.Text == "48"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj13.Text == "7") || (tbBroj13.Text == "14") || (tbBroj13.Text == "21") || (tbBroj13.Text == "28")
                || (tbBroj13.Text == "35") || (tbBroj13.Text == "42") || (tbBroj13.Text == "49"))
            {
                eBroj13.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj13.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer12_Tick(object sender, EventArgs e)
        {
            tbBroj12.Text = Convert.ToString(lstBrojevi.Items[11]);
            if ((tbBroj12.Text == "1") || (tbBroj12.Text == "8") || (tbBroj12.Text == "15") || (tbBroj12.Text == "22")
                || (tbBroj12.Text == "29") || (tbBroj12.Text == "36") || (tbBroj12.Text == "43"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj12.Text == "2") || (tbBroj12.Text == "9") || (tbBroj12.Text == "16") || (tbBroj12.Text == "23")
                || (tbBroj12.Text == "30") || (tbBroj12.Text == "37") || (tbBroj12.Text == "44"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj12.Text == "3") || (tbBroj12.Text == "10") || (tbBroj12.Text == "17") || (tbBroj12.Text == "24")
                || (tbBroj12.Text == "31") || (tbBroj12.Text == "38") || (tbBroj12.Text == "45"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj12.Text == "4") || (tbBroj12.Text == "11") || (tbBroj12.Text == "18") || (tbBroj12.Text == "25")
                || (tbBroj12.Text == "32") || (tbBroj12.Text == "39") || (tbBroj12.Text == "46"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj12.Text == "5") || (tbBroj12.Text == "12") || (tbBroj12.Text == "19") || (tbBroj12.Text == "26")
                || (tbBroj12.Text == "33") || (tbBroj12.Text == "40") || (tbBroj12.Text == "47"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj12.Text == "6") || (tbBroj12.Text == "13") || (tbBroj12.Text == "20") || (tbBroj12.Text == "27")
                || (tbBroj12.Text == "34") || (tbBroj12.Text == "41") || (tbBroj12.Text == "48"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj12.Text == "7") || (tbBroj12.Text == "14") || (tbBroj12.Text == "21") || (tbBroj12.Text == "28")
                || (tbBroj12.Text == "35") || (tbBroj12.Text == "42") || (tbBroj12.Text == "49"))
            {
                eBroj12.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj12.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer11_Tick(object sender, EventArgs e)
        {
            tbBroj11.Text = Convert.ToString(lstBrojevi.Items[10]);
            if ((tbBroj11.Text == "1") || (tbBroj11.Text == "8") || (tbBroj11.Text == "15") || (tbBroj11.Text == "22")
                || (tbBroj11.Text == "29") || (tbBroj11.Text == "36") || (tbBroj11.Text == "43"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj11.Text == "2") || (tbBroj11.Text == "9") || (tbBroj11.Text == "16") || (tbBroj11.Text == "23")
                || (tbBroj11.Text == "30") || (tbBroj11.Text == "37") || (tbBroj11.Text == "44"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj11.Text == "3") || (tbBroj11.Text == "10") || (tbBroj11.Text == "17") || (tbBroj11.Text == "24")
                || (tbBroj11.Text == "31") || (tbBroj11.Text == "38") || (tbBroj11.Text == "45"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj11.Text == "4") || (tbBroj11.Text == "11") || (tbBroj11.Text == "18") || (tbBroj11.Text == "25")
                || (tbBroj11.Text == "32") || (tbBroj11.Text == "39") || (tbBroj11.Text == "46"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj11.Text == "5") || (tbBroj11.Text == "12") || (tbBroj11.Text == "19") || (tbBroj11.Text == "26")
                || (tbBroj11.Text == "33") || (tbBroj11.Text == "40") || (tbBroj11.Text == "47"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj11.Text == "6") || (tbBroj11.Text == "13") || (tbBroj11.Text == "20") || (tbBroj11.Text == "27")
                || (tbBroj11.Text == "34") || (tbBroj11.Text == "41") || (tbBroj11.Text == "48"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj11.Text == "7") || (tbBroj11.Text == "14") || (tbBroj11.Text == "21") || (tbBroj11.Text == "28")
                || (tbBroj11.Text == "35") || (tbBroj11.Text == "42") || (tbBroj11.Text == "49"))
            {
                eBroj11.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj11.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer10_Tick(object sender, EventArgs e)
        {
            tbBroj10.Text = Convert.ToString(lstBrojevi.Items[9]);
            if ((tbBroj10.Text == "1") || (tbBroj10.Text == "8") || (tbBroj10.Text == "15") || (tbBroj10.Text == "22")
                || (tbBroj10.Text == "29") || (tbBroj10.Text == "36") || (tbBroj10.Text == "43"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj10.Text == "2") || (tbBroj10.Text == "9") || (tbBroj10.Text == "16") || (tbBroj10.Text == "23")
                || (tbBroj10.Text == "30") || (tbBroj10.Text == "37") || (tbBroj10.Text == "44"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj10.Text == "3") || (tbBroj10.Text == "10") || (tbBroj10.Text == "17") || (tbBroj10.Text == "24")
                || (tbBroj10.Text == "31") || (tbBroj10.Text == "38") || (tbBroj10.Text == "45"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj10.Text == "4") || (tbBroj10.Text == "11") || (tbBroj10.Text == "18") || (tbBroj10.Text == "25")
                || (tbBroj10.Text == "32") || (tbBroj10.Text == "39") || (tbBroj10.Text == "46"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj10.Text == "5") || (tbBroj10.Text == "12") || (tbBroj10.Text == "19") || (tbBroj10.Text == "26")
                || (tbBroj10.Text == "33") || (tbBroj10.Text == "40") || (tbBroj10.Text == "47"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj10.Text == "6") || (tbBroj10.Text == "13") || (tbBroj10.Text == "20") || (tbBroj10.Text == "27")
                || (tbBroj10.Text == "34") || (tbBroj10.Text == "41") || (tbBroj10.Text == "48"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj10.Text == "7") || (tbBroj10.Text == "14") || (tbBroj10.Text == "21") || (tbBroj10.Text == "28")
                || (tbBroj10.Text == "35") || (tbBroj10.Text == "42") || (tbBroj10.Text == "49"))
            {
                eBroj10.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj10.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer9_Tick(object sender, EventArgs e)
        {
            tbBroj9.Text = Convert.ToString(lstBrojevi.Items[8]);
            if ((tbBroj9.Text == "1") || (tbBroj9.Text == "8") || (tbBroj9.Text == "15") || (tbBroj9.Text == "22")
                || (tbBroj9.Text == "29") || (tbBroj9.Text == "36") || (tbBroj9.Text == "43"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj9.Text == "2") || (tbBroj9.Text == "9") || (tbBroj9.Text == "16") || (tbBroj9.Text == "23")
                || (tbBroj9.Text == "30") || (tbBroj9.Text == "37") || (tbBroj9.Text == "44"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj9.Text == "3") || (tbBroj9.Text == "10") || (tbBroj9.Text == "17") || (tbBroj9.Text == "24")
                || (tbBroj9.Text == "31") || (tbBroj9.Text == "38") || (tbBroj9.Text == "45"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj9.Text == "4") || (tbBroj9.Text == "11") || (tbBroj9.Text == "18") || (tbBroj9.Text == "25")
                || (tbBroj9.Text == "32") || (tbBroj9.Text == "39") || (tbBroj9.Text == "46"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj9.Text == "5") || (tbBroj9.Text == "12") || (tbBroj9.Text == "19") || (tbBroj9.Text == "26")
                || (tbBroj9.Text == "33") || (tbBroj9.Text == "40") || (tbBroj9.Text == "47"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj9.Text == "6") || (tbBroj9.Text == "13") || (tbBroj9.Text == "20") || (tbBroj9.Text == "27")
                || (tbBroj9.Text == "34") || (tbBroj9.Text == "41") || (tbBroj9.Text == "48"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj9.Text == "7") || (tbBroj9.Text == "14") || (tbBroj9.Text == "21") || (tbBroj9.Text == "28")
                || (tbBroj9.Text == "35") || (tbBroj9.Text == "42") || (tbBroj9.Text == "49"))
            {
                eBroj9.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj9.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer8_Tick(object sender, EventArgs e)
        {
            tbBroj8.Text = Convert.ToString(lstBrojevi.Items[7]);
            if ((tbBroj8.Text == "1") || (tbBroj8.Text == "8") || (tbBroj8.Text == "15") || (tbBroj8.Text == "22")
                || (tbBroj8.Text == "29") || (tbBroj8.Text == "36") || (tbBroj8.Text == "43"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj8.Text == "2") || (tbBroj8.Text == "9") || (tbBroj8.Text == "16") || (tbBroj8.Text == "23")
                || (tbBroj8.Text == "30") || (tbBroj8.Text == "37") || (tbBroj8.Text == "44"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj8.Text == "3") || (tbBroj8.Text == "10") || (tbBroj8.Text == "17") || (tbBroj8.Text == "24")
                || (tbBroj8.Text == "31") || (tbBroj8.Text == "38") || (tbBroj8.Text == "45"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj8.Text == "4") || (tbBroj8.Text == "11") || (tbBroj8.Text == "18") || (tbBroj8.Text == "25")
                || (tbBroj8.Text == "32") || (tbBroj8.Text == "39") || (tbBroj8.Text == "46"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj8.Text == "5") || (tbBroj8.Text == "12") || (tbBroj8.Text == "19") || (tbBroj8.Text == "26")
                || (tbBroj8.Text == "33") || (tbBroj8.Text == "40") || (tbBroj8.Text == "47"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj8.Text == "6") || (tbBroj8.Text == "13") || (tbBroj8.Text == "20") || (tbBroj8.Text == "27")
                || (tbBroj8.Text == "34") || (tbBroj8.Text == "41") || (tbBroj8.Text == "48"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj8.Text == "7") || (tbBroj8.Text == "14") || (tbBroj8.Text == "21") || (tbBroj8.Text == "28")
                || (tbBroj8.Text == "35") || (tbBroj8.Text == "42") || (tbBroj8.Text == "49"))
            {
                eBroj8.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj8.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer7_Tick(object sender, EventArgs e)
        {
            tbBroj7.Text = Convert.ToString(lstBrojevi.Items[6]);
            if ((tbBroj7.Text == "1") || (tbBroj7.Text == "8") || (tbBroj7.Text == "15") || (tbBroj7.Text == "22")
                || (tbBroj7.Text == "29") || (tbBroj7.Text == "36") || (tbBroj7.Text == "43"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj7.Text == "2") || (tbBroj7.Text == "9") || (tbBroj7.Text == "16") || (tbBroj7.Text == "23")
                || (tbBroj7.Text == "30") || (tbBroj7.Text == "37") || (tbBroj7.Text == "44"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj7.Text == "3") || (tbBroj7.Text == "10") || (tbBroj7.Text == "17") || (tbBroj7.Text == "24")
                || (tbBroj7.Text == "31") || (tbBroj7.Text == "38") || (tbBroj7.Text == "45"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj7.Text == "4") || (tbBroj7.Text == "11") || (tbBroj7.Text == "18") || (tbBroj7.Text == "25")
                || (tbBroj7.Text == "32") || (tbBroj7.Text == "39") || (tbBroj7.Text == "46"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj7.Text == "5") || (tbBroj7.Text == "12") || (tbBroj7.Text == "19") || (tbBroj7.Text == "26")
                || (tbBroj7.Text == "33") || (tbBroj7.Text == "40") || (tbBroj7.Text == "47"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj7.Text == "6") || (tbBroj7.Text == "13") || (tbBroj7.Text == "20") || (tbBroj7.Text == "27")
                || (tbBroj7.Text == "34") || (tbBroj7.Text == "41") || (tbBroj7.Text == "48"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj7.Text == "7") || (tbBroj7.Text == "14") || (tbBroj7.Text == "21") || (tbBroj7.Text == "28")
                || (tbBroj7.Text == "35") || (tbBroj7.Text == "42") || (tbBroj7.Text == "49"))
            {
                eBroj7.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj7.Visibility = Visibility.Visible; ;
        }

        private void DispatcherTimer6_Tick(object sender, EventArgs e)
        {
            tbBroj6.Text = Convert.ToString(lstBrojevi.Items[5]);
            if ((tbBroj6.Text == "1") || (tbBroj6.Text == "8") || (tbBroj6.Text == "15") || (tbBroj6.Text == "22")
                || (tbBroj6.Text == "29") || (tbBroj6.Text == "36") || (tbBroj6.Text == "43"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj6.Text == "2") || (tbBroj6.Text == "9") || (tbBroj6.Text == "16") || (tbBroj6.Text == "23")
                || (tbBroj6.Text == "30") || (tbBroj6.Text == "37") || (tbBroj6.Text == "44"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj6.Text == "3") || (tbBroj6.Text == "10") || (tbBroj6.Text == "17") || (tbBroj6.Text == "24")
                || (tbBroj6.Text == "31") || (tbBroj6.Text == "38") || (tbBroj6.Text == "45"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj6.Text == "4") || (tbBroj6.Text == "11") || (tbBroj6.Text == "18") || (tbBroj6.Text == "25")
                || (tbBroj6.Text == "32") || (tbBroj6.Text == "39") || (tbBroj6.Text == "46"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj6.Text == "5") || (tbBroj6.Text == "12") || (tbBroj6.Text == "19") || (tbBroj6.Text == "26")
                || (tbBroj6.Text == "33") || (tbBroj6.Text == "40") || (tbBroj6.Text == "47"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj6.Text == "6") || (tbBroj6.Text == "13") || (tbBroj6.Text == "20") || (tbBroj6.Text == "27")
                || (tbBroj6.Text == "34") || (tbBroj6.Text == "41") || (tbBroj6.Text == "48"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj6.Text == "7") || (tbBroj6.Text == "14") || (tbBroj6.Text == "21") || (tbBroj6.Text == "28")
                || (tbBroj6.Text == "35") || (tbBroj6.Text == "42") || (tbBroj6.Text == "49"))
            {
                eBroj6.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj6.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer5_Tick(object sender, EventArgs e)
        {
            tbBroj5.Text = Convert.ToString(lstBrojevi.Items[4]);
            if ((tbBroj5.Text == "1") || (tbBroj5.Text == "8") || (tbBroj5.Text == "15") || (tbBroj5.Text == "22")
                || (tbBroj5.Text == "29") || (tbBroj5.Text == "36") || (tbBroj5.Text == "43"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj5.Text == "2") || (tbBroj5.Text == "9") || (tbBroj5.Text == "16") || (tbBroj5.Text == "23")
                || (tbBroj5.Text == "30") || (tbBroj5.Text == "37") || (tbBroj5.Text == "44"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj5.Text == "3") || (tbBroj5.Text == "10") || (tbBroj5.Text == "17") || (tbBroj5.Text == "24")
                || (tbBroj5.Text == "31") || (tbBroj5.Text == "38") || (tbBroj5.Text == "45"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj5.Text == "4") || (tbBroj5.Text == "11") || (tbBroj5.Text == "18") || (tbBroj5.Text == "25")
                || (tbBroj5.Text == "32") || (tbBroj5.Text == "39") || (tbBroj5.Text == "46"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj5.Text == "5") || (tbBroj5.Text == "12") || (tbBroj5.Text == "19") || (tbBroj5.Text == "26")
                || (tbBroj5.Text == "33") || (tbBroj5.Text == "40") || (tbBroj5.Text == "47"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj5.Text == "6") || (tbBroj5.Text == "13") || (tbBroj5.Text == "20") || (tbBroj5.Text == "27")
                || (tbBroj5.Text == "34") || (tbBroj5.Text == "41") || (tbBroj5.Text == "48"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj5.Text == "7") || (tbBroj5.Text == "14") || (tbBroj5.Text == "21") || (tbBroj5.Text == "28")
                || (tbBroj5.Text == "35") || (tbBroj5.Text == "42") || (tbBroj5.Text == "49"))
            {
                eBroj5.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj5.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer4_Tick(object sender, EventArgs e)
        {
            tbBroj4.Text = Convert.ToString(lstBrojevi.Items[3]);
            if ((tbBroj4.Text == "1") || (tbBroj4.Text == "8") || (tbBroj4.Text == "15") || (tbBroj4.Text == "22")
                || (tbBroj4.Text == "29") || (tbBroj4.Text == "36") || (tbBroj4.Text == "43"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj4.Text == "2") || (tbBroj4.Text == "9") || (tbBroj4.Text == "16") || (tbBroj4.Text == "23")
                || (tbBroj4.Text == "30") || (tbBroj4.Text == "37") || (tbBroj4.Text == "44"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj4.Text == "3") || (tbBroj4.Text == "10") || (tbBroj4.Text == "17") || (tbBroj4.Text == "24")
                || (tbBroj4.Text == "31") || (tbBroj4.Text == "38") || (tbBroj4.Text == "45"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj4.Text == "4") || (tbBroj4.Text == "11") || (tbBroj4.Text == "18") || (tbBroj4.Text == "25")
                || (tbBroj4.Text == "32") || (tbBroj4.Text == "39") || (tbBroj4.Text == "46"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj4.Text == "5") || (tbBroj4.Text == "12") || (tbBroj4.Text == "19") || (tbBroj4.Text == "26")
                || (tbBroj4.Text == "33") || (tbBroj4.Text == "40") || (tbBroj4.Text == "47"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj4.Text == "6") || (tbBroj4.Text == "13") || (tbBroj4.Text == "20") || (tbBroj4.Text == "27")
                || (tbBroj4.Text == "34") || (tbBroj4.Text == "41") || (tbBroj4.Text == "48"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj4.Text == "7") || (tbBroj4.Text == "14") || (tbBroj4.Text == "21") || (tbBroj4.Text == "28")
                || (tbBroj4.Text == "35") || (tbBroj4.Text == "42") || (tbBroj4.Text == "49"))
            {
                eBroj4.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj4.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer3_Tick(object sender, EventArgs e)
        {
            tbBroj3.Text = Convert.ToString(lstBrojevi.Items[2]);
            if ((tbBroj3.Text == "1") || (tbBroj3.Text == "8") || (tbBroj3.Text == "15") || (tbBroj3.Text == "22")
                || (tbBroj3.Text == "29") || (tbBroj3.Text == "36") || (tbBroj3.Text == "43"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj3.Text == "2") || (tbBroj3.Text == "9") || (tbBroj3.Text == "16") || (tbBroj3.Text == "23")
                || (tbBroj3.Text == "30") || (tbBroj2.Text == "37") || (tbBroj3.Text == "44"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj3.Text == "3") || (tbBroj3.Text == "10") || (tbBroj3.Text == "17") || (tbBroj3.Text == "24")
                || (tbBroj3.Text == "31") || (tbBroj3.Text == "38") || (tbBroj3.Text == "45"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj3.Text == "4") || (tbBroj3.Text == "11") || (tbBroj3.Text == "18") || (tbBroj3.Text == "25")
                || (tbBroj3.Text == "32") || (tbBroj3.Text == "39") || (tbBroj3.Text == "46"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj3.Text == "5") || (tbBroj3.Text == "12") || (tbBroj3.Text == "19") || (tbBroj3.Text == "26")
                || (tbBroj3.Text == "33") || (tbBroj3.Text == "40") || (tbBroj3.Text == "47"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj3.Text == "6") || (tbBroj3.Text == "13") || (tbBroj3.Text == "20") || (tbBroj3.Text == "27")
                || (tbBroj3.Text == "34") || (tbBroj3.Text == "41") || (tbBroj3.Text == "48"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj3.Text == "7") || (tbBroj3.Text == "14") || (tbBroj3.Text == "21") || (tbBroj3.Text == "28")
                || (tbBroj3.Text == "35") || (tbBroj3.Text == "42") || (tbBroj3.Text == "49"))
            {
                eBroj3.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj3.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer2_Tick(object sender, EventArgs e)
        {
            tbBroj2.Text = Convert.ToString(lstBrojevi.Items[1]);
            if ((tbBroj2.Text == "1") || (tbBroj2.Text == "8") || (tbBroj2.Text == "15") || (tbBroj2.Text == "22")
                || (tbBroj2.Text == "29") || (tbBroj2.Text == "36") || (tbBroj2.Text == "43"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if ((tbBroj2.Text == "2") || (tbBroj2.Text == "9") || (tbBroj2.Text == "16") || (tbBroj2.Text == "23")
                || (tbBroj2.Text == "30") || (tbBroj2.Text == "37") || (tbBroj2.Text == "44"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj2.Text == "3") || (tbBroj2.Text == "10") || (tbBroj2.Text == "17") || (tbBroj2.Text == "24")
                || (tbBroj2.Text == "31") || (tbBroj2.Text == "38") || (tbBroj2.Text == "45"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj2.Text == "4") || (tbBroj2.Text == "11") || (tbBroj1.Text == "18") || (tbBroj2.Text == "25")
                || (tbBroj2.Text == "32") || (tbBroj2.Text == "39") || (tbBroj2.Text == "46"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj2.Text == "5") || (tbBroj2.Text == "12") || (tbBroj2.Text == "19") || (tbBroj2.Text == "26")
                || (tbBroj2.Text == "33") || (tbBroj2.Text == "40") || (tbBroj2.Text == "47"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj2.Text == "6") || (tbBroj2.Text == "13") || (tbBroj2.Text == "20") || (tbBroj2.Text == "27")
                || (tbBroj2.Text == "34") || (tbBroj2.Text == "41") || (tbBroj2.Text == "48"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj2.Text == "7") || (tbBroj2.Text == "14") || (tbBroj2.Text == "21") || (tbBroj2.Text == "28")
                || (tbBroj2.Text == "35") || (tbBroj2.Text == "42") || (tbBroj2.Text == "49"))
            {
                eBroj2.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj2.Visibility = Visibility.Visible;
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            tbBroj1.Text = Convert.ToString(lstBrojevi.Items[0]);
            if((tbBroj1.Text == "1") || (tbBroj1.Text=="8") || (tbBroj1.Text == "15") || (tbBroj1.Text == "22")
                || (tbBroj1.Text == "29") || (tbBroj1.Text == "36") || (tbBroj1.Text == "43"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if((tbBroj1.Text == "2") || (tbBroj1.Text=="9") || (tbBroj1.Text == "16") || (tbBroj1.Text == "23")
                || (tbBroj1.Text == "30") || (tbBroj1.Text == "37") || (tbBroj1.Text == "44"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Yellow);
            }
            else if ((tbBroj1.Text == "3") || (tbBroj1.Text == "10") || (tbBroj1.Text == "17") || (tbBroj1.Text == "24")
                || (tbBroj1.Text == "31") || (tbBroj1.Text == "38") || (tbBroj1.Text == "45"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if ((tbBroj1.Text == "4") || (tbBroj1.Text == "11") || (tbBroj1.Text == "18") || (tbBroj1.Text == "25")
                || (tbBroj1.Text == "32") || (tbBroj1.Text == "39") || (tbBroj1.Text == "46"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Orange);
            }
            else if ((tbBroj1.Text == "5") || (tbBroj1.Text == "12") || (tbBroj1.Text == "19") || (tbBroj1.Text == "26")
                || (tbBroj1.Text == "33") || (tbBroj1.Text == "40") || (tbBroj1.Text == "47"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Green);
            }
            else if ((tbBroj1.Text == "6") || (tbBroj1.Text == "13") || (tbBroj1.Text == "20") || (tbBroj1.Text == "27")
                || (tbBroj1.Text == "34") || (tbBroj1.Text == "41") || (tbBroj1.Text == "48"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Brown);
            }
            else if ((tbBroj1.Text == "7") || (tbBroj1.Text == "14") || (tbBroj1.Text == "21") || (tbBroj1.Text == "28")
                || (tbBroj1.Text == "35") || (tbBroj1.Text == "42") || (tbBroj1.Text == "49"))
            {
                eBroj1.Stroke = new SolidColorBrush(Colors.Purple);
            }
            tbBroj1.Visibility = Visibility.Visible;
        }

        private void pocniIzvlacenje()
        {
            lstBrojevi.Items.Clear();
            Random slucajni = new Random();
            List<int> listaBrojeva = new List<int>();
            int broj;
            
            for (int i = 1; i < 36; i++)
            {
                do
                {
                    broj = slucajni.Next(1, 49);
                }
                while (listaBrojeva.Contains(broj));
                {
                    listaBrojeva.Add(broj);
                    lstBrojevi.Items.Add(broj);
                }
            }

            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            imgLoptica.Visibility = Visibility.Visible;
            dispatcherTimer.Start();

            dispatcherTimer2.Tick += DispatcherTimer2_Tick;
            dispatcherTimer2.Interval = new TimeSpan(0, 0, 6);
            imgLoptica.Visibility = Visibility.Collapsed;
            dispatcherTimer2.Start();

            dispatcherTimer3.Tick += DispatcherTimer3_Tick;
            dispatcherTimer3.Interval = new TimeSpan(0, 0, 9);
            dispatcherTimer3.Start();

            dispatcherTimer4.Tick += DispatcherTimer4_Tick;
            dispatcherTimer4.Interval = new TimeSpan(0, 0, 12);
            dispatcherTimer4.Start();

            dispatcherTimer5.Tick += DispatcherTimer5_Tick;
            dispatcherTimer5.Interval = new TimeSpan(0, 0, 15);
            dispatcherTimer5.Start();

            dispatcherTimer6.Tick += DispatcherTimer6_Tick;
            dispatcherTimer6.Interval = new TimeSpan(0, 0, 18);
            dispatcherTimer6.Start();

            dispatcherTimer7.Tick += DispatcherTimer7_Tick;
            dispatcherTimer7.Interval = new TimeSpan(0, 0, 21);
            dispatcherTimer7.Start();

            dispatcherTimer8.Tick += DispatcherTimer8_Tick;
            dispatcherTimer8.Interval = new TimeSpan(0, 0, 24);
            dispatcherTimer8.Start();

            dispatcherTimer9.Tick += DispatcherTimer9_Tick;
            dispatcherTimer9.Interval = new TimeSpan(0, 0, 27);
            dispatcherTimer9.Start();

            dispatcherTimer10.Tick += DispatcherTimer10_Tick;
            dispatcherTimer10.Interval = new TimeSpan(0, 0, 30);
            dispatcherTimer10.Start();

            dispatcherTimer11.Tick += DispatcherTimer11_Tick;
            dispatcherTimer11.Interval = new TimeSpan(0, 0, 33);
            dispatcherTimer11.Start();

            dispatcherTimer12.Tick += DispatcherTimer12_Tick;
            dispatcherTimer12.Interval = new TimeSpan(0, 0, 36);
            dispatcherTimer12.Start();

            dispatcherTimer13.Tick += DispatcherTimer13_Tick;
            dispatcherTimer13.Interval = new TimeSpan(0, 0, 39);
            dispatcherTimer13.Start();

            dispatcherTimer14.Tick += DispatcherTimer14_Tick;
            dispatcherTimer14.Interval = new TimeSpan(0, 0, 42);
            dispatcherTimer14.Start();

            dispatcherTimer15.Tick += DispatcherTimer15_Tick;
            dispatcherTimer15.Interval = new TimeSpan(0, 0, 45);
            dispatcherTimer15.Start();

            dispatcherTimer16.Tick += DispatcherTimer16_Tick;
            dispatcherTimer16.Interval = new TimeSpan(0, 0, 48);
            dispatcherTimer16.Start();

            dispatcherTimer17.Tick += DispatcherTimer17_Tick;
            dispatcherTimer17.Interval = new TimeSpan(0, 0, 51);
            dispatcherTimer17.Start();

            dispatcherTimer18.Tick += DispatcherTimer18_Tick;
            dispatcherTimer18.Interval = new TimeSpan(0, 0, 54);
            dispatcherTimer18.Start();

            dispatcherTimer19.Tick += DispatcherTimer19_Tick;
            dispatcherTimer19.Interval = new TimeSpan(0, 0, 57);
            dispatcherTimer19.Start();

            dispatcherTimer20.Tick += DispatcherTimer20_Tick;
            dispatcherTimer20.Interval = new TimeSpan(0, 0, 60);
            dispatcherTimer20.Start();

            dispatcherTimer21.Tick += DispatcherTimer21_Tick;
            dispatcherTimer21.Interval = new TimeSpan(0, 0, 63);
            dispatcherTimer21.Start();

            dispatcherTimer22.Tick += DispatcherTimer22_Tick;
            dispatcherTimer22.Interval = new TimeSpan(0, 0, 66);
            dispatcherTimer22.Start();

            dispatcherTimer23.Tick += DispatcherTimer23_Tick;
            dispatcherTimer23.Interval = new TimeSpan(0, 0, 69);
            dispatcherTimer23.Start();

            dispatcherTimer24.Tick += DispatcherTimer24_Tick;
            dispatcherTimer24.Interval = new TimeSpan(0, 0, 72);
            dispatcherTimer24.Start();

            dispatcherTimer25.Tick += DispatcherTimer25_Tick;
            dispatcherTimer25.Interval = new TimeSpan(0, 0, 75);
            dispatcherTimer25.Start();

            dispatcherTimer26.Tick += DispatcherTimer26_Tick;
            dispatcherTimer26.Interval = new TimeSpan(0, 0, 78);
            dispatcherTimer26.Start();

            dispatcherTimer27.Tick += DispatcherTimer27_Tick;
            dispatcherTimer27.Interval = new TimeSpan(0, 0, 81);
            dispatcherTimer27.Start();

            dispatcherTimer28.Tick += DispatcherTimer28_Tick;
            dispatcherTimer28.Interval = new TimeSpan(0, 0, 84);
            dispatcherTimer28.Start();

            dispatcherTimer29.Tick += DispatcherTimer29_Tick;
            dispatcherTimer29.Interval = new TimeSpan(0, 0, 87);
            dispatcherTimer29.Start();

            dispatcherTimer30.Tick += DispatcherTimer30_Tick;
            dispatcherTimer30.Interval = new TimeSpan(0, 0, 90);
            dispatcherTimer30.Start();

            dispatcherTimer31.Tick += DispatcherTimer31_Tick;
            dispatcherTimer31.Interval = new TimeSpan(0, 0, 93);
            dispatcherTimer31.Start();

            dispatcherTimer32.Tick += DispatcherTimer32_Tick;
            dispatcherTimer32.Interval = new TimeSpan(0, 0, 96);
            dispatcherTimer32.Start();

            dispatcherTimer33.Tick += DispatcherTimer33_Tick;
            dispatcherTimer33.Interval = new TimeSpan(0, 0, 99);
            dispatcherTimer33.Start();

            dispatcherTimer34.Tick += DispatcherTimer34_Tick;
            dispatcherTimer34.Interval = new TimeSpan(0, 0, 102);
            dispatcherTimer34.Start();

            dispatcherTimer35.Tick += DispatcherTimer35_Tick;
            dispatcherTimer35.Interval = new TimeSpan(0, 0, 105);
            dispatcherTimer35.Start();

            dispatcherTimer36.Tick += DispatcherTimer36_Tick;
            dispatcherTimer36.Interval = new TimeSpan(0, 0, 106);
            dispatcherTimer36.Start();
        }


        private void obrisiStareBrojeve()
        {
            tbBroj1.Visibility = Visibility.Hidden;
            tbBroj2.Visibility = Visibility.Hidden;
            tbBroj3.Visibility = Visibility.Hidden;
            tbBroj4.Visibility = Visibility.Hidden;
            tbBroj5.Visibility = Visibility.Hidden;
            tbBroj6.Visibility = Visibility.Hidden;
            tbBroj7.Visibility = Visibility.Hidden;
            tbBroj8.Visibility = Visibility.Hidden;
            tbBroj9.Visibility = Visibility.Hidden;
            tbBroj10.Visibility = Visibility.Hidden;
            tbBroj11.Visibility = Visibility.Hidden;
            tbBroj12.Visibility = Visibility.Hidden;
            tbBroj13.Visibility = Visibility.Hidden;
            tbBroj14.Visibility = Visibility.Hidden;
            tbBroj15.Visibility = Visibility.Hidden;
            tbBroj16.Visibility = Visibility.Hidden;
            tbBroj17.Visibility = Visibility.Hidden;
            tbBroj18.Visibility = Visibility.Hidden;
            tbBroj19.Visibility = Visibility.Hidden;
            tbBroj20.Visibility = Visibility.Hidden;
            tbBroj21.Visibility = Visibility.Hidden;
            tbBroj22.Visibility = Visibility.Hidden;
            tbBroj23.Visibility = Visibility.Hidden;
            tbBroj24.Visibility = Visibility.Hidden;
            tbBroj25.Visibility = Visibility.Hidden;
            tbBroj26.Visibility = Visibility.Hidden;
            tbBroj27.Visibility = Visibility.Hidden;
            tbBroj28.Visibility = Visibility.Hidden;
            tbBroj29.Visibility = Visibility.Hidden;
            tbBroj30.Visibility = Visibility.Hidden;
            tbBroj31.Visibility = Visibility.Hidden;
            tbBroj32.Visibility = Visibility.Hidden;
            tbBroj33.Visibility = Visibility.Hidden;
            tbBroj34.Visibility = Visibility.Hidden;
            tbBroj35.Visibility = Visibility.Hidden;
            eBroj1.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj2.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj3.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj4.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj5.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj6.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj7.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj8.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj9.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj10.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj11.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj12.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj13.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj14.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj15.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj16.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj17.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj18.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj19.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj20.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj21.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj22.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj23.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj24.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj25.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj26.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj27.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj28.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj29.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj30.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj31.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj32.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj33.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj34.Stroke = new SolidColorBrush(Colors.Gray);
            eBroj35.Stroke = new SolidColorBrush(Colors.Gray);
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MessageBox.Show("Počinje izvlačenje, srećno!", "Obavještenje", MessageBoxButton.OK, MessageBoxImage.Information);
                obrisiStareBrojeve();
                pocniIzvlacenje();
            }
            if (e.Key == Key.F2)
            {
                
                MessageBox.Show("Počinje izvlačenje, srećno!", "Obavještenje", MessageBoxButton.OK, MessageBoxImage.Information);
                obrisiStareBrojeve();
                pocniIzvlacenje();
            }
        }

    }
}
