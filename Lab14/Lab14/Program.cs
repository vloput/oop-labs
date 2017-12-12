using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Binary

            Console.WriteLine("Binary\n");

            //Serialization

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("cartoon.dat", FileMode.OpenOrCreate))
            {
                Cartoon TomAndJerry = new Cartoon("Tom and Jerry", "Clarence Nash, Lillian Randolph");

                formatter.Serialize(stream, TomAndJerry);
            }

            //Deserialization

            using (FileStream stream = new FileStream("cartoon.dat", FileMode.OpenOrCreate))
            {
                Cartoon someCartoon = (Cartoon)formatter.Deserialize(stream);

                Console.WriteLine($"Loaded \"{someCartoon.Name}\", starring {someCartoon.Voices}\n");
            }

            #endregion

            #region SOAP

            Console.WriteLine("SOAP\n");

            SoapFormatter soapFormatter = new SoapFormatter();

            using (FileStream stream = new FileStream("cartoon.soap", FileMode.OpenOrCreate))
            {
                Cartoon Simpsons = new Cartoon("Simpsons", "Dan Castellaneta, Nancy Cartwright");

                soapFormatter.Serialize(stream, Simpsons);
            }

            //Deserialization

            using (FileStream stream = new FileStream("cartoon.soap", FileMode.OpenOrCreate))
            {
                Cartoon someCartoon = (Cartoon)soapFormatter.Deserialize(stream);

                Console.WriteLine($"Loaded \"{someCartoon.Name}\", starring {someCartoon.Voices}\n");
            }

            #endregion

            #region XML

            XmlSerializer serializer = new XmlSerializer(typeof(Cartoon));

            Console.WriteLine("XML\n");

            //Serialization

            using (FileStream stream = new FileStream("cartoon.xml", FileMode.OpenOrCreate))
            {
                Cartoon ScoobyDoo = new Cartoon("Scooby-Doo, Where Are You!", "Don Messick, Casey Kasem");

                serializer.Serialize(stream, ScoobyDoo);
            }

            //Deserialization

            using (FileStream stream = new FileStream("cartoon.xml", FileMode.OpenOrCreate))
            {
                Cartoon someCartoon = (Cartoon)serializer.Deserialize(stream);

                Console.WriteLine($"Loaded \"{someCartoon.Name}\", starring {someCartoon.Voices}\n");
            }

            #endregion

            #region JSON

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Cartoon));

            Console.WriteLine("JSON\n");

            //Serialization

            using (FileStream stream = new FileStream("cartoon.json", FileMode.OpenOrCreate))
            {
                Cartoon KingOfTheHill = new Cartoon("King of the Hill", "Mike Judge, Johnny Hardwick");

                jsonSerializer.WriteObject(stream, KingOfTheHill);
            }

            //Deserialization

            using (FileStream stream = new FileStream("cartoon.json", FileMode.OpenOrCreate))
            {
                Cartoon someCartoon = (Cartoon)jsonSerializer.ReadObject(stream);

                Console.WriteLine($"Loaded \"{someCartoon.Name}\", starring {someCartoon.Voices}\n");
            }

            #endregion

            #region Collection

            XmlSerializer top3Serializer = new XmlSerializer(typeof(List<Cartoon>));

            List<Cartoon> top3 = new List<Cartoon>();
            top3.Add(new Cartoon("Looney Tunes", "Bugs Bunny, Daffy Duck, Tweety"));
            top3.Add(new Cartoon("The Simpsons", "Homer Simpson, Lisa Simpson, Mr. Burns"));
            top3.Add(new Cartoon("Tom and Jerry", "Tom, Jerry, Spike"));

            using (FileStream topStream = new FileStream("top3.xml", FileMode.Create))
            {
                top3Serializer.Serialize(topStream, top3);
            }

            using (FileStream topStream = new FileStream("top3.xml", FileMode.OpenOrCreate))
            {
                List<Cartoon> someCartoons = (List<Cartoon>)top3Serializer.Deserialize(topStream);

                foreach (var item in someCartoons)
                {
                    Console.WriteLine(item.Name + ": " + item.Voices);
                }
            }

            #endregion

            #region XPath

            Console.WriteLine("\nXPath\n");

            XmlDocument document = new XmlDocument();
            document.Load("top3.xml");

            XmlNode xmlRoot = document.SelectSingleNode("ArrayOfCartoon");
            XmlNodeList nodeCartoons = xmlRoot.SelectNodes("Cartoon");

            Console.WriteLine("Top 3 best cartoons:");
            foreach (XmlNode item in nodeCartoons)
            {
                Console.WriteLine(item.SelectSingleNode("Name").InnerText);
            }

            Console.WriteLine("\nAnd their voices:");
            foreach (XmlNode item in nodeCartoons)
            {
                Console.WriteLine(item.SelectSingleNode("Voices").InnerText);
            }

            Console.WriteLine("\nFull info about \'em:");

            XmlNodeList allCartoons = xmlRoot.SelectNodes("*");

            foreach (XmlNode item in allCartoons)
            {
                Console.WriteLine(item.InnerText);
            }

            #endregion

            #region Linq to XML

            Console.WriteLine("\nLINQ to XML:\n");

            XDocument placeboAlbums = new XDocument();          //Create document
            XElement root = new XElement("discography");        //Create root

            XElement album;                                     //Create album element
            XElement name;                                      //Create name element
            XAttribute year;                                    //Create year attribute

            album = new XElement("album");
            name = new XElement("name");
            name.Value = "Meds";
            year = new XAttribute("year", "2004");
            album.Add(name);
            album.Add(year);
            root.Add(album);

            album = new XElement("album");
            name = new XElement("name");
            name.Value = "Black market music";
            year = new XAttribute("year", "2000");
            album.Add(name);
            album.Add(year);
            root.Add(album);

            album = new XElement("album");
            name = new XElement("name");
            name.Value = "Without you I'm nothing";
            year = new XAttribute("year", "1998");
            album.Add(name);
            album.Add(year);
            root.Add(album);


            placeboAlbums.Add(root);
            placeboAlbums.Save("Placebo Albums.xml");           //Save file

            //Query

            Console.WriteLine("Введите год для поиска: ");
            string yearXML = Console.ReadLine();

            var allAlbums = root.Elements("album");

            foreach (var item in allAlbums)
            {
                if (item.Attribute("year").Value == yearXML)
                {
                    Console.WriteLine(item.Value);
                }
            }

            #endregion
        }
    }
}
