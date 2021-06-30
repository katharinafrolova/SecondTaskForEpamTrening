using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Task.CarFleet.Interfaces;

namespace Task.WorkWithFile.Interfaces
{
    public interface IXmlFileWorker
    {
        bool WriteCarsToXML(string path, IEnumerable<ICar> car, XmlWriter writer);
        IEnumerable<ICar> ReadCarsFromXML(string path, XmlReader reader);
    }
}
