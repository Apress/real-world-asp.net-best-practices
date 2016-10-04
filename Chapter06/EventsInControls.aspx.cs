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

namespace BP_Controls
{
	/// <summary>
	/// Summary description for EventsInControls.
	/// </summary>
	public class EventsInControls : System.Web.UI.Page
	{
		protected EventPublisher EventPublisher1;
		protected EventSubscriber EventSubscriber1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			EventPublisher1.ProcessingComplete += new System.EventHandler(EventSubscriber1.Processing_Complete);
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
