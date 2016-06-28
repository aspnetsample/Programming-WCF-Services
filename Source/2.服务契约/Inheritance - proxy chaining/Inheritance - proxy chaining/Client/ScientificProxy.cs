// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System.ServiceModel;

[ServiceContract]
public interface IScientificCalculator : ISimpleCalculator
{
    [OperationContract]
    int Multiply(int arg1,int arg2);
}                                                 

public partial class ScientificCalculatorClient : SimpleCalculatorClient,IScientificCalculator
{
   public ScientificCalculatorClient()
   {}

   public ScientificCalculatorClient(string endpointConfigurationName) : base(endpointConfigurationName)
   {}
   public int Multiply(int arg1,int arg2)
   {
      return Channel.Multiply(arg1,arg2);
   }
}
