using System.Net;
using System.Runtime.Serialization;

namespace TodoApi
{
    [DataContract]
    public abstract class ApiResponse
    {
        [DataMember]
        public string Version { get { return "1.0.0"; } }
    }
    public class ApiResponseData(HttpStatusCode statusCode, object? data = null) : ApiResponse
    {
        [DataMember]
        public int StatusCode { get; set; } = (int)statusCode;

        [DataMember(EmitDefaultValue = true)]
        public object Data { get; set; } = data;
    }
}