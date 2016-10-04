namespace BP_Controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	public abstract class EventPublisher : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Button Button1;

		public event EventHandler ProcessingComplete;

		private void Page_Load(object sender, System.EventArgs e)
		{
			
		}


		protected virtual void OnProcessingComplete()
		{
			if(ProcessingComplete != null)
			{
				ProcessingComplete(this, new System.EventArgs());
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
		
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			OnProcessingComplete();
		}
	}
}
