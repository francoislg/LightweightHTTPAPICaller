using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightweightHTTPAPICaller {
    public class HTTPAPIConfig {
        public String httpAddress { get; private set; }
        public String apiKey { get; private set; }
        public ResponseType responseType { get; set; }

        public HTTPAPIConfig(String httpAddress) {
            this.httpAddress = httpAddress;
            this.responseType = ResponseType.JSON;
        }

        public string getResponseType() {
            switch (responseType) {
                case ResponseType.JSON:
                    return "json";
                case ResponseType.XML:
                    return "xml";
                default:
                    return "json";
            }
        }
    }
}
