<%@ WebHandler Language="C#" Class="MResources" %>

using System;
using System.Web;
using System.Web.Script.Serialization;
using System.IO.Compression;
using System.IO;
using GY.Security.Model;

public class MResources : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "application/json";
        string input = null;
        JavaScriptSerializer jss = new JavaScriptSerializer();
        using (GZipStream gzip = new GZipStream(context.Request.InputStream, CompressionMode.Decompress))
        {
            using (StreamReader sr = new StreamReader(gzip))
            {
                input = sr.ReadToEnd();
            }
        }
        Resources resource = jss.Deserialize<Resources>(input);

        context.Response.Write("Hello World");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}