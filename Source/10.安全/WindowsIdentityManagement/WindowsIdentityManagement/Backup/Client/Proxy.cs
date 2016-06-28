// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.ServiceModel;
using System.ServiceModel.Channels;


[ServiceContract]
public interface IMyContract
{
   [OperationContract]
   void MyMethod();
}

public partial class MyContractClient : ClientBase<IMyContract>,IMyContract
{
   public MyContractClient()
   {}

   public MyContractClient(string configurationName) : base(configurationName)
   {}
   
   public void MyMethod()
   {
      Channel.MyMethod();
   }
}
