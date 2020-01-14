using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var uri = GetCookieDomain("http://digipub.rmyd.com.cn");
        var secret = ComputeSecretCode(65);
    }

    private string GetCookieDomain(string digipubDomain)
    {
        var uri = new Uri(digipubDomain);
        var host = uri.Host;
        var domain = host.Substring(host.IndexOf('.'));
        return domain;
    }

    private Cookie CallForAuthenticationCookie(decimal id = 65, string domain = "http://localhost:56535")
    {
        var secret = ComputeSecretCode((long)id);
        var uri = new Uri(string.Format("{0}/Account/Login?id=65&code={1}", domain, secret));
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        request.CookieContainer = new CookieContainer();
        try
        {
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                // Print the properties of each cookie.
                var cookie = response.Cookies[".AspNet.ApplicationCookie"];
                var httpCookie = new HttpCookie(cookie.Name);
                httpCookie.Value = cookie.Value;
                httpCookie.Domain = cookie.Domain;
                httpCookie.Expires = DateTime.Now.AddHours(2);
                Response.AppendCookie(httpCookie);
                
                return cookie;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    private string ComputeSecretCode(long id)
    {
        var format = string.Format("{0}MyFirstDreamProject", id);
        using (var md5 = MD5.Create())
        {
            var input = Encoding.UTF8.GetBytes(format);
            var hashed = md5.ComputeHash(input);
            var sb = new StringBuilder();
            for (var x = 0; x < hashed.Length; x++)
            {
                sb.Append(hashed[x].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
    }
}