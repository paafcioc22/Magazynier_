using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebAPISzacho;
using static WebAPISzacho.CDNOffLineSrvSoapClient;

namespace Magazynier.AplicationServices.API.SzachoAPI
{
    public class WebSzacho : IWebSzacho
    {

        CDNOffLineSrvSoapClient client;
        public WebSzacho()
        {
            client = new CDNOffLineSrvSoapClient(EndpointConfiguration.CDNOffLineSrvSoap12 );
        }

        

        public async Task<T> GetObject<T>(string query)
        {
                         
            var response = await client.ExecuteSQLCommandAsync(query);

            var toSigle = DeserializeFromXml<T>(response.Body.ExecuteSQLCommandResult);

            return toSigle[0];          

        }


        public async Task<IList<T>> GetList<T>(string query)
        {
            var respone =  await client.ExecuteSQLCommandAsync(query);

            return DeserializeFromXml<T>(respone.Body.ExecuteSQLCommandResult);
             
        }

        public static IList<T> DeserializeFromXml<T>(string xml)
        {
            List<T> result;             

            XmlSerializer ser = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("ROOT"));
            using (TextReader tr = new StringReader(xml))
            {
                result = (List<T>)ser.Deserialize(tr);
            }
            return result;
        }

    
    }
}
