// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.ServiceModel;

namespace InheritanceDemo
{
   class Program
   {
      public static void Main()
      {
         ServiceHost serviceHost = new ServiceHost(typeof(MyCalculator),new Uri("http://localhost:8000"));
         serviceHost.Open();

         Console.WriteLine("Press ENTER to shut down service.");
         Console.ReadLine();
         
         serviceHost.Close();
      }
   }
}
