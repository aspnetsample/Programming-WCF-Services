// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.Windows.Forms;

namespace Client
{
   static class Program
   {
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.Run(new MyClient());
      }
   }
}