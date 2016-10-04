namespace ASPControls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for CustomerWithout.
	/// </summary>
	public abstract class OrderWithoutLabel : System.Web.UI.UserControl
	{
		public string OrderID;
		public string LastName;
		public string FirstName;
		public string OrderDate;
		public string RequiredDate;
		public string ShippedDate;
		public string CompanyName;

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

		private void ShowData(DataRowView inputData)
		{
			OrderID = inputData["OrderID"].ToString();
			CompanyName = inputData["CompanyName"].ToString();
			LastName = inputData["LastName"].ToString();
			FirstName = inputData["FirstName"].ToString();

			DateTime OrderDateDT = Convert.ToDateTime(inputData["OrderDate"].ToString());
			DateTime RequiredDateDT = Convert.ToDateTime(inputData["RequiredDate"].ToString());
			DateTime ShippedDateDT = Convert.ToDateTime(inputData["ShippedDate"].ToString());

			OrderDate = OrderDateDT.ToString("d");
			RequiredDate = RequiredDateDT.ToString("d");
			ShippedDate = ShippedDateDT.ToString("d");

		}

	}
}
