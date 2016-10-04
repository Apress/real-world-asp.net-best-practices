using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ASPNET
{
	/// <summary>
	/// Summary description for OutputCaching.
	/// </summary>
	public class OutputCaching : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid ResultGrid;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			SqlCommand MyCommand = new SqlCommand();
			MyCommand.Connection = new SqlConnection("data source=EnterServerNameHere;initial catalog=EnterDataBaseNameHere;password=EnterPasswordHere;per" +
				"sist security info=True;user id=EnterUserIDHere;workstation id=ASPNETBestPractices;packet size=4096");

			MyCommand.CommandText = " select top 100 * from files ";

			SqlDataAdapter MyAdapter = new SqlDataAdapter();
			MyAdapter.SelectCommand = MyCommand;

			DataSet MyDataSet = new DataSet();

			MyCommand.Connection.Open();
			MyAdapter.Fill(MyDataSet, "Files");
			MyCommand.Connection.Close();

			MyAdapter.SelectCommand.Dispose();
			MyAdapter.Dispose();

			ResultGrid.DataSource = MyDataSet.Tables[0].DefaultView;
			ResultGrid.DataBind();
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
