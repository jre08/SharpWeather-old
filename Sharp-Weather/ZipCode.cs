using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharpWeather
{
    class zipcode
    {
        public zipcode(string zipstring)
        {

            string xUrl = "http://www.webservicex.net/uszip.asmx/GetInfoByCity?USCity=" + zipstring;
            XmlDocument doc = new XmlDocument();
            doc.Load(xUrl);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/NewDataSet/Table/ZIP");

            
            //XmlNodeList nodes1 = default(XmlNodeList);
            //XmlNode node = xInfo.DocumentElement.SelectSingleNode("/NewDataSet/Table/");
            //nodes1 = xInfo.SelectNodes();
            //lblD1.Text = nodes1.Item(3).InnerText;
            //lblD1desc.Text = nodes1.Item(4).InnerText;
            //lblD1pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;


                Debug.Print(node.InnerText);
            }
            


        }
    }
