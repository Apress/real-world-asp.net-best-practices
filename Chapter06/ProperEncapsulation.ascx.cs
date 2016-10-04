namespace BP_Controls
{
	using System;
	using System.Collections;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for ProperEncapsulation.
	/// </summary>
	public abstract class ProperEncapsulation : System.Web.UI.UserControl
	{

		//private variable for this control only
		private int itemCount;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;

		//public accessor for private variable (read only)
		public int ItemCount
		{
			get{return itemCount;}
		}

		//protected variable for this control and derived classes
		protected ArrayList seconds;

		private void Page_Load(object sender, System.EventArgs e)
		{
			seconds = new ArrayList(DateTime.Now.Second);
			itemCount = seconds.Capacity;

			for(int secondsIndex=1;secondsIndex<=itemCount; secondsIndex++)
			{
				seconds.Add(String.Format("00:{0:D2}", secondsIndex));
			}

			DropDownList1.DataSource = seconds;
			DataBind();
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
