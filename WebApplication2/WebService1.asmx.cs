using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
namespace WebApplication2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection conn = null;
        string strConn = "Data Source=DESKTOP-7CSRM23\\SQLEXPRESS;Initial Catalog = \"Quản lý giáo viên đại học\"; Integrated Security = True";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<sport> HienThiMonTT()
        {
            List<sport> sport = new List<sport>();
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TheThao";
            cmd.Connection = conn;

            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                sport sp = new sport();
                sp.MaMonTT = rd.GetString(0);
                sp.TenMonTT = rd.GetString(1);
                sport.Add(sp);
            }
            return sport;
        }
    }
}
