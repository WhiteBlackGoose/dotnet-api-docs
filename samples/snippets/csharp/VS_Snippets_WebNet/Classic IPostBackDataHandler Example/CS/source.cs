// <Snippet1>
using System;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Collections.Specialized;

namespace CustomWebFormsControls {

   [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
   public class MyTextBox: Control, IPostBackDataHandler {

      public string Text {
         get {
            return (string) ViewState["Text"];
         }

         set {
            ViewState["Text"] = value;
         }
      }

      public event EventHandler TextChanged;

      public virtual bool LoadPostData(string postDataKey,
         NameValueCollection postCollection) {

         string presentValue = Text;
         string postedValue = postCollection[postDataKey];

         if (presentValue == null || !presentValue.Equals(postedValue)) {
            Text = postedValue;
            return true;
         }

         return false;
      }

      public virtual void RaisePostDataChangedEvent() {
         OnTextChanged(EventArgs.Empty);
      }

      protected virtual void OnTextChanged(EventArgs e) {
         if (TextChanged != null)
            TextChanged(this,e);
      }

      protected override void Render(HtmlTextWriter output) {
         output.Write("<INPUT type= text name = "+this.UniqueID
            + " value = " + this.Text + " >");
      }
   }
}

// </Snippet1>
