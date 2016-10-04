using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Text;

namespace BP_Controls
{
	[DefaultProperty("Text"), ToolboxData("<{0}:SuperTextBox runat=server></{0}:SuperTextBox>")]
	public class SuperTextBox : System.Web.UI.WebControls.WebControl
	{
		private string text;
	
		[Bindable(true), Category("Appearance"), DefaultValue("")] 
		public string Text 
		{
			get{return text;}
			set{text = value;}
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
			Page.RegisterClientScriptBlock("SuperTextBoxSupportScript", "<script src='/aspnet_client/supertextbox/1.0/supertextboxscript.js' language='javascript'></script>");
			Page.RegisterStartupScript("SuperTextBoxVersionCheck", "<script language='javascript'>if(typeof(script_version) == 'undefined' || script_version != '1.0')\nalert('Script version must be 1.0');</script>");

		}

		protected override void Render(HtmlTextWriter output)
		{
			output.AddAttribute(HtmlTextWriterAttribute.Type,"text");
			output.AddAttribute(HtmlTextWriterAttribute.Value, text);
			output.AddAttribute("OnBlur", "SetBG(this);");
			output.RenderBeginTag(HtmlTextWriterTag.Input);
			output.RenderEndTag();
		}
	}
}
