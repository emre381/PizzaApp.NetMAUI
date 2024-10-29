
---

# 🍕 .NET MAUI Pizza App

The .NET MAUI Pizza App is a simple mobile application that allows users to select a type of pizza, customize the crust type, add extra ingredients, and calculate the total price in real-time. This app is built using .NET MAUI, allowing it to run on both Android and iOS.

## 📋 Features

- **10 Pizza Types**: Choose from 10 popular pizza types (Margherita, Pepperoni, Veggie, BBQ Chicken, Hawaiian, and more).
- **Crust Options**: Select from three types of crusts - Thin, Thick, or Medium.
- **Extra Ingredients**: Add toppings like extra cheese, pepperoni, mushrooms, and olives.
- **Total Price Calculation**: Instantly see the total price based on selections.

## 🛠 Technology Stack

- **.NET MAUI**: Cross-platform UI framework for building native apps.
- **C#**: Main programming language used for app logic.
- **XAML**: For building the UI layout.

## 🚀 Getting Started

### Prerequisites

- **.NET MAUI**: Make sure .NET MAUI is installed on your machine. Refer to the [official .NET MAUI documentation](https://docs.microsoft.com/en-us/dotnet/maui/) for installation instructions.
- **Visual Studio 2022**: The recommended IDE for .NET MAUI development with MAUI workloads installed.

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/PizzaApp.git
    ```

2. Open the solution file (`PizzaApp.sln`) in Visual Studio 2022.

3. Build the project to restore any dependencies.

4. Run the app on your desired platform (Android, iOS, or Windows).

## 📱 Usage

1. **Select Pizza Type**: Use the Pizza Type dropdown to select a type of pizza.
2. **Choose Crust Type**: Select the crust type from the Crust Type dropdown.
3. **Add Extras**: Check the boxes for any additional ingredients (e.g., extra cheese, pepperoni).
4. **Calculate Total**: Tap the **Calculate Total** button to see the total price for your pizza order.
5. **View Total Price**: The total price will be displayed at the bottom of the screen.

## 📝 Code Structure

- `Pizza.cs`: Model class for pizza items, storing properties like `Name`, `Price`, `DoughType`, and `Extras`.
- `MainPage.xaml`: UI structure, including pickers for selecting pizza type and crust type, checkboxes for extras, and a button to calculate the total price.
- `MainPage.xaml.cs`: Contains the logic for calculating and displaying the total price based on user selections.

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`feature/new-feature`).
3. Make your changes and commit them.
4. Push to the branch and create a pull request.


