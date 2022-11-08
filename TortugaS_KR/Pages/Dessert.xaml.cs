﻿using System;
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
using TortugaS_KR.BD;
using TortugaS_KR.Classes;

namespace TortugaS_KR.Pages
{
    /// <summary>
    /// Логика взаимодействия для Dessert.xaml
    /// </summary>
    public partial class Dessert : Page
    {
        private MenuInterface menuInteface;
        public Dessert(MenuInterface menuInterface)
        {
            InitializeComponent();
            this.menuInteface = menuInterface;

            lvDessert.ItemsSource = ClassEntities.context.Dish.Where(i => i.IdCategory == 5).ToList();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
                return;
            var dish = button.DataContext as Dish;

            Basket.dishes.Add(dish);
            menuInteface.ChangeDishCount(Basket.dishes.Count);
        }
    }
}