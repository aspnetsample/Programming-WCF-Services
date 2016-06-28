// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.ServiceModel;

namespace InheritanceDemo
{
   [ServiceContract]
   interface ISimpleCalculator
   {
      [OperationContract]
      int Add(int arg1,int arg2);
   }

   [ServiceContract]
   interface IScientificCalculator : ISimpleCalculator
   {
      [OperationContract]
      int Multiply(int arg1,int arg2);
   }

   class MyCalculator : IScientificCalculator
   {
      public int Add(int arg1,int arg2)
      {
         return arg1 + arg2;
      }
      public int Multiply(int arg1,int arg2)
      {
         return arg1 * arg2;
      }
   }
}
