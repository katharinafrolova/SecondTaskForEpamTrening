using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Task.CarFleet.Enums;
using Task.CarFleet.Interfaces;

namespace Task.WorkWithFile.Models
{
    public class XmlFileWorker
    {

        public void ReadCarFromXML(string path, XmlReader reader)
        {
            using (reader = new XmlTextReader(path))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement() && reader.Name != "Cars")
                    {
                        Enum.TryParse(reader.Name, out CarEnum carEnum);
                        switch (carEnum)
                        {
                            //case FigureTypes.PaperCircle: figures.Add(_paperFiguresParser.ParseToPaperCircleFromXml(reader)); break;
                            //case FigureTypes.PaperRectangle: figures.Add(_paperFiguresParser.ParseToPaperRectangleFromXml(reader)); break;
                            //case FigureTypes.PaperSquare: figures.Add(_paperFiguresParser.ParseToPaperSquareFromXml(reader)); break;
                            //case FigureTypes.PaperTriangle: figures.Add(_paperFiguresParser.ParseToPaperTriangleFromXml(reader)); break;
                            //case FigureTypes.FilmCircle: figures.Add(_filmFiguresParser.ParseToFilmCircleFromXml(reader)); break;
                            //case FigureTypes.FilmRectangle: figures.Add(_filmFiguresParser.ParseToFilmRectangleFromXml(reader)); break;
                            //case FigureTypes.FilmSquare: figures.Add(_filmFiguresParser.ParseToFilmSquareFromXml(reader)); break;
                            //case FigureTypes.FilmTriangle: figures.Add(_filmFiguresParser.ParseToFilmTriangleFromXml(reader)); break;
                        }
                    }
                }
            }
        }


        public bool WriteCarToXML(string path, IEnumerable<ICar> cars, XmlWriter writer)
        {
            using (writer = XmlWriter.Create(path))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Cars");
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
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                return true;
            }
        }
    }
}
