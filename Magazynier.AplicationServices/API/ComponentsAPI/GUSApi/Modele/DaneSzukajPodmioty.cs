﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebService.Model
{
    [XmlRoot(ElementName = "dane")]
    public class DaneSzukajPodmioty
    {
        [XmlElement(ElementName = "Regon")]
        public string Regon { get; set; }
        [XmlElement(ElementName = "Nip")]
        public string Nip { get; set; }
        [XmlElement(ElementName = "StatusNip")]
        public string StatusNip { get; set; }
        [XmlElement(ElementName = "Nazwa")]
        public string Nazwa { get; set; }
        [XmlElement(ElementName = "Wojewodztwo")]
        public string Wojewodztwo { get; set; }
        [XmlElement(ElementName = "Powiat")]
        public string Powiat { get; set; }
        [XmlElement(ElementName = "Gmina")]
        public string Gmina { get; set; }
        [XmlElement(ElementName = "Miejscowosc")]
        public string Miejscowosc { get; set; }
        [XmlElement(ElementName = "KodPocztowy")]
        public string KodPocztowy { get; set; }
        [XmlElement(ElementName = "Ulica")]
        public string Ulica { get; set; }
        [XmlElement(ElementName = "NrNieruchomosci")]
        public string NrNieruchomosci { get; set; }
        [XmlElement(ElementName = "NrLokalu")]
        public string NrLokalu { get; set; }
        [XmlElement(ElementName = "Typ")]
        public string Typ { get; set; }
        [XmlElement(ElementName = "SilosID")]
        public string SilosID { get; set; }
        [XmlElement(ElementName = "DataZakonczeniaDzialalnosci")]
        public string DataZakonczeniaDzialalnosci { get; set; }
        [XmlElement(ElementName = "MiejscowoscPoczty")]
        public string MiejscowoscPoczty { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class RootDaneSzukajPodmioty
    {
        [XmlElement(ElementName = "dane")]
        public List<DaneSzukajPodmioty> Dane { get; set; }
    }


}
