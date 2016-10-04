using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebConfiguration
{
	/// <summary>
	/// Summary description for ConfigItemEncrypter.
	/// </summary>
	public class ConfigItemEncrypter : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox plainTextValue;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.TextBox encryptedResult;
		protected System.Web.UI.WebControls.Label ErrorMessage;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				encryptedResult.Text = APress.ASPNetBestPractices.ConfigurationSecurity.Encrypt(plainTextValue.Text, true);
			}
			catch(Exception ex)
			{
				ErrorMessage.Text = ex.Message;
				ErrorMessage.Visible = true;
			}
		}
	}
}
