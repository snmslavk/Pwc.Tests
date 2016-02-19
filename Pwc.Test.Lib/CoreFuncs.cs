using Pwc.Test.Lib.Models;
using System;
using System.Web.Helpers;
using Pwc.Test.Lib.Interfaces;
using Pwc.Test.Lib.Factories;

namespace Pwc.Test.Lib
{
    public class CoreFuncs : ICoreFuncs
    {
        public KisaErdModel GetIndexModel()
        {
            try
            {
                var factory = new HelpersFactory();
                var dataFromWeb = factory.GetWebClientHelper().GetData(Config.UrlErdKisaGet);
                
                return factory.GetParseHtmlHelper().FillModel(dataFromWeb);
            }
            catch (Exception ee)
            {
                return new KisaErdModel
                {
                    exception_text = String.Format("An error has occurred during refreshing form elements:{0}", ee.Message)
                };
            }
        }

        public string PostData(IKisaErdModel model)
        {
            try
            {
                var factory = new HelpersFactory();
                var responceJson = factory.GetWebClientHelper().PostData(model, Config.UrlErdKisaPost);

                dynamic jsonObject = Json.Decode(responceJson);

                return factory.GetParseHtmlHelper().GetResultTable(jsonObject[1].data);
            }
            catch (Exception ee)
            {
                return String.Format("An error has occurred:{0}", ee.Message);
            }
        }

    }
}
