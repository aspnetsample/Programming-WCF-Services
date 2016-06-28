// © 2006 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

namespace Client
{
   partial class MyClient
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise,false.</param>
      protected override void Dispose(bool disposing)
      {
         if(disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.Button callButton;
         System.Windows.Forms.Label domainLabel;
         System.Windows.Forms.Label userNameLabel;
         System.Windows.Forms.Label passwordLabel;
         System.Windows.Forms.GroupBox credentialsGroupBox;
         System.Windows.Forms.GroupBox impersonationGroupBox;
         this.m_PasswordTextBox = new System.Windows.Forms.TextBox();
         this.m_DomainTextbox = new System.Windows.Forms.TextBox();
         this.m_UserNameTextbox = new System.Windows.Forms.TextBox();
         this.m_NoneRadioButton = new System.Windows.Forms.RadioButton();
         this.m_AnonymousRadioButton = new System.Windows.Forms.RadioButton();
         this.m_IdentificationRadioButton = new System.Windows.Forms.RadioButton();
         this.m_ImpersonationRadioButton = new System.Windows.Forms.RadioButton();
         this.m_DelegationRadioButton = new System.Windows.Forms.RadioButton();
         callButton = new System.Windows.Forms.Button();
         domainLabel = new System.Windows.Forms.Label();
         userNameLabel = new System.Windows.Forms.Label();
         passwordLabel = new System.Windows.Forms.Label();
         credentialsGroupBox = new System.Windows.Forms.GroupBox();
         impersonationGroupBox = new System.Windows.Forms.GroupBox();
         credentialsGroupBox.SuspendLayout();
         impersonationGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // callButton
         // 
         callButton.Location = new System.Drawing.Point(293,28);
         callButton.Name = "callButton";
         callButton.Size = new System.Drawing.Size(75,23);
         callButton.TabIndex = 0;
         callButton.Text = "Call Service";
         callButton.Click += new System.EventHandler(this.OnCall);
         // 
         // domainLabel
         // 
         domainLabel.AutoSize = true;
         domainLabel.Location = new System.Drawing.Point(6,16);
         domainLabel.Name = "domainLabel";
         domainLabel.Size = new System.Drawing.Size(46,13);
         domainLabel.TabIndex = 1;
         domainLabel.Text = "Domain:";
         // 
         // userNameLabel
         // 
         userNameLabel.AutoSize = true;
         userNameLabel.Location = new System.Drawing.Point(6,64);
         userNameLabel.Name = "userNameLabel";
         userNameLabel.Size = new System.Drawing.Size(61,13);
         userNameLabel.TabIndex = 3;
         userNameLabel.Text = "User name:";
         // 
         // passwordLabel
         // 
         passwordLabel.AutoSize = true;
         passwordLabel.Location = new System.Drawing.Point(6,115);
         passwordLabel.Name = "passwordLabel";
         passwordLabel.Size = new System.Drawing.Size(53,13);
         passwordLabel.TabIndex = 5;
         passwordLabel.Text = "Password";
         // 
         // credentialsGroupBox
         // 
         credentialsGroupBox.Controls.Add(domainLabel);
         credentialsGroupBox.Controls.Add(this.m_PasswordTextBox);
         credentialsGroupBox.Controls.Add(this.m_DomainTextbox);
         credentialsGroupBox.Controls.Add(passwordLabel);
         credentialsGroupBox.Controls.Add(userNameLabel);
         credentialsGroupBox.Controls.Add(this.m_UserNameTextbox);
         credentialsGroupBox.Location = new System.Drawing.Point(12,22);
         credentialsGroupBox.Name = "credentialsGroupBox";
         credentialsGroupBox.Size = new System.Drawing.Size(125,168);
         credentialsGroupBox.TabIndex = 7;
         credentialsGroupBox.TabStop = false;
         credentialsGroupBox.Text = "Client Credentials";
         // 
         // m_PasswordTextBox
         // 
         this.m_PasswordTextBox.Location = new System.Drawing.Point(9,132);
         this.m_PasswordTextBox.Name = "m_PasswordTextBox";
         this.m_PasswordTextBox.PasswordChar = '*';
         this.m_PasswordTextBox.Size = new System.Drawing.Size(100,20);
         this.m_PasswordTextBox.TabIndex = 6;
         this.m_PasswordTextBox.Text = "myclient";
         // 
         // m_DomainTextbox
         // 
         this.m_DomainTextbox.Location = new System.Drawing.Point(9,33);
         this.m_DomainTextbox.Name = "m_DomainTextbox";
         this.m_DomainTextbox.Size = new System.Drawing.Size(100,20);
         this.m_DomainTextbox.TabIndex = 2;
         this.m_DomainTextbox.Text = "MYVPC";
         // 
         // m_UserNameTextbox
         // 
         this.m_UserNameTextbox.Location = new System.Drawing.Point(9,81);
         this.m_UserNameTextbox.Name = "m_UserNameTextbox";
         this.m_UserNameTextbox.Size = new System.Drawing.Size(100,20);
         this.m_UserNameTextbox.TabIndex = 4;
         this.m_UserNameTextbox.Text = "MyClient";
         // 
         // impersonationGroupBox
         // 
         impersonationGroupBox.Controls.Add(this.m_DelegationRadioButton);
         impersonationGroupBox.Controls.Add(this.m_ImpersonationRadioButton);
         impersonationGroupBox.Controls.Add(this.m_IdentificationRadioButton);
         impersonationGroupBox.Controls.Add(this.m_AnonymousRadioButton);
         impersonationGroupBox.Controls.Add(this.m_NoneRadioButton);
         impersonationGroupBox.Location = new System.Drawing.Point(143,23);
         impersonationGroupBox.Name = "impersonationGroupBox";
         impersonationGroupBox.Size = new System.Drawing.Size(137,167);
         impersonationGroupBox.TabIndex = 8;
         impersonationGroupBox.TabStop = false;
         impersonationGroupBox.Text = "Allowed Impersonation:";
         // 
         // m_NoneRadioButton
         // 
         this.m_NoneRadioButton.AutoSize = true;
         this.m_NoneRadioButton.Location = new System.Drawing.Point(6,33);
         this.m_NoneRadioButton.Name = "m_NoneRadioButton";
         this.m_NoneRadioButton.Size = new System.Drawing.Size(51,17);
         this.m_NoneRadioButton.TabIndex = 0;
         this.m_NoneRadioButton.Text = "None";
         this.m_NoneRadioButton.UseVisualStyleBackColor = true;
         // 
         // m_AnonymousRadioButton
         // 
         this.m_AnonymousRadioButton.AutoSize = true;
         this.m_AnonymousRadioButton.Location = new System.Drawing.Point(6,57);
         this.m_AnonymousRadioButton.Name = "m_AnonymousRadioButton";
         this.m_AnonymousRadioButton.Size = new System.Drawing.Size(80,17);
         this.m_AnonymousRadioButton.TabIndex = 0;
         this.m_AnonymousRadioButton.Text = "Anonymous";
         this.m_AnonymousRadioButton.UseVisualStyleBackColor = true;
         // 
         // m_IdentificationRadioButton
         // 
         this.m_IdentificationRadioButton.AutoSize = true;
         this.m_IdentificationRadioButton.Checked = true;
         this.m_IdentificationRadioButton.Location = new System.Drawing.Point(6,81);
         this.m_IdentificationRadioButton.Name = "m_IdentificationRadioButton";
         this.m_IdentificationRadioButton.Size = new System.Drawing.Size(85,17);
         this.m_IdentificationRadioButton.TabIndex = 0;
         this.m_IdentificationRadioButton.TabStop = true;
         this.m_IdentificationRadioButton.Text = "Identification";
         this.m_IdentificationRadioButton.UseVisualStyleBackColor = true;
         // 
         // m_ImpersonationRadioButton
         // 
         this.m_ImpersonationRadioButton.AutoSize = true;
         this.m_ImpersonationRadioButton.Location = new System.Drawing.Point(6,105);
         this.m_ImpersonationRadioButton.Name = "m_ImpersonationRadioButton";
         this.m_ImpersonationRadioButton.Size = new System.Drawing.Size(91,17);
         this.m_ImpersonationRadioButton.TabIndex = 0;
         this.m_ImpersonationRadioButton.Text = "Impersonation";
         this.m_ImpersonationRadioButton.UseVisualStyleBackColor = true;
         // 
         // m_DelegationRadioButton
         // 
         this.m_DelegationRadioButton.AutoSize = true;
         this.m_DelegationRadioButton.Location = new System.Drawing.Point(6,129);
         this.m_DelegationRadioButton.Name = "m_DelegationRadioButton";
         this.m_DelegationRadioButton.Size = new System.Drawing.Size(76,17);
         this.m_DelegationRadioButton.TabIndex = 0;
         this.m_DelegationRadioButton.Text = "Delegation";
         this.m_DelegationRadioButton.UseVisualStyleBackColor = true;
         // 
         // MyClient
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F,13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(380,202);
         this.Controls.Add(impersonationGroupBox);
         this.Controls.Add(credentialsGroupBox);
         this.Controls.Add(callButton);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MyClient";
         this.Text = "Identity Management Demo";
         credentialsGroupBox.ResumeLayout(false);
         credentialsGroupBox.PerformLayout();
         impersonationGroupBox.ResumeLayout(false);
         impersonationGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox m_DomainTextbox;
      private System.Windows.Forms.TextBox m_UserNameTextbox;
      private System.Windows.Forms.TextBox m_PasswordTextBox;
      private System.Windows.Forms.RadioButton m_NoneRadioButton;
      private System.Windows.Forms.RadioButton m_DelegationRadioButton;
      private System.Windows.Forms.RadioButton m_ImpersonationRadioButton;
      private System.Windows.Forms.RadioButton m_IdentificationRadioButton;
      private System.Windows.Forms.RadioButton m_AnonymousRadioButton;

   }
}

