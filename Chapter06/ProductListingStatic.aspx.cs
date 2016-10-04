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

namespace BP_Controls
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class ProductListingStatic : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack && Request.QueryString["Category"] != null)
			{
				SqlConnection productCnn = new SqlConnection("server=(local);database=northwind;uid=nwindReader;pwd=northwind");
				SqlCommand productCmd = new SqlCommand("select * from products where categoryid = @categoryID", productCnn);
				productCmd.Parameters.Add("@categoryID", SqlDbType.Int,4);
				productCmd.Parameters["@categoryID"].Value = Request.QueryString["Category"];

				SqlDataReader productReader = null;

				productCnn.Open();
				productReader = productCmd.ExecuteReader(CommandBehavior.CloseConnection);

				DataGrid1.DataSource = productReader;

				DataBind();

				productReader.Close();

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
