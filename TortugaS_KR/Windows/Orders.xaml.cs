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
using System.Windows.Shapes;
using TortugaS_KR.Classes;
using TortugaS_KR.BD;
using static TortugaS_KR.Classes.ClassEntities;
using static TortugaS_KR.Classes.Basket;

namespace TortugaS_KR.Windows
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();
            MessageBox.Show(Basket.dishes.ToList().Count.ToString());
            lvOrder.ItemsSource = Basket.dishes.ToList();

            SummCost();

            
        }

        public void  SummCost()
        {
            double summ = 0;

            foreach (var item in dishes)
            {
                summ += Convert.ToDouble(item.Cost.ToString());
            }

            var res = summ;

            tbCost.Text = res.ToString() + '₽';
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.ShowDialog();
            this.Close();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
           // int a = +1;
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
           // int b = -1;
        }

    }
}
