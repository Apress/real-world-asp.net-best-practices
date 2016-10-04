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
	/// Summary description for ViewState.
	/// </summary>
	public class ViewState : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.DropDownList CategoriesDropDown;
		protected System.Web.UI.WebControls.DropDownList CustomersDropDown;
		protected System.Web.UI.WebControls.DropDownList EmployeesDropDown;
		protected System.Web.UI.WebControls.DropDownList OrdersDropDown;
		protected System.Web.UI.WebControls.DropDownList ProductsDropDown;
		protected System.Web.UI.WebControls.DropDownList RegionDropDown;
		protected System.Web.UI.WebControls.DataGrid ResultGrid;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Web.UI.WebControls.Button PostBackButton;
		protected System.Web.UI.WebControls.Label Label6;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!IsPostBack)
			{
				DataSet MyDataSet;
				if (Cache["Orders"] == null)
				{
					MyDataSet = new DataSet();
					SqlDataAdapter MyAdapter = new SqlDataAdapter();

					SqlCommand MyCommand = new SqlCommand();
					MyCommand.Connection = new SqlConnection("data source=EnterServerNameHere;initial catalog=EnterDataBaseNameHere;password=EnterPasswordHere;per" +
						"sist security info=True;user id=EnterUserIDHere;workstation id=ASPNETBestPractices;packet size=4096");
					MyAdapter.SelectCommand = MyCommand;

					MyCommand.Connection.Open();

					MyCommand.CommandText = " SELECT * FROM Categories ";
					MyAdapter.Fill(MyDataSet, "Categories");

					MyCommand.CommandText = " SELECT * FROM Customers ";
					MyAdapter.Fill(MyDataSet, "Customers");

					MyCommand.CommandText = " SELECT * FROM Employees ";
					MyAdapter.Fill(MyDataSet, "Employees");

					MyCommand.CommandText = " SELECT * FROM Orders ";
					MyAdapter.Fill(MyDataSet, "Orders");

					MyCommand.CommandText = " SELECT * FROM Products ";
					MyAdapter.Fill(MyDataSet, "Products");

					MyCommand.CommandText = " SELECT * FROM Region ";
					MyAdapter.Fill(MyDataSet, "Region");

					MyCommand.CommandText = " select Orders.OrderID," + 
					" Customers.CompanyName, Employees.LastName," +  
					" Employees.FirstName, Orders.OrderDate," +
					"Orders.RequiredDate, Orders.ShippedDate" +
					" from Orders, Customers, Employees" + 
					" where Orders.CustomerID = Customers.CustomerID" + 
					" and Orders.EmployeeID = Employees.EmployeeID" + 
					" and Employees.LastName = 'King' ";

					MyAdapter.Fill(MyDataSet, "OrderList");

					MyCommand.Connection.Close();
					MyCommand.Connection.Dispose();
					MyCommand.Dispose();

					Cache["Orders"] = MyDataSet;
				}
				else
				{
					MyDataSet = Cache["Orders"] as DataSet;
				}

				CategoriesDropDown.DataSource = 
					MyDataSet.Tables["Categories"].DefaultView;
				CustomersDropDown.DataSource = MyDataSet.Tables["Customers"].DefaultView;
				EmployeesDropDown.DataSource = MyDataSet.Tables["Employees"].DefaultView;
				OrdersDropDown.DataSource = MyDataSet.Tables["Orders"].DefaultView;
				ProductsDropDown.DataSource = MyDataSet.Tables["Products"].DefaultView;
				RegionDropDown.DataSource = MyDataSet.Tables["Region"].DefaultView;
				ResultGrid.DataSource = MyDataSet.Tables["OrderList"].DefaultView;

				CategoriesDropDown.DataBind();
				CustomersDropDown.DataBind();
				EmployeesDropDown.DataBind();
				OrdersDropDown.DataBind();
				ProductsDropDown.DataBind();
				RegionDropDown.DataBind();
				ResultGrid.DataBind();

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
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.PostBackButton.Click += new System.EventHandler(this.PostBackButton_Click);
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "data source=ILM_Laptop\\SQL_Temp;initial catalog=Northwind;password=\"\";persist sec" +
				"urity info=True;user id=sa;workstation id=ILM-DEVELOP1;packet size=4096";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void PostBackButton_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
