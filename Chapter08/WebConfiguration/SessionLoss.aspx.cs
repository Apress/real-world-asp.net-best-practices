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
	/// Summary description for SessionLoss.
	/// </summary>
	public class SessionLoss : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Label Label1;
	
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
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Session["APressConfigurationValue"] = TextBox1.Text;
			Label1.Text = "Session value set";

			Cache.Insert("APressConfigurationValue",TextBox1.Text, null, DateTime.Now.AddMinutes(20), TimeSpan.Zero);
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			if(Session["APressConfigurationValue"] != null)
			{
				Label1.Text = (string)Session["APressConfigurationValue"];
			}
			else
			{
				Label1.Text = "Session value not present";
				Label1.ForeColor = System.Drawing.Color.Red;
			}

			if(Cache["APressConfigurationValue"] == null)
			{
				Label1.Text += "<br>Cache value not found";
			}
		}
	}
}
