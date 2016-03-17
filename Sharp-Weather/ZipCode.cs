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

            var request = WebRequest.Create("http://autocomplete.wunderground.com/aq?query=" + zipstring);
        request.ContentType = "application/json";
        var response = (HttpWebResponse)request.GetResponse();

        using (var sr = new StreamReader(response.GetResponseStream()))
        {
            Globals.zipCity = sr.ReadToEnd();
        }
        JObject o = JObject.Parse(Globals.zipCity);
        JArray items = (JArray)o["RESULTS"];
		int length = items.Count;
		
		for (int i = 0; i < items.Count; i++)
{			
			//var item = (JObject)items[i];
			Debug.Print( (string)o["RESULTS"][i]["name"]);
}
		
		


        
		

				

        
			
          /*  string xUrl = "http://www.webservicex.net/uszip.asmx/GetInfoByCity?USCity=" + zipstring;
            XmlDocument doc = new XmlDocument();
            doc.Load(xUrl);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/NewDataSet/Table/ZIP");
            Globals.zipCity = node.InnerText;                
          */
  }
            


        }
    }
