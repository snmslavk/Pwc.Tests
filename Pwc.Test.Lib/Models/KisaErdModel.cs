using System.Collections.Specialized;
using Pwc.Test.Lib.Interfaces;

namespace Pwc.Test.Lib.Models
{

    public class KisaErdModel : IKisaErdModel
    {
        public KisaErdModel()
        {
            form_id = "disa_search_form";
            exception_text = "";
            inn = "";
        }
        public string fio { get; set; }
        public string inn { get; set; }
        public string captcha_sid { get; set; }
        public string captcha_token { get; set; }
        public string captcha_response { get; set; }
        public string captcha_url { get; set; }
        public string form_build_id { get; set; }
        public string form_id { get; set; }

        public string exception_text { get; set; }

        public NameValueCollection ToNameValueCollection()
        {
            return new NameValueCollection()
                {
                    { "fio", fio},
                    { "iin", inn},
                    { "captcha_sid", captcha_sid},
                    { "captcha_token", captcha_token},
                    { "captcha_response", captcha_response},
                    { "form_build_id", form_build_id},
                    { "form_id", form_id}
                };
        }


    }
}
