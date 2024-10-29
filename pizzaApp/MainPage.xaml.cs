
namespace pizzaApp
{
    public partial class MainPage : ContentPage
    {
        private List<pizza> pizzas = new List<pizza>
    {
        new pizza { Name = "Margherita", Price = 50 },
        new pizza { Name = "Pepperoni", Price = 60 },
        new pizza { Name = "Veggie", Price = 55 },
        new pizza { Name = "BBQ Chicken", Price = 65 },
        new pizza { Name = "Hawaiian", Price = 70 },
        new pizza { Name = "Meat Lovers", Price = 80 },
        new pizza { Name = "Supreme", Price = 75 },
        new pizza { Name = "Four Cheese", Price = 68 },
        new pizza { Name = "Spicy Italian", Price = 73 },
        new pizza { Name = "Tuna Delight", Price = 72 },
    };

        public MainPage()
        {
            InitializeComponent();
            pizzaPicker.ItemsSource = pizzas.Select(p => p.Name).ToList();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (pizzaPicker.SelectedIndex == -1 || doughPicker.SelectedIndex == -1)
            {
                DisplayAlert("Error", "Please select both pizza type and dough type.", "OK");
                return;
            }

            // Seçilen pizza ve fiyatını alın
            var selectedPizza = pizzas[pizzaPicker.SelectedIndex];
            double totalPrice = selectedPizza.Price;

            // Ekstra malzeme fiyatlarını ekle
            if (extraCheese.IsChecked) totalPrice += 5;
            if (pepperoni.IsChecked) totalPrice += 7;
            if (mushrooms.IsChecked) totalPrice += 4;
            if (olives.IsChecked) totalPrice += 3;

            totalPriceLabel.Text = $"Total Price: ${totalPrice}";
        }
    }

}
