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

    public class ApiResponseData : ApiResponse
    {
        public ApiResponseData(HttpStatusCode statusCode, object? data)
        {
            StatusCode = (int)statusCode;
            Data = data;
        }

        [DataMember]
        public int StatusCode { get; set; }

        [DataMember(EmitDefaultValue = true)]
        public object? Data { get; set; }
    }
}