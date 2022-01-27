using System;

namespace _3_1_Invoice_Test
{
   class InvoiceTest
   {
      static void Main()
      {
         Invoice item1 = new Invoice();

         Console.Write("\nEnter the part's number: ");
         string partNumber = (Console.ReadLine());

         Console.Write("\nEnter the part's description: ");
         string partDescription = (Console.ReadLine());

         Console.Write("\nEnter the part's quantity: ");
         string partQty = (Console.ReadLine());

         Console.Write("\nEnter the part's price: ");
         string partPrice = (Console.ReadLine());

         Console.Write($"\nPart Number: {partNumber}");
         Console.Write($"\nPart Description: {partDescription}");
         Console.Write($"\nPart Quantity: {partQty}");
         Console.Write($"\nPart Part Price: {partPrice}");
         Console.Write($"\nTotal Invoice Price: {partPrice} * {partQty}");

      }
   }
}
