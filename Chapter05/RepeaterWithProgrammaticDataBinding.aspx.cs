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
using System.Globalization;

namespace ASPControls
{
	/// <summary>
	/// Summary description for RepeaterWithProgrammaticDataBinding.
	/// </summary>
	public class RepeaterWithProgrammaticDataBinding : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Repeater CustomerRepeater;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			CustomerRepeater.DataSource = GetLargeDS().Tables[0].DefaultView;
			CustomerRepeater.DataBind();
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
			this.CustomerRepeater.ItemDataBound += new System.Web.UI.WebControls.RepeaterItemEventHandler(this.CustomerRepeater_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void CustomerRepeater_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
		{
			if (e.Item.ItemType != ListItemType.Item &&
				e.Item.ItemType != ListItemType.AlternatingItem)
				return;

			DataRowView BindedItem = e.Item.DataItem as DataRowView;

			Label OrderIDLabel = e.Item.FindControl("OrderIDLabel") as Label;
			if (OrderIDLabel != null)
				OrderIDLabel.Text = BindedItem["OrderID"].ToString();

			Label CompanyNameLabel = e.Item.FindControl("CompanyNameLabel") as Label;
			if (CompanyNameLabel != null)
				CompanyNameLabel.Text = BindedItem["CompanyName"].ToString();

			Label LastNameLabel = e.Item.FindControl("LastNameLabel") as Label;
			if (LastNameLabel != null)
				LastNameLabel.Text = BindedItem["LastName"].ToString();

			Label FirstNameLabel = e.Item.FindControl("FirstNameLabel") as Label;
			if (FirstNameLabel != null)
				FirstNameLabel.Text = BindedItem["FirstName"].ToString();

			Label OrderDateLabel = e.Item.FindControl("OrderDateLabel") as Label;
			if (OrderDateLabel != null)
			{
				DateTime OrderDate = Convert.ToDateTime(BindedItem["OrderDate"].ToString());
				OrderDateLabel.Text = OrderDate.ToString("d");
			}

			Label RequiredDateLabel = e.Item.FindControl("RequiredDateLabel") as Label;
			if (RequiredDateLabel != null)
			{
				DateTime RequiredDate = Convert.ToDateTime(BindedItem["RequiredDate"].ToString());
				RequiredDateLabel.Text = RequiredDate.ToString("d");
			}

			Label ShippedDateLabel = e.Item.FindControl("ShippedDateLabel") as Label;
			if (ShippedDateLabel != null)
			{
				DateTime ShippedDate = Convert.ToDateTime(BindedItem["ShippedDate"].ToString());
				ShippedDateLabel.Text = ShippedDate.ToString("d");
			}

		
		}
	}
}
