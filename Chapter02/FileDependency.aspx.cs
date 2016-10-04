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
	/// Summary description for FileDependency.
	/// </summary>
	public class FileDependency : System.Web.UI.Page
	{
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void AddToCacheButton_Click(object sender, System.EventArgs e)
		{

			// Using MapPath method to convert virtual file path to 
			// physical path.
			string XmlFileName = 
				Request.MapPath("CacheFile/MyFastDataSet.xml");

			// Creating new data set object.
			DataSet MyFastDataSet = new DataSet();

			// Populating newly created data set object from XML file
			// Make sure to use ReadSchema enumeration, otherwise, 
			// the data set object will not have data types and relations.
			MyFastDataSet.ReadXml(XmlFileName, XmlReadMode.ReadSchema);


			CacheDependency MyDependency;
			CacheItemRemovedCallback onRemove;


			// Setting the dependency object to the XML file
			MyDependency = new CacheDependency(XmlFileName);

			// Creating the delegate object and assigned it the 
			// name of the method that should be called when cached 
			// data set is expired.
			onRemove = new CacheItemRemovedCallback(RemoveResultCallback);

			// Inserting the newly created data set object in cache, 
			// and assigned it the dependency, the delegate, and expiration
			// values. In this example, the cached data set will expire 
			// 24 hours after it is placed in cache.
			Cache.Insert("Result", MyFastDataSet, MyDependency, 
				DateTime.Now.AddHours(24), TimeSpan.Zero,
				CacheItemPriority.Normal, onRemove);					
				
		}

		private void RemoveResultCallback(string key, object removedObject,
			CacheItemRemovedReason removeReason)
		{
			string type = removedObject.GetType().ToString();	
		}
	}
}
