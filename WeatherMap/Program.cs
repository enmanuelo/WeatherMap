using Newtonsoft.Json.Linq;

var client = new HttpClient();
var key = "c7929052a9b849513f5679a3dd8e32d3";
var city = "Compton";
var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";
var response = client.GetStringAsync(weatherURL).Result;

JObject jsonResponse = JObject.Parse(response);
var temp = jsonResponse["list"][0]["main"]["temp"];
var feelsLike = jsonResponse["list"][0]["main"]["feels_like"];
Console.WriteLine($"It is {temp} degrees in Compton, California, but feels like {feelsLike}.");