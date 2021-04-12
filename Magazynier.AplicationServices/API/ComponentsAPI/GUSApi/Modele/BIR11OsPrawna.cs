using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebService.Model
{
    [XmlRoot(ElementName = "dane")]
    public class BIR11OsPrawna
    {
        [XmlElement(ElementName = "praw_regon9")]
        public string Praw_regon9 { get; set; }
        [XmlElement(ElementName = "praw_nip")]
        public string Praw_nip { get; set; }
        [XmlElement(ElementName = "praw_statusNip")]
        public string Praw_statusNip { get; set; }
        [XmlElement(ElementName = "praw_nazwa")]
        public string Praw_nazwa { get; set; }
        [XmlElement(ElementName = "praw_nazwaSkrocona")]
        public string Praw_nazwaSkrocona { get; set; }
        [XmlElement(ElementName = "praw_numerWRejestrzeEwidencji")]
        public string Praw_numerWRejestrzeEwidencji { get; set; }
        [XmlElement(ElementName = "praw_dataWpisuDoRejestruEwidencji")]
        public string Praw_dataWpisuDoRejestruEwidencji { get; set; }
        [XmlElement(ElementName = "praw_dataPowstania")]
        public string Praw_dataPowstania { get; set; }
        [XmlElement(ElementName = "praw_dataRozpoczeciaDzialalnosci")]
        public string Praw_dataRozpoczeciaDzialalnosci { get; set; }
        [XmlElement(ElementName = "praw_dataWpisuDoRegon")]
        public string Praw_dataWpisuDoRegon { get; set; }
        [XmlElement(ElementName = "praw_dataZawieszeniaDzialalnosci")]
        public string Praw_dataZawieszeniaDzialalnosci { get; set; }
        [XmlElement(ElementName = "praw_dataWznowieniaDzialalnosci")]
        public string Praw_dataWznowieniaDzialalnosci { get; set; }
        [XmlElement(ElementName = "praw_dataZaistnieniaZmiany")]
        public string Praw_dataZaistnieniaZmiany { get; set; }
        [XmlElement(ElementName = "praw_dataZakonczeniaDzialalnosci")]
        public string Praw_dataZakonczeniaDzialalnosci { get; set; }
        [XmlElement(ElementName = "praw_dataSkresleniaZRegon")]
        public string Praw_dataSkresleniaZRegon { get; set; }
        [XmlElement(ElementName = "praw_dataOrzeczeniaOUpadlosci")]
        public string Praw_dataOrzeczeniaOUpadlosci { get; set; }
        [XmlElement(ElementName = "praw_dataZakonczeniaPostepowaniaUpadlosciowego")]
        public string Praw_dataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        [XmlElement(ElementName = "praw_adSiedzKraj_Symbol")]
        public string Praw_adSiedzKraj_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzWojewodztwo_Symbol")]
        public string Praw_adSiedzWojewodztwo_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzPowiat_Symbol")]
        public string Praw_adSiedzPowiat_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzGmina_Symbol")]
        public string Praw_adSiedzGmina_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzKodPocztowy")]
        public string Praw_adSiedzKodPocztowy { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowoscPoczty_Symbol")]
        public string Praw_adSiedzMiejscowoscPoczty_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowosc_Symbol")]
        public string Praw_adSiedzMiejscowosc_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzUlica_Symbol")]
        public string Praw_adSiedzUlica_Symbol { get; set; }
        [XmlElement(ElementName = "praw_adSiedzNumerNieruchomosci")]
        public string Praw_adSiedzNumerNieruchomosci { get; set; }
        [XmlElement(ElementName = "praw_adSiedzNumerLokalu")]
        public string Praw_adSiedzNumerLokalu { get; set; }
        [XmlElement(ElementName = "praw_adSiedzNietypoweMiejsceLokalizacji")]
        public string Praw_adSiedzNietypoweMiejsceLokalizacji { get; set; }
        [XmlElement(ElementName = "praw_numerTelefonu")]
        public string Praw_numerTelefonu { get; set; }
        [XmlElement(ElementName = "praw_numerWewnetrznyTelefonu")]
        public string Praw_numerWewnetrznyTelefonu { get; set; }
        [XmlElement(ElementName = "praw_numerFaksu")]
        public string Praw_numerFaksu { get; set; }
        [XmlElement(ElementName = "praw_adresEmail")]
        public string Praw_adresEmail { get; set; }
        [XmlElement(ElementName = "praw_adresStronyinternetowej")]
        public string Praw_adresStronyinternetowej { get; set; }
        [XmlElement(ElementName = "praw_adSiedzKraj_Nazwa")]
        public string Praw_adSiedzKraj_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_adSiedzWojewodztwo_Nazwa")]
        public string Praw_adSiedzWojewodztwo_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_adSiedzPowiat_Nazwa")]
        public string Praw_adSiedzPowiat_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_adSiedzGmina_Nazwa")]
        public string Praw_adSiedzGmina_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowosc_Nazwa")]
        public string Praw_adSiedzMiejscowosc_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowoscPoczty_Nazwa")]
        public string Praw_adSiedzMiejscowoscPoczty_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_adSiedzUlica_Nazwa")]
        public string Praw_adSiedzUlica_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_podstawowaFormaPrawna_Symbol")]
        public string Praw_podstawowaFormaPrawna_Symbol { get; set; }
        [XmlElement(ElementName = "praw_szczegolnaFormaPrawna_Symbol")]
        public string Praw_szczegolnaFormaPrawna_Symbol { get; set; }
        [XmlElement(ElementName = "praw_formaFinansowania_Symbol")]
        public string Praw_formaFinansowania_Symbol { get; set; }
        [XmlElement(ElementName = "praw_formaWlasnosci_Symbol")]
        public string Praw_formaWlasnosci_Symbol { get; set; }
        [XmlElement(ElementName = "praw_organZalozycielski_Symbol")]
        public string Praw_organZalozycielski_Symbol { get; set; }
        [XmlElement(ElementName = "praw_organRejestrowy_Symbol")]
        public string Praw_organRejestrowy_Symbol { get; set; }
        [XmlElement(ElementName = "praw_rodzajRejestruEwidencji_Symbol")]
        public string Praw_rodzajRejestruEwidencji_Symbol { get; set; }
        [XmlElement(ElementName = "praw_podstawowaFormaPrawna_Nazwa")]
        public string Praw_podstawowaFormaPrawna_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_szczegolnaFormaPrawna_Nazwa")]
        public string Praw_szczegolnaFormaPrawna_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_formaFinansowania_Nazwa")]
        public string Praw_formaFinansowania_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_formaWlasnosci_Nazwa")]
        public string Praw_formaWlasnosci_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_organZalozycielski_Nazwa")]
        public string Praw_organZalozycielski_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_organRejestrowy_Nazwa")]
        public string Praw_organRejestrowy_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_rodzajRejestruEwidencji_Nazwa")]
        public string Praw_rodzajRejestruEwidencji_Nazwa { get; set; }
        [XmlElement(ElementName = "praw_liczbaJednLokalnych")]
        public string Praw_liczbaJednLokalnych { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class RootBIR11OsPrawna
    {
        [XmlElement(ElementName = "dane")]
        public List<BIR11OsPrawna> Dane { get; set; }
    }
}
