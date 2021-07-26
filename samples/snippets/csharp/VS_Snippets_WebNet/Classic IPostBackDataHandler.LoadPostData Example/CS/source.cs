using System;
using System.Collections.Specialized;

public class Sample {

    protected string Text;

// <Snippet1>
 public virtual bool LoadPostData(string postDataKey,
    NameValueCollection postCollection) {

    string presentValue = Text;
    string postedValue = postCollection[postDataKey];

    if (presentValue == null || !presentValue.Equals(postedValue)){
       Text = postedValue;
       return true;
    }
    return false;
 }

// </Snippet1>
}
