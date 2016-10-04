using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.Caching;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ASPNET
{
	/// <summary>
	/// Summary description for CacheScalability.
	/// </summary>
	public class CacheScalability : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button CheckCacheButton;
		protected System.Web.UI.WebControls.Label CacheStatusLabel;
		protected System.Web.UI.WebControls.Label DurationLabel;
		protected System.Web.UI.WebControls.Button AddToCacheButton;
	
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
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.AddToCacheButton.Click += new System.EventHandler(this.AddToCacheButton_Click);
			this.CheckCacheButton.Click += new System.EventHandler(this.CheckCacheButton_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		public void AddToCacheButton_Click(object sender, System.EventArgs e)
		{
			SqlConnection MyConnection = new SqlConnection();
			MyConnection.ConnectionString = "data source=EnterServerNameHere;initial catalog=EnterDataBaseNameHere;password=EnterPasswordHere;per" +
				"sist security info=True;user id=EnterUserIDHere;workstation id=ASPNETBestPractices;packet size=4096";
			SqlCommand MyCommand = new SqlCommand();
			MyCommand.Connection = MyConnection;
			MyCommand.CommandText = " select top 20000 * from files ";

			SqlDataAdapter MyAdapter = new SqlDataAdapter();
			MyAdapter.SelectCommand = MyCommand;

			DataSet MyDataSet = new DataSet();

			MyCommand.Connection.Open();
			MyAdapter.Fill(MyDataSet);

			MyConnection.Close();
			MyAdapter.SelectCommand.Dispose();
			MyAdapter.Dispose();

			Session["Result"] = MyDataSet;

										
		}

		private void CheckCacheButton_Click(object sender, System.EventArgs e)
		{
		
			DateTime StartTime = DateTime.Now;

			if (Session["Result"] == null)
			{
				CacheStatusLabel.Text = "Cache is empty";
			}
			else
			{
				CacheStatusLabel.Text = "Cache contains desired object";
			}
			DateTime EndTime = DateTime.Now;

			TimeSpan Duration = EndTime - StartTime;
			DurationLabel.Text = Duration.Milliseconds.ToString() + " milliseconds";
		}
	}
}
