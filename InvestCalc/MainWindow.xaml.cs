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

namespace InvestCalc
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

        private void Amount_Box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Amount_Box.Text == "0")
            {
                Amount_Box.Text = "";
            }
            e.Handled = NumberOnly(e.Text, Amount_Box.Text);
        }

        private void Persent_Box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Persent_Box.Text == "0")
            {
                Persent_Box.Text = "";
            }
            e.Handled = NumberOnly(e.Text, Persent_Box.Text);
        }

        private void Years_Box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Years_Box.Text == "0")
            {
                Years_Box.Text = "";
            }
            e.Handled = !"0123456789".Contains(e.Text);
        }

        private bool NumberOnly(string symvol, string text)
        {
            return !"0123456789.".Contains(symvol) || (text.Contains('.') && symvol == ".");
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            if (NotEnoughInformation())
            {
                return;
            }

            Result_Box.Text = GetTextResult();
        }

        private string GetTextResult()
        {
            var sb = new StringBuilder();
            sb.AppendLine("      DATE     |  PAYMENT SUM  | BODY SUM LEFT  |");

            var months = int.Parse(Years_Box.Text) * 12;
            var date = DateTime.Parse(CalcDate_Box.Text);
            var sumBody = decimal.Parse(Amount_Box.Text);
            var sumBodyPart = sumBody / months;
            var persent = decimal.Parse(Persent_Box.Text);
            for (int i = 1; i < months + 1; i++)
            {
                var datePayment = date.AddMonths(1);
                var sumPersent = 0m;
                if (date.Year == datePayment.Year)
                {
                    sumPersent = GetSumPersent(date, datePayment, sumBody, persent);
                }
                else
                {
                    sumPersent = GetSumPersent(date, new DateTime(date.Year, 12, 31), sumBody, persent) +
                        GetSumPersent(new DateTime(datePayment.Year, 1, 1), datePayment, sumBody, persent);
                }
                sumBody -= sumBodyPart;

                sb.AppendLine(string.Format(
                    " {0} | {1,21:N} | {2,21:N} |",
                    datePayment.ToShortDateString(),
                    sumBodyPart + sumPersent,
                    sumBody));

                date = datePayment;
            }

            return sb.ToString();
        }

        private decimal GetSumPersent(DateTime dateLast, DateTime datePayment, decimal sumBody, decimal persent)
        {
                var year = datePayment.Year;
                var daysInYear = (decimal)(new DateTime(year, 12, 31) - new DateTime(year, 1, 1)).TotalDays;
                var daysPass = (decimal)(datePayment - dateLast).TotalDays;

                var sumPersent = persent * sumBody * daysPass / daysInYear / 100;
                return sumPersent;
        }

        private bool NotEnoughInformation()
        {
            if (string.IsNullOrEmpty(CalcDate_Box.Text))
            {
                MessageBox.Show("No Calculation Date");
                CalcDate_Box.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(Amount_Box.Text))
            {
                MessageBox.Show("No Amounth");
                Amount_Box.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(Persent_Box.Text))
            {
                MessageBox.Show("No Persent");
                Persent_Box.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(Years_Box.Text))
            {
                MessageBox.Show("No Years");
                Years_Box.Focus();
                return true;
            }

            return false;
        }
    }
}
