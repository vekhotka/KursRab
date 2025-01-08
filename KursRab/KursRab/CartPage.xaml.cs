using System;
using Xamarin.Forms;

namespace KursRab
{
    public partial class CartPage : ContentPage
    {
        private decimal totalAmount = 0;

        public CartPage()
        {
            InitializeComponent();
        }

        private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            decimal price = 0;

            if (checkBox == CheckBox1)
                price = 8990; 
            else if (checkBox == CheckBox2)
                price = 5600; 
            else if (checkBox == CheckBox3)
                price = 9990; 
            else if (checkBox == CheckBox4)
                price = 3600; 

            if (e.Value)
                totalAmount += price; 
            else
                totalAmount -= price; 

            TotalAmountLabel.Text = $"{totalAmount} руб."; 
        }
    }
}