using System;

class HotelMenu
{
    static void Main()
    {
        int choice, qty;
        int grandTotal = 0;
        char more = 'y';

        
        int teaQty = 0, coffeeQty = 0, sandwichQty = 0, pizzaQty = 0, vadapauQty = 0;

        do
        {
            Console.WriteLine("\n----------- MENU LIST -----------");
            Console.WriteLine("1. Tea        - 20");
            Console.WriteLine("2. Coffee     - 30");
            Console.WriteLine("3. Sandwich   - 50");
            Console.WriteLine("4. Pizza      - 120");
            Console.WriteLine("5. Vadapau    - 20");
            Console.WriteLine("--------------------------------");

            Console.Write("Select item number: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    teaQty += qty;
                    grandTotal += 20 * qty;
                    break;

                case 2:
                    coffeeQty += qty;
                    grandTotal += 30 * qty;
                    break;

                case 3:
                    sandwichQty += qty;
                    grandTotal += 50 * qty;
                    break;

                case 4:
                    pizzaQty += qty;
                    grandTotal += 120 * qty;
                    break;

                case 5:
                    vadapauQty += qty;
                    grandTotal += 20 * qty;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    continue;
            }

            Console.Write("\nDo you want to order more items? (y/n): ");
            more = Convert.ToChar(Console.ReadLine());

        } while (more == 'y' || more == 'Y');

        
        Console.WriteLine("\n----------- FINAL BILL -----------");

        if (teaQty > 0)
            Console.WriteLine("Tea        x " + teaQty + " = " + (teaQty * 20));

        if (coffeeQty > 0)
            Console.WriteLine("Coffee     x " + coffeeQty + " = " + (coffeeQty * 30));

        if (sandwichQty > 0)
            Console.WriteLine("Sandwich   x " + sandwichQty + " = " + (sandwichQty * 50));

        if (pizzaQty > 0)
            Console.WriteLine("Pizza      x " + pizzaQty + " = " + (pizzaQty * 120));

        if (vadapauQty > 0)
            Console.WriteLine("Vadapau    x " + vadapauQty + " = " + (vadapauQty * 20));

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Total Amount: " + grandTotal);
        Console.WriteLine("\nTHANK YOU FOR ORDERING");
    }
}
