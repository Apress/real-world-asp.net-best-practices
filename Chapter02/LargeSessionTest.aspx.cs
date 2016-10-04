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
	/// Summary description for LargeSessionTest.
	/// </summary>
	public class LargeSessionTest : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			DataSet LargeDS;

			if (Session["largedata"] == null)
			{
				LargeDS = GetLargeDS();
				Session["largedata"] = LargeDS;
			}
			else
			{
				LargeDS = Session["largedata"] as DataSet;
				DataGrid1.DataSource = LargeDS.Tables[0].DefaultView;
				DataGrid1.DataBind();
			}

		}

		public DataSet GetLargeDS()
		{
			DataSet MyDataSet = new DataSet();
			SqlDataAdapter MyAdapter = new SqlDataAdapter();

			SqlCommand MyCommand = new SqlCommand();
			MyCommand.Connection = new SqlConnection("data source=EnterServerNameHere;initial catalog=EnterDataBaseNameHere;password=EnterPasswordHere;per" +
				"sist security info=True;user id=EnterUserIDHere;workstation id=ASPNETBestPractices;packet size=4096");
			MyAdapter.SelectCommand = MyCommand;

			MyCommand.Connection.Open();

			MyCommand.CommandText = " select top 100 Orders.OrderID," + 
				" Customers.CompanyName, Employees.LastName," +  
				" Employees.FirstName, Orders.OrderDate," +
				"Orders.RequiredDate, Orders.ShippedDate" +
				" from Orders, Customers, Employees" + 
				" where Orders.CustomerID = Customers.CustomerID" + 
				" and Orders.EmployeeID = Employees.EmployeeID"; 

			MyAdapter.Fill(MyDataSet, "OrderList");

			MyCommand.Connection.Close();
			MyCommand.Connection.Dispose();
			MyCommand.Dispose();

			return MyDataSet;

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
