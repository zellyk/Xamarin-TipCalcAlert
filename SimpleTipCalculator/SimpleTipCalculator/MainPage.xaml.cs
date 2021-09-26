using System;
using Xamarin.Forms;

namespace SimpleTipCalculator
{
    public partial class MainPage : ContentPage
    {
        double total = 0;
        double totalTip = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void calcBill(object sender, System.EventArgs e)
        {
            try
            {
                totalTip = double.Parse(guests.Text) * double.Parse(tip.Text);
            }
            catch(Exception exp) {
                throw exp; 
            }

            totTip.Text = totalTip.ToString();

            total = double.Parse(bill.Text) + double.Parse(totTip.Text);
            totBill.Text = total.ToString();

        }

        private void clear(object sender, System.EventArgs e)
        {
            bill.Text = "";
            tip.Text = "";
            guests.Text = "";
            totBill.Text = "";
            totTip.Text = "";

        }
        async void BillPriceButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Bill Price", "Enter the bill price");
            bill.Text = result;
        }
        async void TipAmountButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Tip Amount", "Enter the desired tip amount");
            tip.Text = result;
        }
        async void GuestAmountButtonClocked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Number Of Guests", "Enter the number of guest(s)");
            guests.Text = result;
        }

    }

}