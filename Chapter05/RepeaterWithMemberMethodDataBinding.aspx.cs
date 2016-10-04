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

namespace ASPControls
{
	/// <summary>
	/// Summary description for RepeaterWithMemberMethodDataBinding.
	/// </summary>
	public class RepeaterWithMemberMethodDataBinding : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Repeater CustomerRepeater;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			CustomerRepeater.DataSource = GetLargeDS().Tables[0].DefaultView;
			CustomerRepeater.DataBind();
		}

		public string ShowData(object Data, string ColumnName)
		{
			DataRowView inputData = Data as DataRowView;
			switch (ColumnName)
			{
				case "OrderID":
					 return inputData["OrderID"].ToString();
				case "CompanyName":
					return inputData["CompanyName"].ToString();
				case "LastName":
					return inputData["LastName"].ToString();
				case "FirstName":
					return inputData["FirstName"].ToString();
				case "OrderDate":
					DateTime OrderDate = Convert.ToDateTime(inputData["OrderDate"].ToString());					
					return OrderDate.ToString("d");
				case "RequiredDate":
					DateTime RequiredDate = Convert.ToDateTime(inputData["RequiredDate"].ToString());					
					return RequiredDate.ToString("d");
				case "ShippedDate":
					DateTime ShippedDate = Convert.ToDateTime(inputData["ShippedDate"].ToString());					
					return ShippedDate.ToString("d");
				default:
					return "";
			}
		}


		public DataSet GetLargeDS()
		{
			DataSet MyDataSet = new DataSet();
			SqlDataAdapter MyAdapter = new SqlDataAdapter();

			SqlCommand MyCommand = new SqlCommand();
			MyCommand.Connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["dsn"]);
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
