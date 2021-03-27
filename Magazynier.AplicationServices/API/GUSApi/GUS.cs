using ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WcfCoreMtomEncoder;
using WebService.Model;

namespace Magazynier.AplicationServices.API.GUSApi
{
    public class GUS :IGus
    {
        public UslugaBIRzewnPublClient uslugaBIRzewn;
        static string AdresUslugi = "https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
        string sid;
     

        public GUS()
        {
   
            uslugaBIRzewn = new UslugaBIRzewnPublClient();         

            uslugaBIRzewn.Endpoint.Address = new (AdresUslugi); 
        
            var encoding = new MtomMessageEncoderBindingElement(new TextMessageEncodingBindingElement());
            var transport = new HttpsTransportBindingElement();

            var customBinding = new CustomBinding(encoding, transport);
            uslugaBIRzewn.Endpoint.Binding = customBinding;

            sid = Loguj().Result;

        }

        async Task<string> Loguj()
        {

            OperationContextScope scope = new OperationContextScope(uslugaBIRzewn.InnerChannel);
            HttpRequestMessageProperty httpRequest = new HttpRequestMessageProperty();
            httpRequest.Headers.Add("sid", sid);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequest;


            var klucz = await uslugaBIRzewn.ZalogujAsync("e12cfb05144a4849b5e6");
            return klucz.ZalogujResult;
        }

        public async Task<T> szukajPodmioty<T>(string nip)
        {
         
            var parametrSzukajKontrahenta = new ParametryWyszukiwania();
            parametrSzukajKontrahenta.Nip = nip;

            var response =await  uslugaBIRzewn.DaneSzukajPodmiotyAsync(parametrSzukajKontrahenta);

            return  DeserializeFromXml<T>(response.DaneSzukajPodmiotyResult);
 
        }

        public static T DeserializeFromXml<T>(string xml)
        {
            T result;

            XmlSerializer ser = new XmlSerializer(typeof(T) );
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }


    }
}
