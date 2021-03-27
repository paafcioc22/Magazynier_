using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebService.Model
{
    [XmlRoot(ElementName = "dane")]
    public class BIR11JednLokalnaOsFizycznej
    {
        [XmlElement(ElementName = "fiz_regon9")]
        public string Fiz_regon9 { get; set; }
        [XmlElement(ElementName = "fiz_nip")]
        public string Fiz_nip { get; set; }
        [XmlElement(ElementName = "fiz_statusNip")]
        public string Fiz_statusNip { get; set; }
        [XmlElement(ElementName = "fiz_nazwisko")]
        public string Fiz_nazwisko { get; set; }
        [XmlElement(ElementName = "fiz_imie1")]
        public string Fiz_imie1 { get; set; }
        [XmlElement(ElementName = "fiz_imie2")]
        public string Fiz_imie2 { get; set; }
        [XmlElement(ElementName = "fiz_dataWpisuPodmiotuDoRegon")]
        public string Fiz_dataWpisuPodmiotuDoRegon { get; set; }
        [XmlElement(ElementName = "fiz_dataZaistnieniaZmiany")]
        public string Fiz_dataZaistnieniaZmiany { get; set; }
        [XmlElement(ElementName = "fiz_dataSkresleniaPodmiotuZRegon")]
        public string Fiz_dataSkresleniaPodmiotuZRegon { get; set; }
        [XmlElement(ElementName = "fiz_podstawowaFormaPrawna_Symbol")]
        public string Fiz_podstawowaFormaPrawna_Symbol { get; set; }
        [XmlElement(ElementName = "fiz_szczegolnaFormaPrawna_Symbol")]
        public string Fiz_szczegolnaFormaPrawna_Symbol { get; set; }
        [XmlElement(ElementName = "fiz_formaFinansowania_Symbol")]
        public string Fiz_formaFinansowania_Symbol { get; set; }
        [XmlElement(ElementName = "fiz_formaWlasnosci_Symbol")]
        public string Fiz_formaWlasnosci_Symbol { get; set; }
        [XmlElement(ElementName = "fiz_podstawowaFormaPrawna_Nazwa")]
        public string Fiz_podstawowaFormaPrawna_Nazwa { get; set; }
        [XmlElement(ElementName = "fiz_szczegolnaFormaPrawna_Nazwa")]
        public string Fiz_szczegolnaFormaPrawna_Nazwa { get; set; }
        [XmlElement(ElementName = "fiz_formaFinansowania_Nazwa")]
        public string Fiz_formaFinansowania_Nazwa { get; set; }
        [XmlElement(ElementName = "fiz_formaWlasnosci_Nazwa")]
        public string Fiz_formaWlasnosci_Nazwa { get; set; }
        [XmlElement(ElementName = "fiz_dzialalnoscCeidg")]
        public string Fiz_dzialalnoscCeidg { get; set; }
        [XmlElement(ElementName = "fiz_dzialalnoscRolnicza")]
        public string Fiz_dzialalnoscRolnicza { get; set; }
        [XmlElement(ElementName = "fiz_dzialalnoscPozostala")]
        public string Fiz_dzialalnoscPozostala { get; set; }
        [XmlElement(ElementName = "fiz_dzialalnoscSkreslonaDo20141108")]
        public string Fiz_dzialalnoscSkreslonaDo20141108 { get; set; }
        [XmlElement(ElementName = "fiz_liczbaJednLokalnych")]
        public string Fiz_liczbaJednLokalnych { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class RootBIR11JednLokalnaOsFizycznej
    {
        [XmlElement(ElementName = "dane")]
        public List<BIR11JednLokalnaOsFizycznej> Dane { get; set; }
    }
}
