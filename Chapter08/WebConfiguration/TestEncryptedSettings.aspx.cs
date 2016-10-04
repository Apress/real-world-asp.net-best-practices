using System;
using System.Collections;
using System.Collections.Specialized;
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
	/// Summary description for TestEncryptedSettings.
	/// </summary>
	public class TestEncryptedSettings : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label cnnstring;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			NameValueCollection dbsettings = (NameValueCollection)System.Configuration.ConfigurationSettings.GetConfig("dbSettings");

			if(dbsettings != null)
			{
				cnnstring.Text = dbsettings["northwind"];
			}
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
