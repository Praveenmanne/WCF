using System;
using System.Collections.Generic;
using System.Configuration;
using WebApplication1.ServiceReference1;


namespace WebApplication1
{
    public partial class User : System.Web.UI.Page
    {
        readonly string _connection = ConfigurationManager.ConnectionStrings["WCF"].ToString();
        readonly ServiceReference1.MyServiceClient _myserv = new ServiceReference1.MyServiceClient();


        
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<Usersinfo> li = _myserv.DoWork(_connection);
            GridView1.DataSource = li;
            GridView1.DataBind();
        }
    }

}