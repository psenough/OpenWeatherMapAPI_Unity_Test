using UnityEngine;
using System.Collections;

public class OpenWeatherMapAPI : MonoBehaviour {
	
	IEnumerator CheckWeather() {
		while (true) {
			string weatherUrl = "http://api.openweathermap.org/data/2.5/weather?id=2267057&APPID=";

            //{"coord":{"lon":-9.13,"lat":38.72},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"base":"stations","main":{"temp":297.34,"pressure":1019,"humidity":38,"temp_min":294.15,"temp_max":302.04},"visibility":10000,"wind":{"speed":10.3,"deg":350},"clouds":{"all":0},"dt":1468335762,"sys":{"type":1,"id":5961,"message":0.0288,"country":"PT","sunrise":1468300952,"sunset":1468353702},"id":2267057,"name":"Lisbon","cod":200}

            //http://openweathermap.org/current
            //http://openweathermap.org/weather-conditions

            WWW weatherWWW = new WWW(weatherUrl);
			yield return weatherWWW;
			Debug.Log(weatherWWW.text);
			JSONObject tempData = new JSONObject(weatherWWW.text);
			
			JSONObject weatherDetails = tempData["weather"];
			string WeatherType = weatherDetails[0]["main"].str;
			Debug.Log(WeatherType);
            /*if (WeatherType == "Clear") {
                RenderSettings.skybox = clearSky;
            } else if (WeatherType == "Clouds" || WeatherType == "Rain") {
                RenderSettings.skybox = cloudySky;
            }*/

            string WeatherID = weatherDetails[0]["id"].ToString();
            Debug.Log(WeatherID);

            switch (WeatherID)
            {
                case "200":
                case "201":
                case "202":
                case "210":
                case "211":
                case "212":
                case "221":
                case "230":
                case "231":
                case "232":
                    //200 thunderstorm with light rain     11d
                    //201 thunderstorm with rain   11d
                    //202 thunderstorm with heavy rain     11d
                    //210 light thunderstorm   11d
                    //211 thunderstorm     11d
                    //212 heavy thunderstorm   11d
                    //221 ragged thunderstorm  11d
                    //230 thunderstorm with light drizzle  11d
                    //231 thunderstorm with drizzle    11d
                    //232 thunderstorm with heavy drizzle  11d
                    Debug.Log("rumble");
                break;
                case "300":
                case "301":
                case "302":
                case "310":
                case "311":
                case "312":
                case "313":
                case "314":
                case "321":
                    //300 light intensity drizzle  09d
                    //301 drizzle  09d
                    //302 heavy intensity drizzle  09d
                    //310 light intensity drizzle rain     09d
                    //311 drizzle rain     09d
                    //312 heavy intensity drizzle rain     09d
                    //313 shower rain and drizzle  09d
                    //314 heavy shower rain and drizzle    09d
                    //321 shower drizzle   09d
                    Debug.Log("drizzle");
                    break;
                case "500":
                case "501":
                case "502":
                case "503":
                case "504":
                case "511":
                case "520":
                case "521":
                case "522":
                case "531":
                    //500 light rain   10d
                    //501 moderate rain    10d
                    //502 heavy intensity rain     10d
                    //503 very heavy rain  10d
                    //504 extreme rain     10d
                    //511 freezing rain    13d
                    //520 light intensity shower rain  09d
                    //521 shower rain  09d
                    //522 heavy intensity shower rain  09d
                    //531 ragged shower rain   09d
                    Debug.Log("rain");
                    break;
                case "600":
                case "601":
                case "602":
                case "611":
                case "612":
                case "615":
                case "616":
                case "620":
                case "621":
                case "622":
                    //Group 6xx: Snow
                    //600 light snow[[file:13d.png]]
                    //601 snow[[file:13d.png]]
                    //602 heavy snow[[file:13d.png]]
                    //611 sleet[[file:13d.png]]
                    //612 shower sleet[[file:13d.png]]
                    //615 light rain and snow[[file:13d.png]]
                    //616 rain and snow[[file:13d.png]]
                    //620 light shower snow[[file:13d.png]]
                    //621 shower snow[[file:13d.png]]
                    //622 heavy shower snow[[file:13d.png]]
                    Debug.Log("snow");
                    break;
                case "701":
                case "711":
                case "721":
                case "731":
                case "741":
                case "751":
                case "761":
                case "762":
                case "771":
                case "781":
                    //Group 7xx: Atmosphere
                    //701 mist[[file:50d.png]]
                    //711 smoke[[file:50d.png]]
                    //721 haze[[file:50d.png]]
                    //731 sand, dust whirls[[file:50d.png]]
                    //741 fog[[file:50d.png]]
                    //751 sand[[file:50d.png]]
                    //761 dust[[file:50d.png]]
                    //762 volcanic ash[[file:50d.png]]
                    //771 squalls[[file:50d.png]]
                    //781 tornado[[file:50d.png]]
                    Debug.Log("atmosphere");
                    break;
                case "800":
                    //Group 800: Clear
                    //800 clear sky[[file:01d.png]] [[file:01n.png]]
                    Debug.Log("clear sky");
                    break;
                case "801":
                case "802":
                case "803":
                case "804":
                    //Group 80x: Clouds
                    //801	few clouds[[file:02d.png]] [[file:02n.png]]
                    //802	scattered clouds[[file:03d.png]] [[file:03d.png]]
                    //803	broken clouds[[file:04d.png]] [[file:03d.png]]
                    //804	overcast clouds[[file:04d.png]] [[file:04d.png]]
                    Debug.Log("clouds");
                    break;
                case "900":
                case "901":
                case "902":
                case "903":
                case "904":
                case "905":
                case "906":
                    //Group 90x: Extreme
                    //900	tornado
                    //901	tropical storm
                    //902	hurricane
                    //903	cold
                    //904	hot
                    //905	windy
                    //906	hail
                    Debug.Log("extreme");
                    break;
                case "951":
                case "952":
                case "953":
                case "954":
                case "955":
                    //Group 9xx: Additional
                    //951	calm
                    //952	light breeze
                    //953	gentle breeze
                    //954	moderate breeze
                    Debug.Log("breeze");
                    break;
                case "956":
                case "957":
                case "958":
                case "959":
                case "960":
                case "961":
                case "962":
                    //955	fresh breeze
                    //956	strong breeze
                    //957	high wind, near gale
                    //958	gale
                    //959	severe gale
                    //960	storm
                    //961	violent storm
                    //962	hurricane
                    Debug.Log("strong wind");
                    break;
                default:
                    Debug.Log("unexpected weather id");
                    break;
            }
			
			yield return new WaitForSeconds(120);
		}
	}
	
	void Start () {
		StartCoroutine(CheckWeather());
	}
}
