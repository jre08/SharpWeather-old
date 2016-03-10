
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//
// Created by SharpDevelop.
// User: edenfield-john
// Date: 10/6/2015
// Time: 4:10 PM
// 
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//

//Option Explicit On
using System.Xml.Linq;
using System.Net;
using System.Xml;

internal static class Globals   
{   
    public static string textjson = "";   
       
}  


public partial class MainForm
{
	string text2;
	string num;
	string labeltxt;
	string periodtxt;
	string icontxt;
	static string textjson;
	public MainForm()
	{
		//SizeChanged += Redrawmap;
		// The Me.InitializeComponent call is required for Windows Forms designer support.
		this.InitializeComponent();
		readJson();
		Map();
		Forecast4day();

	}

	public void Redrawmap()
	{
		//int iwidth = pictureBox4.Size.Width;
		//int iheight = pictureBox4.Size.Height;
		int bwidth = WEBmapbrowser.Size.Width;
		int bheight = WEBmapbrowser.Size.Height;




		//MsgBox("width = " & iwidth & ", height = " & iheight)


		//dynamic yURl = "http://api.wunderground.com/api/8390d409d9f2d532/animatedradar/q/FL/Tallahassee.swf?newmaps=1&timelabel=1&timelabel.y=10&num=15&delay=50&width=" + bwidth + "&height=" + bheight;
		//WEBmapbrowser.Url = new Uri(yURl);
		//pictureBox4.Load("http://api.wunderground.com/api/8390d409d9f2d532/animatedradar/q/FL/Tallahassee.gif?newmaps=1&timelabel=1&timelabel.y=10&num=15&delay=50&width=" + iwidth + "&height=" + iheight);
	}

	public void Map()
	{
		//dynamic yURl = "http://api.wunderground.com/api/8390d409d9f2d532/animatedradar/q/FL/Tallahassee.swf?newmaps=1&timelabel=1&timelabel.y=10&num=15&delay=50&width=900&height=400";
		//WEBmapbrowser.Url = new Uri(yURl);
		//pictureBox4.Load("http://api.wunderground.com/api/8390d409d9f2d532/animatedradar/q/FL/Tallahassee.gif?newmaps=1&timelabel=1&timelabel.y=10&num=15&delay=50&width=600&height=400");
	}


	public void Forecast4day()
	{	
		//JObject o = JObject.Parse(textjson);
		forecast4 weather = new forecast4();
		//Debug.Print(weather.readJson("icon_url"));
		string picpath = null;
		
		
		picpath = weather.readJson(0,"icon_url");
		picboxD1.Load(picpath);
		lblD1.Text = weather.readJson(0,"title");
		//lblD1desc.Text = weather.readJson(0,"fcttext");
		lblD1pop.Text = "Chance of precipitation: " + weather.readJson(0,"pop");
		
		picpath = weather.readJson(1,"icon_url");
		picboxN1.Load(picpath);
		lblN1.Text = weather.readJson(1,"title");
		//lblN1desc.Text = weather.readJson(1,"fcttext");
		lblN1pop.Text = "Chance of precipitation: " + weather.readJson(1,"pop");
		
		
		picpath = weather.readJson(2,"icon_url");
		picboxD2.Load(picpath);
		lblD2.Text = weather.readJson(2,"title");
		//lblD2desc.Text = weather.readJson(2,"fcttext");
		lblD2pop.Text = "Chance of precipitation: " + weather.readJson(2,"pop");
		
		picpath = weather.readJson(3,"icon_url");
		picboxN2.Load(picpath);
		lblN2.Text = weather.readJson(3,"title");
		//lblN2desc.Text = weather.readJson(3,"fcttext");
		lblN2pop.Text = "Chance of precipitation: " + weather.readJson(3,"pop");
		
		
		
		picpath = weather.readJson(4,"icon_url");
		picboxD3.Load(picpath);
		lblD3.Text = weather.readJson(4,"title");
		//lblD3desc.Text = weather.readJson(4,"fcttext");
		lblD3pop.Text = "Chance of precipitation: " + weather.readJson(4,"pop");
		
		picpath = weather.readJson(5,"icon_url");
		picboxN3.Load(picpath);
		lblN3.Text = weather.readJson(5,"title");
		//lblN3desc.Text = weather.readJson(5,"fcttext");
		lblN3pop.Text = "Chance of precipitation: " + weather.readJson(5,"pop");
		
		
		
		picpath = weather.readJson(6,"icon_url");
		picboxD4.Load(picpath);
		lblD4.Text = weather.readJson(6,"title");
		//lblD4desc.Text = weather.readJson(6,"fcttext");
		lblD4pop.Text = "Chance of precipitation: " + weather.readJson(6,"pop");
		
		picpath = weather.readJson(7,"icon_url");
		picboxN4.Load(picpath);
		lblN4.Text = weather.readJson(7,"title");
		//lblN4desc.Text = weather.readJson(7,"fcttext");
		lblN4pop.Text = "Chance of precipitation: " + weather.readJson(7,"pop");
		
		

		weather = null;
		/*
		string xUrl = "http://api.wunderground.com/api/8390d409d9f2d532/forecast/q/FL/Tallahassee.xml";
		XmlDocument xInfo = new XmlDocument();
		xInfo.Load(xUrl);
		XmlNodeList nodes1 = default(XmlNodeList);
		string picpath = null;

		#region "Way to add controls in a list"
		//Private _userControlList As New List(Of YourControl)

		//Private Sub AddingControlOnPanel()
		//   Dim index As Integer = _userControlList.Count + 1
		//  Dim userControl As New YourControl
		// UserControl.Location = New System.Drawing.Point(SomeLocation)
		//UserControl.Size = New System.Drawing.Size(SomeSize)
		//UserControl.Name = "userControl" + index.ToString
		//UserControl.Visible = False
		//_userControlList.Add(userControl)
		//UserControlsPanel.Controls.Add(userControl)
		//UserControl.Visible = True
		//End Sub
		#endregion

		#region "4 day Forecast"
		//Day one
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=1]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD1.Load(picpath);
		lblD1.Text = nodes1.Item(3).InnerText;
		lblD1desc.Text = nodes1.Item(4).InnerText;
		lblD1pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//Night one
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=2]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN1.Load(picpath);
		lblN1.Text = nodes1.Item(3).InnerText;
		lblN1desc.Text = nodes1.Item(4).InnerText;
		lblN1pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Day two
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=3]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD2.Load(picpath);
		lblD2.Text = nodes1.Item(3).InnerText;
		lblD2desc.Text = nodes1.Item(4).InnerText;
		lblD2pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Night two
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=4]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN2.Load(picpath);
		lblN2.Text = nodes1.Item(3).InnerText;
		lblN2desc.Text = nodes1.Item(4).InnerText;
		lblN2pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Day three
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=5]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD3.Load(picpath);
		lblD3.Text = nodes1.Item(3).InnerText;
		lblD3desc.Text = nodes1.Item(4).InnerText;
		lblD3pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Night three
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=6]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN3.Load(picpath);
		lblN3.Text = nodes1.Item(3).InnerText;
		lblN3desc.Text = nodes1.Item(4).InnerText;
		lblN3pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Day four
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=7]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxD4.Load(picpath);
		lblD4.Text = nodes1.Item(3).InnerText;
		lblD4desc.Text = nodes1.Item(4).InnerText;
		lblD4pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;

		//'Night Four
		nodes1 = xInfo.SelectNodes("/response/forecast/txt_forecast/forecastdays/forecastday[position()=8]/*");
		picpath = nodes1.Item(2).InnerText;
		picboxN4.Load(picpath);
		lblN4.Text = nodes1.Item(3).InnerText;
		lblN4desc.Text = nodes1.Item(4).InnerText;
		lblN4pop.Text = "Chance of precipitation: " + nodes1.Item(6).InnerText;
		//RichTextBox1.Text = text2
		#endregion
	}

	private void Button1_Click(object sender, EventArgs e)
	{	
		/*
		Controls.Remove(tabControl1);
		//_10DayForecast day10 = new _10DayForecast();
		day10.Location = new System.Drawing.Point(12, 12);
		day10.Size = new System.Drawing.Size(1007, 527);
		Controls.Add(day10);
		this.Controls.Add(day10);
		day10.Visible = true;
*/
	}
	void GMapControlLoad(object sender, EventArgs e)
	{
		gMap.SetPositionByKeywords("USA");
		GMapProvider provider = GMapProviders.OpenCycleMap;
		gMap.MapProvider  = provider;
		gMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);
		
	}
	
	void MainMap_OnPositionChanged(PointLatLng point)
      {
		string lat = point.Lat.ToString(CultureInfo.InvariantCulture);
		string lng = point.Lng.ToString(CultureInfo.InvariantCulture);
		label1.Text = lat + ", "  + lng;
         
      }
	
	void readJson(){
		var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/forecast/q/FL/Tallahassee.json");
		    request.ContentType = "application/json";
		var response = (HttpWebResponse) request.GetResponse();

			using (var sr = new StreamReader(response.GetResponseStream()))
				{
    			Globals.textjson = sr.ReadToEnd();
				}
            //JObject o = JObject.Parse(textjson);
            //Debug.Print("forecast: " +o["forecast"]["txt_forecast"]["forecastday"][0]);
			
	
	}
	void Button3Click(object sender, EventArgs e)
	{
		forecast4 weather = new forecast4();
		//Debug.Print(weather.readJson("icon_url"));
		weather = null;
	}
	void GMapLoad(object sender, EventArgs e)
	{
		gMap.SetPositionByKeywords("USA");
		GMapProvider provider = GMapProviders.OpenCycleMap;
		gMap.MapProvider  = provider;
		gMap.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);
		
	}

	
	
}

public class forecast4{
	
	//forecast
	public int period { get; set; }
	public string icon { get; set; }
	public Uri iconURL { get; set; }
	public string title { get; set; }
	public string fcstText { get; set; }
	public int precipChance { get; set; }
	
	public string readJson(int num, string input){
		//var request = WebRequest.Create("http://api.wunderground.com/api/8390d409d9f2d532/forecast/q/FL/Tallahassee.json");
		  //  request.ContentType = "application/json";
		//var response = (HttpWebResponse) request.GetResponse();
		//var textjson = "";

			//using (var sr = new StreamReader(response.GetResponseStream()))
				//{
    			//textjson = sr.ReadToEnd();
				//}
			
            JObject o = JObject.Parse(Globals.textjson);
            return Convert.ToString(o["forecast"]["txt_forecast"]["forecastday"][num][input]);
			
	
	}
}

class currentConditions{
	
	//repsonse
	public string Version { get; set; }
	public string TermService { get; set; }
	
	public int Conditions { get; set; }
	
	//Current_observation
	public Image wuLogo { get; set; }
	public string Title { get; set; }	
	public Uri wuLink { get; set; }
	
	//display_location
	public string full { get; set; }
	public string city { get; set; }
	public string state { get; set; }
	public string stateName { get; set; }
	public string country { get; set; }
	public string countryISO { get; set; }
	public int zip { get; set; }
	public double latitude { get; set; }
	public double longitude { get; set; }
	public double elevation { get; set; }
	
	//observation_location
	public string observationFull { get; set; }
	public string observationCity { get; set; }
	public string observationState { get; set; }
	public string observationCountry { get; set; }
	public string observationISO { get; set; }
	public double observationLat { get; set; }
	public double observationLon { get; set; }
	public double observationEle { get; set; }
	public string observationEst { get;set;  }
	public string stationID { get; set; }
	public string timeZoneShort { get; set; }
	public string timeZoneLong { get; set; }
	public string timeZoneOff { get; set; }
	public string weather { get; set; }
	public string Temp { get; set; }
	public double tempF { get; set; }
	public double tempC { get; set; }
	public string humidity { get; set; }
	public string windString { get; set; }
	public string windDir { get; set; }
	public double winddDeg { get; set; }
	public double windMPH { get; set; }
	public double windGustMPH { get; set; }
	public double windKPH { get; set; }
	public double windGushKPH { get; set; }
	public double pressureMB { get; set; }
	public double pressureIN { get; set; }
	public string pressureTrend { get; set; }
	public string dewpointString { get; set; }
	public double dewpointF { get; set; }
	public double dewpointC { get; set; }
	public string heatindexString { get; set; }	
	public string heatindexF { get; set; }
	public string heatindexC { get; set; }
	public string windchillString { get; set; }
	public string windchillF { get; set; }
	public string windchillC { get; set; }
	public string feelslikeString { get; set; }
	public double feelslikeF { get; set; }
	public double feelslikeC { get; set; }
	public double visibilityMI { get; set; }
	public double visibilityKM { get; set; }
	public string solarradiation { get; set; }
	public int UV { get; set; }
	public string precip_1hr_string { get; set; }
    public string precip_1hr_in { get; set; }
    public string precip_1hr_metric { get; set; }
    public string precip_today_string { get; set; }
    public string precip_today_in { get; set; }
    public string precip_today_metric { get; set; }
    public string icon { get; set; }
    public Image icon_url { get; set; } 
    public Uri forecast_url { get; set; }
    public Uri history_url { get; set; }
    public Uri  ob_url { get; set; }

}