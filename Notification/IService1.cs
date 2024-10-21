using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Notification
{
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        string SendNotification(Payload payload);

    }



    [DataContract]
    public class Payload
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
