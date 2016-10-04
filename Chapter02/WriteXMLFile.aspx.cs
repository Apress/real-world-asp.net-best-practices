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
	/// Summary description for WriteXMLFile.
	/// </summary>
	public class WriteXMLFile : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection MyConnection;
		protected System.Web.UI.WebControls.Button LoadFromFileButton;
		protected System.Web.UI.WebControls.DataGrid ResultGrid;
		protected System.Web.UI.WebControls.Button WriteXMLButton;
	
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
			this.MyConnection = new System.Data.SqlClient.SqlConnection();
			this.WriteXMLButton.Click += new System.EventHandler(this.WriteXMLButton_Click);
			// 
			// MyConnection
			// 
			this.MyConnection.ConnectionString = "data source=ILM-DEVELOP1\\ILM_DEVELOP1;initial catalog=DataSetTest;password=\"\";per" +
				"sist security info=True;user id=sa;workstation id=ILM-DEVELOP1;packet size=4096";
			this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void WriteXMLButton_Click(object sender, System.EventArgs e)
		{
			string XmlFileName;
			SqlCommand MyCommand = new SqlCommand();
			MyCommand.Connection = MyConnection;
			MyCommand.CommandText = " select * from files ";

			SqlDataAdapter MyAdapter = new SqlDataAdapter();
			MyAdapter.SelectCommand = MyCommand;

			DataSet MyFastDataSet = new DataSet();

			MyCommand.Connection.Open();

			MyAdapter.Fill(MyFastDataSet, "Files");

			MyCommand.CommandText = " select Distinct DirectoryName from Files ";
			MyAdapter.Fill(MyFastDataSet, "Directories");

			DataColumn ParentColumn = MyFastDataSet.Tables["Directories"].Columns["DirectoryName"];
			DataColumn ChildColumn = MyFastDataSet.Tables["Files"].Columns["DirectoryName"];
			MyFastDataSet.Relations.Add("Directory_File_Relation", ParentColumn, ChildColumn);
										

			MyConnection.Close();
			MyAdapter.SelectCommand.Dispose();
			MyAdapter.Dispose();

			XmlFileName = Request.MapPath("CacheFile/MyFastDataSet.xml");
			MyFastDataSet.WriteXml(XmlFileName, XmlWriteMode.WriteSchema);

			MyFastDataSet.Dispose();
		}

		private void LoadFromFileButton_Click(object sender, System.EventArgs e)
		{
			string XmlFileName = Request.MapPath("CacheFile/MyFastDataSet.xml");

			DataSet MyFastDataSet = new DataSet();

			MyFastDataSet.ReadXml(XmlFileName, XmlReadMode.ReadSchema);

			lock(Cache)
			{
				Cache["Result"] = MyFastDataSet;
			}


			DataView MyDataView = new DataView(MyFastDataSet.Tables[0]);
			MyDataView.RowFilter = " DirectoryName = 'Debug'";
			ResultGrid.DataSource = MyDataView;
			ResultGrid.DataBind();
		}
	}
}
