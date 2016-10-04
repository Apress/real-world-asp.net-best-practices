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
	/// Summary description for WebForm1.
	/// </summary>
	public class Example1 : System.Web.UI.Page
	{
		protected System.Web.UI.HtmlControls.HtmlTable configTable;
		protected System.Web.UI.WebControls.Label appDomainID;
		protected System.Web.UI.WebControls.Label ErrorMessage;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//get configuration information
			NameValueCollection mailServers = (NameValueCollection)System.Configuration.ConfigurationSettings.GetConfig("mailServers");
			
			//make sure the configuration was retrieved
			if(mailServers != null)
			{
				for(int configIndex = 0; configIndex < mailServers.Count; configIndex++)
				{
					HtmlTableRow tr = new HtmlTableRow();
					
					HtmlTableCell td = new HtmlTableCell();
					td.InnerText = "Key: ";
					tr.Cells.Add(td);

					td= new HtmlTableCell();
					td.InnerText = mailServers.GetKey(configIndex);
					tr.Cells.Add(td);

					td = new HtmlTableCell();
					td.InnerText = "Value: ";
					tr.Cells.Add(td);


					td = new HtmlTableCell();
					td.InnerText  = mailServers.GetValues(configIndex)[0];
					tr.Cells.Add(td);

					configTable.Rows.Add(tr);

				}
			}
			else
				ErrorMessage.Visible = true;



			appDomainID.Text = AppDomain.CurrentDomain.FriendlyName;
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
