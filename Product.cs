using System;
namespace ShoppingBasket
{
	internal class Product
	{
		//input variable
		private string name;
		private double price;
		private int quantity;

		//output variable
		public double amountToPay;

		//method
		public void Start()
		{
			ReadInput();
			CalculateAmountToPay();
			PrintReceipt();
		}

		private void ReadInput()
		{
			ReadName();
			ReadPrice();
			ReadQuantity();
		}
		
		private void ReadName()
		{
			Console.WriteLine("Name of the product?");
			name = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine("Thanks " + name + "!");
		}

		private void ReadPrice()
		{
			Console.WriteLine("Price:");
			string strPrice = Console.ReadLine();
            price = double.Parse(strPrice);
            Console.WriteLine();
            Console.WriteLine("The price of " + name + " is " + price + ".");
        }

		private void ReadQuantity()
		{
			Console.WriteLine("Quantity of the product?");
			string strQuantity = Console.ReadLine();
			quantity = int.Parse(strQuantity);
			Console.WriteLine();
			Console.WriteLine("The number of this product is " + quantity + ".");
		}

		private void CalculateAmountToPay()
		{
			amountToPay = price * quantity;
		}

		private void PrintReceipt()
		{
			Console.WriteLine("***** Receipt *****");
			Console.WriteLine();

			Console.WriteLine("Product: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine();

			Console.WriteLine("Amount to pay: " + amountToPay.ToString("0.00"));
			Console.WriteLine();
			Console.WriteLine("***** Welcome back *****");
        }
	}
}

