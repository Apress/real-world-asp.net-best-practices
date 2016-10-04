namespace ASPControls
{
	using System;
	using System.Collections;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for Customer.
	/// </summary>
	public abstract class OrderWithLabel : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Label OrderIDLabel;
		protected System.Web.UI.WebControls.Label LastNameLabel;
		protected System.Web.UI.WebControls.Label FirstNameLabel;
		protected System.Web.UI.WebControls.Label OrderDateLabel;
		protected System.Web.UI.WebControls.Label RequiredDateLabel;
		protected System.Web.UI.WebControls.Label ShippedDateLabel;
		protected System.Web.UI.WebControls.Label CompanyNameLabel;

		public DataRowView DataSource
		{
			set 
			{
				ShowData(value);			
			}
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			
		}

		private void ShowData(DataRowView inputData)
		{
			this.OrderIDLabel.Text = inputData["OrderID"].ToString();
			this.CompanyNameLabel.Text = inputData["CompanyName"].ToString();
			this.LastNameLabel.Text = inputData["LastName"].ToString();
			this.FirstNameLabel.Text = inputData["FirstName"].ToString();

			DateTime OrderDate = Convert.ToDateTime(inputData["OrderDate"].ToString());
			DateTime RequiredDate = Convert.ToDateTime(inputData["RequiredDate"].ToString());
			DateTime ShippedDate = Convert.ToDateTime(inputData["ShippedDate"].ToString());

			this.OrderDateLabel.Text = OrderDate.ToString("d");
			this.RequiredDateLabel.Text = RequiredDate.ToString("d");
			this.ShippedDateLabel.Text = ShippedDate.ToString("d");

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
