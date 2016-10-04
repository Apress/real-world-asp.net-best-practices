namespace BP_Controls
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for SupportTemplates.
	/// </summary>
	public abstract class SupportTemplates : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.PlaceHolder headerContainer;
		protected System.Web.UI.WebControls.PlaceHolder footerContainer;

		protected ITemplate _footerTemplate;
		protected ITemplate _headerTemplate;

		public ITemplate FooterTemplate
		{
			get{return _footerTemplate;}
			set{_footerTemplate = value;}
		}

		public ITemplate HeaderTemplate
		{
			get{return _headerTemplate;}
			set{_headerTemplate = value;}
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Page_PreRender(object sender, System.EventArgs e)
		{
			if(_headerTemplate != null)
				_headerTemplate.InstantiateIn(headerContainer);
			
			if(_footerTemplate != null)
				_footerTemplate.InstantiateIn(footerContainer);

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
		
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);
			this.PreRender += new System.EventHandler(this.Page_PreRender);

		}
		#endregion
	}
}
