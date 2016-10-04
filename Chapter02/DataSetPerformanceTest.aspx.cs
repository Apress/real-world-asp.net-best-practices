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
	/// Summary description for DataSetPerformanceTest.
	/// </summary>
	public class DataSetPerformanceTest : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox DirectoryTextBox;
		protected System.Web.UI.WebControls.Button DirectoryFromCacheButton;
		protected System.Web.UI.WebControls.Button DirectoryFromDBButton;
		protected System.Web.UI.WebControls.DataGrid ResultGrid;
		protected System.Data.SqlClient.SqlConnection MyConnection;
		protected System.Web.UI.WebControls.Label CacheLabel;
		protected System.Web.UI.WebControls.Label DurationLabel;
		protected System.Web.UI.WebControls.Label Label2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if (Cache["Result"] == null)
			{
				MyConnection.ConnectionString = "data source=EnterServerNameHere;initial catalog=EnterDataBaseNameHere;password=EnterPasswordHere;per" +
					"sist security info=True;user id=EnterUserIDHere;workstation id=ASPNETBestPractices;packet size=4096";
				SqlCommand MyCommand = new SqlCommand();
				MyCommand.Connection = MyConnection;
				MyCommand.CommandText = " select * from files ";

				SqlDataAdapter MyAdapter = new SqlDataAdapter();
				MyAdapter.SelectCommand = MyCommand;

				DataSet MyDataSet = new DataSet();
				DataSet MyFastDataSet = new DataSet();

				MyCommand.Connection.Open();
				MyAdapter.Fill(MyDataSet);


				MyAdapter.Fill(MyFastDataSet, "Files");

				MyCommand.CommandText = " select Distinct DirectoryName from Files ";
				MyAdapter.Fill(MyFastDataSet, "Directories");

				DataColumn ParentColumn = MyFastDataSet.Tables["Directories"].Columns["DirectoryName"];
				DataColumn ChildColumn = MyFastDataSet.Tables["Files"].Columns["DirectoryName"];
				MyFastDataSet.Relations.Add("Directory_File_Relation", ParentColumn, ChildColumn);
												

				MyConnection.Close();
				MyAdapter.SelectCommand.Dispose();
				MyAdapter.Dispose();

				Cache["Result"] = MyDataSet;
				Cache["FastResult"] = MyFastDataSet;
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
			this.MyConnection = new System.Data.SqlClient.SqlConnection();
			this.DirectoryFromDBButton.Click += new System.EventHandler(this.DirectoryFromDBButton_Click);
			this.DirectoryFromCacheButton.Click += new System.EventHandler(this.DirectoryFromCacheButton_Click);
			// 
			// MyConnection
			// 
			this.MyConnection.ConnectionString = "data source=ILM_Laptop\\SQL_Temp;initial catalog=DataSetTest;password=\"\";persist s" +
				"ecurity info=True;user id=sa;workstation id=ILM-DEVELOP1;packet size=4096";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DirectoryFromCacheButton_Click(object sender, System.EventArgs e)
		{
			if (Cache["Result"] == null)
				return;

			DateTime StartTime, EndTime;
			TimeSpan Duration;

			DataSet MyDataSet = Cache["Result"] as DataSet;

			StartTime = DateTime.Now;

			DataView MyDataView = new DataView(MyDataSet.Tables[0]);
			MyDataView.RowFilter = " DirectoryName = '" + DirectoryTextBox.Text + "' ";


			ResultGrid.DataSource = MyDataView;
			ResultGrid.DataBind();

			ResultGrid.DataSource = MyDataView;
			ResultGrid.DataBind();

			EndTime = DateTime.Now;			

			Duration = EndTime - StartTime;
			
			CacheLabel.Text = "Searched cached DataSet object";
			DurationLabel.Text = Duration.Milliseconds.ToString() + " milliseconds ";


		}

		private void DirectoryFromDBButton_Click(object sender, System.EventArgs e)
		{
			DateTime StartTime, EndTime;
			TimeSpan Duration;

			DataSet MyDataSet = new DataSet();
			SqlDataAdapter MyAdapter = new SqlDataAdapter();
			SqlCommand MyCommand = new SqlCommand();
			MyCommand.Connection = MyConnection;

			MyCommand.CommandText = " select * from files where DirectoryName = '" + 
										DirectoryTextBox.Text + "' ";

			StartTime = DateTime.Now;

			MyAdapter.SelectCommand = MyCommand;
			MyCommand.Connection.Open();

			MyAdapter.Fill(MyDataSet);

			ResultGrid.DataSource = MyDataSet.Tables[0].DefaultView;
			ResultGrid.DataBind();

			EndTime = DateTime.Now;


			MyCommand.Connection.Close();
			MyCommand.Dispose();

			Duration = EndTime - StartTime;
			
			CacheLabel.Text = "Searched SQL Server 2000 Database";
			DurationLabel.Text = Duration.Milliseconds.ToString() + " milliseconds ";

		
		}
	}
}
