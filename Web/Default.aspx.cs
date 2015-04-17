using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sunrise;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.Log("aaaaaa");

            Debug.Log(new String[]{"bbb", "cccc", "aaa"});

            Debug.Log(new Array[] {
                new String[] { "bbb" },
                new String[] { "aaa", "ccc" },
                new String[] { "fff", "a", "hoge" }
            });

            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("foo", "bar");
            dic.Add("hoge", "kk");
            dic.Add("bom", "boom");
            dic.Add("ggg", "ccc");
            Debug.Log(dic);

            Debug.Log(new Dictionary<String, String>[] { dic, dic, dic });

            Dictionary<String, Dictionary<String, String>> dic2 = new Dictionary<string, Dictionary<string, string>>();
            dic2.Add("first", dic);
            dic2.Add("second", dic);
            dic2.Add("third", dic);
            Debug.Log(dic2);
        }
    }
}