using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace MyserviceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    public class MyService : IMyService
    {
        public List<Usersinfo> DoWork(string constring)
        {
            
            var list = new List<Usersinfo>();

            using (var con = new SqlConnection(constring))
            {
                var cmd = new SqlDataAdapter("select * from users", con);
                var ds = new DataSet();

                cmd.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        var user = new Usersinfo();
                        user.username = ds.Tables[0].Rows[i]["UserName"].ToString();
                        user.Address = ds.Tables[0].Rows[i]["Address"].ToString();
                        list.Add(user);
                    }
                }


            }
            return list;
        }
    }
}
