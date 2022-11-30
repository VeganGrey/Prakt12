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
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using LibraryPoPrikoly;
using System.Windows.Diagnostics;

namespace Prakt12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        rabotka rab = new rabotka();
        public MainWindow()
        {
            InitializeComponent();
        }

        private DispatcherTimer timer;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(this.Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            time.Text = now.ToString("HH:mm:ss");
            data.Text = now.ToString("dd.MM.yyyy");
        }

        private void Treugol_Click(object sender, RoutedEventArgs e)
        {
            if(X1.Text == "" || X2.Text == "" || X3.Text == "" || Y1.Text == "" || Y2.Text == "" || Y3.Text == "")
            {
                MessageBox.Show("Введите недостающие данные");
            }
            else
            {
                double perim;double plosh;
                Double.TryParse(X1.Text, out double x1); Double.TryParse(X2.Text, out double x2); Double.TryParse(X3.Text, out double x3);
                Double.TryParse(Y1.Text, out double y1); Double.TryParse(Y2.Text, out double y2); Double.TryParse(Y3.Text, out double y3);
                rab.PerPloshTr(x1, y1, x2, y2, x3, y3,out perim,out plosh);
                perim = Math.Round(perim,3);
                plosh = Math.Round(plosh,3);
                Perim.Text = $"{perim}";
                Plosh.Text = $"{plosh}";
            }
            X1.Focus();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            X1.Clear();X2.Clear();X3.Clear();Y1.Clear();Y2.Clear();Y3.Clear();Plosh.Clear();Perim.Clear();
            Chislo.Clear();Summa.Clear();Proizv.Clear();
        }

        private void Chisl(object sender, RoutedEventArgs e)
        {
            if(Chislo.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                Int32.TryParse(Chislo.Text, out int chis);
                if (chis < 99 || chis > 999)
                {
                    MessageBox.Show("Введите данные правильно");
                    return;
                }
                else
                {
                    Summa.Text = $"{rab.ChisloSum(chis)}";
                    Proizv.Text = $"{rab.ChisloProizv(chis)}";
                }
            }
            Chislo.Focus();
        }

        private void Spavka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калитин С.А. ИСП-31 Вариант 13\nДаны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его " +
                "периметр и площадь, используя окнолу для расстояния между двумя точками на" +
                "плоскости (см. задание 12). Для нахождения площади треугольника со сторонами a,b, c использовать окнолу Герона\n" +
                "Дано трехзначное число. Найти сумму и произведение его цифр.");
        }

        private void Support(object sender, RoutedEventArgs e)
        {
            string target = "https://t.me/Username1_1";
            System.Diagnostics.Process.Start(target);
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Datachanged_Click(object sender, TextChangedEventArgs e)
        {
            Summa.Clear(); Proizv.Clear();
        }

        private void Text_Changed(object sender, TextChangedEventArgs e)
        {
            Perim.Clear();Plosh.Clear();
        }
    }
}
