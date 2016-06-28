// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.ServiceModel;

namespace InheritanceDemo
{
   class MyClient
   {
      static void Main(string[] args)
      {
         int result;

         SimpleCalculatorClient proxy1 = new SimpleCalculatorClient();

         result = proxy1.Add(1,2);

         Console.WriteLine("1 + 2 = " + result);

         proxy1.Close();

         ScientificCalculatorClient proxy2 = new ScientificCalculatorClient();
         
         result = proxy2.Add(3,4);
         Console.WriteLine("3 + 4 = " + result);
         
         result = proxy2.Multiply(5,6);
         Console.WriteLine("5 * 6 = " + result);
         
         proxy2.Close();

         Console.ReadLine();         
      }
   }
}
