http://api.openweathermap.org/data/2.5/weather?id=2267057&APPID=
{"coord":{"lon":-9.13,"lat":38.72},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"base":"stations","main":{"temp":297.34,"pressure":1019,"humidity":38,"temp_min":294.15,"temp_max":302.04},"visibility":10000,"wind":{"speed":10.3,"deg":350},"clouds":{"all":0},"dt":1468335762,"sys":{"type":1,"id":5961,"message":0.0288,"country":"PT","sunrise":1468300952,"sunset":1468353702},"id":2267057,"name":"Lisbon","cod":200}

http://openweathermap.org/current

http://openweathermap.org/weather-conditions

Weather IDs:
Group 2xx: Thunderstorm
ID	Meaning	Icon
200	thunderstorm with light rain	 11d
201	thunderstorm with rain	 11d
202	thunderstorm with heavy rain	 11d
210	light thunderstorm	 11d
211	thunderstorm	 11d
212	heavy thunderstorm	 11d
221	ragged thunderstorm	 11d
230	thunderstorm with light drizzle	 11d
231	thunderstorm with drizzle	 11d
232	thunderstorm with heavy drizzle	 11d
Group 3xx: Drizzle
ID	Meaning	Icon
300	light intensity drizzle	 09d
301	drizzle	 09d
302	heavy intensity drizzle	 09d
310	light intensity drizzle rain	 09d
311	drizzle rain	 09d
312	heavy intensity drizzle rain	 09d
313	shower rain and drizzle	 09d
314	heavy shower rain and drizzle	 09d
321	shower drizzle	 09d
Group 5xx: Rain
ID	Meaning	Icon
500	light rain	 10d
501	moderate rain	 10d
502	heavy intensity rain	 10d
503	very heavy rain	 10d
504	extreme rain	 10d
511	freezing rain	 13d
520	light intensity shower rain	 09d
521	shower rain	 09d
522	heavy intensity shower rain	 09d
531	ragged shower rain	 09d
Group 6xx: Snow
ID	Meaning	Icon
600	light snow	[[file:13d.png]]
601	snow	[[file:13d.png]]
602	heavy snow	[[file:13d.png]]
611	sleet	[[file:13d.png]]
612	shower sleet	[[file:13d.png]]
615	light rain and snow	[[file:13d.png]]
616	rain and snow	[[file:13d.png]]
620	light shower snow	[[file:13d.png]]
621	shower snow	[[file:13d.png]]
622	heavy shower snow	[[file:13d.png]]
Group 7xx: Atmosphere
ID	Meaning	Icon
701	mist	[[file:50d.png]]
711	smoke	[[file:50d.png]]
721	haze	[[file:50d.png]]
731	sand, dust whirls	[[file:50d.png]]
741	fog	[[file:50d.png]]
751	sand	[[file:50d.png]]
761	dust	[[file:50d.png]]
762	volcanic ash	[[file:50d.png]]
771	squalls	[[file:50d.png]]
781	tornado	[[file:50d.png]]
Group 800: Clear
ID	Meaning	Icon
800	clear sky	[[file:01d.png]] [[file:01n.png]]
Group 80x: Clouds
ID	Meaning	Icon
801	few clouds	[[file:02d.png]] [[file:02n.png]]
802	scattered clouds	[[file:03d.png]] [[file:03d.png]]
803	broken clouds	[[file:04d.png]] [[file:03d.png]]
804	overcast clouds	[[file:04d.png]] [[file:04d.png]]
Group 90x: Extreme
ID	Meaning
900	tornado
901	tropical storm
902	hurricane
903	cold
904	hot
905	windy
906	hail
Group 9xx: Additional
ID	Meaning
951	calm
952	light breeze
953	gentle breeze
954	moderate breeze
955	fresh breeze
956	strong breeze
957	high wind, near gale
958	gale
959	severe gale
960	storm
961	violent storm
962	hurricane


http://api.openweathermap.org/data/2.5/forecast/city?id=2267057&APPID=b71ca2721d7687f85899e0e42714c4ac

{"city":{"id":2267057,"name":"Lisbon","coord":{"lon":-9.13333,"lat":38.716671},"country":"PT","population":0,"sys":{"population":0}},"cod":"200","message":0.0387,"cnt":34,"list":[{"dt":1468346400,"main":{"temp":295.41,"temp_min":295.41,"temp_max":296.158,"pressure":1022.31,"sea_level":1032.21,"grnd_level":1022.31,"humidity":39,"temp_kf":-0.75},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":9.21,"deg":346.504},"sys":{"pod":"d"},"dt_txt":"2016-07-12 18:00:00"},{"dt":1468357200,"main":{"temp":291.14,"temp_min":291.14,"temp_max":291.695,"pressure":1023.16,"sea_level":1033.12,"grnd_level":1023.16,"humidity":58,"temp_kf":-0.56},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":8.22,"deg":349.002},"sys":{"pod":"n"},"dt_txt":"2016-07-12 21:00:00"},{"dt":1468368000,"main":{"temp":289.59,"temp_min":289.59,"temp_max":289.965,"pressure":1023.28,"sea_level":1033.37,"grnd_level":1023.28,"humidity":70,"temp_kf":-0.37},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":7.32,"deg":348.503},"sys":{"pod":"n"},"dt_txt":"2016-07-13 00:00:00"},{"dt":1468378800,"main":{"temp":289.16,"temp_min":289.16,"temp_max":289.346,"pressure":1022.53,"sea_level":1032.62,"grnd_level":1022.53,"humidity":73,"temp_kf":-0.19},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":6.83,"deg":347.001},"sys":{"pod":"n"},"dt_txt":"2016-07-13 03:00:00"},{"dt":1468389600,"main":{"temp":289.251,"temp_min":289.251,"temp_max":289.251,"pressure":1022.68,"sea_level":1032.69,"grnd_level":1022.68,"humidity":67,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":6.42,"deg":348.001},"sys":{"pod":"d"},"dt_txt":"2016-07-13 06:00:00"},{"dt":1468400400,"main":{"temp":295.897,"temp_min":295.897,"temp_max":295.897,"pressure":1022.76,"sea_level":1032.85,"grnd_level":1022.76,"humidity":43,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":6.46,"deg":351.003},"sys":{"pod":"d"},"dt_txt":"2016-07-13 09:00:00"},{"dt":1468411200,"main":{"temp":301.28,"temp_min":301.28,"temp_max":301.28,"pressure":1022.42,"sea_level":1032.35,"grnd_level":1022.42,"humidity":36,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":6.01,"deg":352.006},"sys":{"pod":"d"},"dt_txt":"2016-07-13 12:00:00"},{"dt":1468422000,"main":{"temp":303.052,"temp_min":303.052,"temp_max":303.052,"pressure":1021.42,"sea_level":1031.2,"grnd_level":1021.42,"humidity":31,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":6.63,"deg":351.504},"sys":{"pod":"d"},"dt_txt":"2016-07-13 15:00:00"},{"dt":1468432800,"main":{"temp":301.426,"temp_min":301.426,"temp_max":301.426,"pressure":1020.92,"sea_level":1030.76,"grnd_level":1020.92,"humidity":31,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":6.62,"deg":349.504},"sys":{"pod":"d"},"dt_txt":"2016-07-13 18:00:00"},{"dt":1468443600,"main":{"temp":295.604,"temp_min":295.604,"temp_max":295.604,"pressure":1021.9,"sea_level":1031.69,"grnd_level":1021.9,"humidity":45,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":6,"deg":348.005},"sys":{"pod":"n"},"dt_txt":"2016-07-13 21:00:00"},{"dt":1468454400,"main":{"temp":290.74,"temp_min":290.74,"temp_max":290.74,"pressure":1022.14,"sea_level":1032.02,"grnd_level":1022.14,"humidity":67,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":2.41,"deg":324.001},"sys":{"pod":"n"},"dt_txt":"2016-07-14 00:00:00"},{"dt":1468465200,"main":{"temp":286.527,"temp_min":286.527,"temp_max":286.527,"pressure":1021.57,"sea_level":1031.43,"grnd_level":1021.57,"humidity":92,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":1.25,"deg":305.005},"sys":{"pod":"n"},"dt_txt":"2016-07-14 03:00:00"},{"dt":1468476000,"main":{"temp":284.964,"temp_min":284.964,"temp_max":284.964,"pressure":1021.56,"sea_level":1031.46,"grnd_level":1021.56,"humidity":90,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":1.21,"deg":298.501},"sys":{"pod":"d"},"dt_txt":"2016-07-14 06:00:00"},{"dt":1468486800,"main":{"temp":297.756,"temp_min":297.756,"temp_max":297.756,"pressure":1022,"sea_level":1031.85,"grnd_level":1022,"humidity":49,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":1.83,"deg":340.501},"sys":{"pod":"d"},"dt_txt":"2016-07-14 09:00:00"},{"dt":1468497600,"main":{"temp":305.717,"temp_min":305.717,"temp_max":305.717,"pressure":1021.58,"sea_level":1031.38,"grnd_level":1021.58,"humidity":33,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":2.22,"deg":28.0016},"sys":{"pod":"d"},"dt_txt":"2016-07-14 12:00:00"},{"dt":1468508400,"main":{"temp":307.974,"temp_min":307.974,"temp_max":307.974,"pressure":1020.23,"sea_level":1030.08,"grnd_level":1020.23,"humidity":27,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":2.41,"deg":348.003},"sys":{"pod":"d"},"dt_txt":"2016-07-14 15:00:00"},{"dt":1468519200,"main":{"temp":306.488,"temp_min":306.488,"temp_max":306.488,"pressure":1019.12,"sea_level":1029.11,"grnd_level":1019.12,"humidity":25,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":3.86,"deg":336.504},"sys":{"pod":"d"},"dt_txt":"2016-07-14 18:00:00"},{"dt":1468530000,"main":{"temp":298.676,"temp_min":298.676,"temp_max":298.676,"pressure":1019.71,"sea_level":1029.6,"grnd_level":1019.71,"humidity":39,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":2.78,"deg":331.502},"sys":{"pod":"n"},"dt_txt":"2016-07-14 21:00:00"},{"dt":1468540800,"main":{"temp":292.77,"temp_min":292.77,"temp_max":292.77,"pressure":1019.93,"sea_level":1029.73,"grnd_level":1019.93,"humidity":64,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":1.5,"deg":321},"sys":{"pod":"n"},"dt_txt":"2016-07-15 00:00:00"},{"dt":1468551600,"main":{"temp":289.773,"temp_min":289.773,"temp_max":289.773,"pressure":1018.96,"sea_level":1028.81,"grnd_level":1018.96,"humidity":81,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":1.16,"deg":309.007},"sys":{"pod":"n"},"dt_txt":"2016-07-15 03:00:00"},{"dt":1468562400,"main":{"temp":288.749,"temp_min":288.749,"temp_max":288.749,"pressure":1018.89,"sea_level":1028.74,"grnd_level":1018.89,"humidity":85,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":1.21,"deg":0.50058},"sys":{"pod":"d"},"dt_txt":"2016-07-15 06:00:00"},{"dt":1468573200,"main":{"temp":302.582,"temp_min":302.582,"temp_max":302.582,"pressure":1019.41,"sea_level":1029.2,"grnd_level":1019.41,"humidity":37,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":1.98,"deg":112.001},"sys":{"pod":"d"},"dt_txt":"2016-07-15 09:00:00"},{"dt":1468584000,"main":{"temp":306.855,"temp_min":306.855,"temp_max":306.855,"pressure":1019.22,"sea_level":1029.05,"grnd_level":1019.22,"humidity":33,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":3.78,"deg":202.01},"sys":{"pod":"d"},"dt_txt":"2016-07-15 12:00:00"},{"dt":1468594800,"main":{"temp":306.723,"temp_min":306.723,"temp_max":306.723,"pressure":1018.86,"sea_level":1028.61,"grnd_level":1018.86,"humidity":31,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":4.65,"deg":234.003},"sys":{"pod":"d"},"dt_txt":"2016-07-15 15:00:00"},{"dt":1468605600,"main":{"temp":304.613,"temp_min":304.613,"temp_max":304.613,"pressure":1018.27,"sea_level":1028.12,"grnd_level":1018.27,"humidity":30,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":3.57,"deg":264.001},"sys":{"pod":"d"},"dt_txt":"2016-07-15 18:00:00"},{"dt":1468616400,"main":{"temp":296.803,"temp_min":296.803,"temp_max":296.803,"pressure":1019.11,"sea_level":1028.96,"grnd_level":1019.11,"humidity":50,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":1.61,"deg":262.502},"sys":{"pod":"n"},"dt_txt":"2016-07-15 21:00:00"},{"dt":1468627200,"main":{"temp":290.677,"temp_min":290.677,"temp_max":290.677,"pressure":1019.58,"sea_level":1029.49,"grnd_level":1019.58,"humidity":81,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":1.4,"deg":278.5},"sys":{"pod":"n"},"dt_txt":"2016-07-16 00:00:00"},{"dt":1468638000,"main":{"temp":287.738,"temp_min":287.738,"temp_max":287.738,"pressure":1019.11,"sea_level":1029.02,"grnd_level":1019.11,"humidity":92,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":1.22,"deg":282.5},"sys":{"pod":"n"},"dt_txt":"2016-07-16 03:00:00"},{"dt":1468648800,"main":{"temp":286.828,"temp_min":286.828,"temp_max":286.828,"pressure":1019.44,"sea_level":1029.35,"grnd_level":1019.44,"humidity":93,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":1.17,"deg":291},"sys":{"pod":"d"},"dt_txt":"2016-07-16 06:00:00"},{"dt":1468659600,"main":{"temp":296.027,"temp_min":296.027,"temp_max":296.027,"pressure":1019.74,"sea_level":1029.6,"grnd_level":1019.74,"humidity":61,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":1.81,"deg":316.501},"sys":{"pod":"d"},"dt_txt":"2016-07-16 09:00:00"},{"dt":1468670400,"main":{"temp":303.804,"temp_min":303.804,"temp_max":303.804,"pressure":1019.41,"sea_level":1029.32,"grnd_level":1019.41,"humidity":38,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":4.32,"deg":330.004},"sys":{"pod":"d"},"dt_txt":"2016-07-16 12:00:00"},{"dt":1468681200,"main":{"temp":303.992,"temp_min":303.992,"temp_max":303.992,"pressure":1018.72,"sea_level":1028.47,"grnd_level":1018.72,"humidity":34,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":6.06,"deg":329.5},"sys":{"pod":"d"},"dt_txt":"2016-07-16 15:00:00"},{"dt":1468692000,"main":{"temp":300.482,"temp_min":300.482,"temp_max":300.482,"pressure":1018.31,"sea_level":1028.13,"grnd_level":1018.31,"humidity":35,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01d"}],"clouds":{"all":0},"wind":{"speed":7.16,"deg":339.003},"sys":{"pod":"d"},"dt_txt":"2016-07-16 18:00:00"},{"dt":1468702800,"main":{"temp":294.187,"temp_min":294.187,"temp_max":294.187,"pressure":1019.39,"sea_level":1029.23,"grnd_level":1019.39,"humidity":54,"temp_kf":0},"weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],"clouds":{"all":0},"wind":{"speed":6.71,"deg":344.501},"sys":{"pod":"n"},"dt_txt":"2016-07-16 21:00:00"}]}