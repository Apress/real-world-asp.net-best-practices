namespace BP_Controls
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for ContentControl.
	/// </summary>
	public abstract class ContentControl : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Repeater Repeater1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				SqlConnection categoryCnn = new SqlConnection("server=(local);database=northwind;uid=nwindReader;pwd=northwind");
				SqlCommand categoryCmd = new SqlCommand("select categoryid as 'ID', categoryname as 'name' from categories", categoryCnn);
				SqlDataReader categoryReader = null;

				categoryCnn.Open();
				categoryReader = categoryCmd.ExecuteReader(CommandBehavior.CloseConnection);

				Repeater1.DataSource = categoryReader;

				DataBind();

				categoryReader.Close();

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
