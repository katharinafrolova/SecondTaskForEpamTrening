using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Task.CarFleet.Interfaces;

namespace Task.WorkWithFile.Interfaces
{
    public interface IStreamFileWorker
    {
        bool WriteCarsToXML(string path, IEnumerable<ICar> figures, StreamWriter writer);
        IEnumerable<ICar> ReadCarsFromXML(string path, StreamReader reader);
    }
}
