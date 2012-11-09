using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace MyserviceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyService" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        [WebGet(UriTemplate = "", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<Usersinfo> DoWork(string constring);

    }
    [DataContract]
    public class Usersinfo
    {
        private string strUser;
        private string strAddr;

        [DataMember]
        public string username
        {
            get { return strUser; } 
            set { strUser = value; }
            }

        [DataMember]

        public string Address
        {
            get { return strAddr; }
            set { strAddr = value; }
        }
    }
}
