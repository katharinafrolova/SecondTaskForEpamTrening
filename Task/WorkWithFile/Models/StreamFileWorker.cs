using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Task.CarFleet.Enums;
using Task.CarFleet.Interfaces;

namespace Task.WorkWithFile.Models
{
    public class StreamFileWorker
    {
        private const string _xmlHeader = "<?xml version =\"1.0\" encoding=\"utf-8\" ?>";
        public void ReadFiguresFromXML(string path, StreamReader reader)
        {
            using (reader = new StreamReader(path))
            {
                List<ICar> cars = new List<ICar>();
                XDocument xDoc = XDocument.Load(reader);
                foreach (XElement item in xDoc.Descendants("Cars").SelectMany(node => node.Elements()))
                {
                    Enum.TryParse(item.Name.ToString(), out CarEnum  carEnum);
                    switch (carEnum)
                    {
                        //case carEnum.PaperCircle: figures.Add(_paperFiguresParser.ParseToPaperCircleFromXml(item)); break;
                        //case carEnum.PaperRectangle: figures.Add(_paperFiguresParser.ParseToPaperRectangleFromXml(item)); break;
                        //case carEnum.PaperSquare: figures.Add(_paperFiguresParser.ParseToPaperSquareFromXml(item)); break;
                        //case carEnum.PaperTriangle: figures.Add(_paperFiguresParser.ParseToPaperTriangleFromXml(item)); break;
                        //case carEnum.FilmCircle: figures.Add(_filmFiguresParser.ParseToFilmCircleFromXml(item)); break;
                        //case carEnum.FilmRectangle: figures.Add(_filmFiguresParser.ParseToFilmRectangleFromXml(item)); break;
                        //case carEnum.FilmSquare: figures.Add(_filmFiguresParser.ParseToFilmSquareFromXml(item)); break;
                        //case carEnum.FilmTriangle: figures.Add(_filmFiguresParser.ParseToFilmTriangleFromXml(item)); break;
                    }
                }
                
            }
        }

        public bool WriteFiguresFromBoxToXML(string path, IEnumerable<ICar> cars, StreamWriter writer)
        {
            using (writer = new StreamWriter(path))
            {
                writer.WriteLine(_xmlHeader);
                writer.WriteLine("<Cars>");

                foreach (ICar car in cars)
                {
                    Enum.TryParse(car.GetType().Name, out CarEnum carEnum);
                    switch (carEnum)
                    {
                        //case carEnum.PaperCircle: _paperXmlElementWriter.WriteCircularPaperFigure(writer, figure as IPaperFigure); break;
                        //case carEnum.PaperRectangle:
                        //case carEnum.PaperSquare:
                        //case carEnum.PaperTriangle: _paperXmlElementWriter.WritePolygonPaperFigure(writer, figure as IPaperFigure); break;
                        //case carEnum.FilmCircle: _filmXmlElementWriter.WriteCircularFilmFigure(writer, figure as IFilmFigure); break;
                        //case carEnum.FilmRectangle:
                        //case carEnum.FilmSquare:
                        //case carEnum.FilmTriangle: _filmXmlElementWriter.WritePolygonFilmFigure(writer, figure as IFilmFigure); break;
                    }
                }
                writer.WriteLine("</Cars>");
                return true;
            }
        }

    }
}
