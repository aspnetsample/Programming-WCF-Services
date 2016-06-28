// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net


using System.ServiceModel;


[ServiceContract]
public interface ISimpleCalculator
{
   [OperationContract]
   int Add(int arg1,int arg2);
}

public partial class SimpleCalculatorClient : ClientBase<IScientificCalculator>,ISimpleCalculator
{
   public SimpleCalculatorClient()
   {}

   public SimpleCalculatorClient(string endpointConfigurationName) : base(endpointConfigurationName)
   {}

   public int Add(int arg1,int arg2)
   {
      return Channel.Add(arg1,arg2);
   }
}
