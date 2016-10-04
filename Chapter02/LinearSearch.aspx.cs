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
	/// Summary description for LinearSearch.
	/// </summary>
	public class LinearSearch : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button SelectButton;
		protected System.Web.UI.WebControls.TextBox DirectoryTextBox;
		protected System.Data.SqlClient.SqlConnection MyConnection;
		protected System.Web.UI.WebControls.Button DataViewButton;
		protected System.Web.UI.WebControls.Label DurationLabel;
	
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
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			this.DataViewButton.Click += new System.EventHandler(this.DataViewButton_Click);
			// 
			// MyConnection
			// 
			this.MyConnection.ConnectionString = "data source=ILM-DEVELOP1\\ILM_DEVELOP1;initial catalog=DataSetTest;password=\"\";per" +
				"sist security info=True;user id=sa;workstation id=ILM-DEVELOP1;packet size=4096";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void SelectButton_Click(object sender, System.EventArgs e)
		{
			DataSet MyDataSet = Cache["Result"] as DataSet;

			DateTime StartTime, EndTime;
			TimeSpan Duration;

			string Filter = "DirectoryName = '" + DirectoryTextBox.Text + "'";

			StartTime = DateTime.Now;

			DataRow[] MyResult = MyDataSet.Tables[0].Select(Filter);

			foreach (DataRow aRow in MyResult)
				Response.Write(Convert.ToString(aRow["FileName"]) + " , " +
								Convert.ToString(aRow["DirectoryName"]) + "<br>");

			EndTime = DateTime.Now;

			Duration = EndTime - StartTime;

			DurationLabel.Text = Duration.Milliseconds.ToString();
		}

		private void DataViewButton_Click(object sender, System.EventArgs e)
		{
			DataSet MyDataSet = Cache["Result"] as DataSet;

			DateTime StartTime, EndTime;
			TimeSpan Duration;

			string Filter = "DirectoryName = '" + DirectoryTextBox.Text + "'";

			StartTime = DateTime.Now;

			DataView MyView;
			if (Cache["MyView"] == null)
			{
				MyView = new DataView(MyDataSet.Tables[0]);
				Cache["MyView"] = MyView;
			}
			else
			{
				MyView = Cache["MyView"] as DataView;
			}

			MyView.RowFilter = Filter;

			foreach (DataRowView aRow in MyView)
				Response.Write(Convert.ToString(aRow["FileName"]) + " , " +
					Convert.ToString(aRow["DirectoryName"]) + "<br>");

			EndTime = DateTime.Now;

			Duration = EndTime - StartTime;

			DurationLabel.Text = Duration.Milliseconds.ToString();
		
		}
	}
}
