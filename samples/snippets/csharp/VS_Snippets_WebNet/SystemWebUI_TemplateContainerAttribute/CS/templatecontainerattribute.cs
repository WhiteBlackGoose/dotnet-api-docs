//<snippet1>
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Samples.AspNet.CS.Controls
{
	[ParseChildren(true)]
	public class TemplatedFirstControl : Control, INamingContainer
	{
		private ITemplate firstTemplate;
		private string text = null;
		private Control myTemplateContainer;

		[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
		protected override void OnDataBinding(EventArgs e)
		{
			EnsureChildControls();
			base.OnDataBinding(e);
		}

		[TemplateContainer(typeof(FirstTemplateContainer))]
		public ITemplate FirstTemplate
		{
			get
			{
				return firstTemplate;
			}
			set
			{
				firstTemplate = value;
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
			}
		}

		public string DateTime
		{
			get
			{
				return System.DateTime.Now.ToLongTimeString();
			}
		}

		public Control MyTemplateContainer
		{
			get
			{
				return myTemplateContainer;
			}
		}

		[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
		protected override void CreateChildControls()
		{
			if (FirstTemplate != null)
			{
				myTemplateContainer = new FirstTemplateContainer(this);
				FirstTemplate.InstantiateIn(myTemplateContainer);
				Controls.Add(myTemplateContainer);
			}
			else
			{
				Controls.Add(new LiteralControl(Text + " " + DateTime));
			}
		}
	}

    public class FirstTemplateContainer : Control, INamingContainer
    {
      private TemplatedFirstControl parent;
      public FirstTemplateContainer(TemplatedFirstControl parent)
      {
        this.parent = parent;
      }
            
      public string Text
      {
        get
        {
          return parent.Text;
        }
      }
     
      public string DateTime
      {
        get 
        {
          return parent.DateTime;
        }
      }
    }
  }
//</snippet1>
