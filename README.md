In this project, I integrated weather API from OpenWeatherMap.org. The data from the API is in JSON.
First, I created a folder in Shared section by the name of Models. In this folder, I created a file named WeatherData.cs in which I created a public class named WeatherData and assigned the properties that I needed to extract from the API.
Secondly, I created another folder by the name of Service in Shared section. In this folder, I created a file named WeatherService.cs in which I created a function GetWeather() to parse data coming from the API, in the form of JSON, to an object or instance of public class WeatherData. Then, I converted the file WeatherService.cs as a service by giving its reference in the Program.cs file located in Client section.
In the end, I created two files in Pages folder of the Client section by the name of WeatherDisplay.razor.css (for styling) and WeatherDisplay.razor and called the service “WeatherService”, fetched the API’s data in an object of WeatherData class. This page also contains an input part and a weather part. When the user enters the name of the desired city whose weather conditions, he/she wants to view and press the submit button, the weather of that city is displayed. 
