using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ReturnObject SyncData(ReturnObject ro);
    }


    [DataContract]
    public class ReturnObject
    {
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string Data { get; set; }

      
    }
}
