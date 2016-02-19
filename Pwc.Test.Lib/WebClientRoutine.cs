using Pwc.Test.Lib.Models;
using Pwc.Test.Lib.Interfaces;
using System.Net;
using System.Text;

namespace Pwc.Test.Lib
{
    public class WebClientRoutine : IWebClientHelper
    {
        public string PostData(IKisaErdModel model, string url)
        {
            using (WebClient client = new WebClient())
            {
                return Encoding.UTF8.GetString(
                    client.UploadValues(url, model.ToNameValueCollection())
                    );
            }
        }

        public string GetData(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}
