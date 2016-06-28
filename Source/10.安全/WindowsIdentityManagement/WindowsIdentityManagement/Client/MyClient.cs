// ?2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceModel;
using System.Net;
using System.Security.Principal;

namespace Client
{
   public partial class MyClient : Form
   {
      public MyClient()
      {
         InitializeComponent();
      }
      TokenImpersonationLevel ImpersonationLevel
      {
         get
         {
            if(m_NoneRadioButton.Checked)
            {
               return TokenImpersonationLevel.None;
            }
            if(m_AnonymousRadioButton.Checked)
            {
               return TokenImpersonationLevel.Anonymous;
            }
            if(m_IdentificationRadioButton.Checked)
            {
               return TokenImpersonationLevel.Identification;
            }

            if(m_ImpersonationRadioButton.Checked)
            {
               return TokenImpersonationLevel.Impersonation;
            }

            if(m_DelegationRadioButton.Checked)
            {
               return TokenImpersonationLevel.Delegation;
            }
            throw new InvalidOperationException();
         }   
      }
      void OnCall(object sender,EventArgs e)
      {
         NetworkCredential credentials = new NetworkCredential();
         credentials.Domain = m_DomainTextbox.Text;
         credentials.UserName = m_UserNameTextbox.Text;
         credentials.Password = m_PasswordTextBox.Text;

         MyContractClient proxy = new MyContractClient();
         proxy.ClientCredentials.Windows.ClientCredential = credentials;
         proxy.ClientCredentials.Windows.AllowedImpersonationLevel = ImpersonationLevel;
         proxy.MyMethod();

         proxy.Close();
      }
 
   }
}



