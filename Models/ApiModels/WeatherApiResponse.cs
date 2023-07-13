using System.Text.Json.Serialization;

namespace MauiWeatherApp.Models.ApiModels;

public class WeatherApiResponse
{
    [JsonPropertyName("request")]
    public WeatherApiResponseRequest Request { get; set; }

    [JsonPropertyName("location")]
    public WeatherApiResponseLocation Location { get; set; }

    [JsonPropertyName("current")]
    public WeatherApiResponseCurrent Current { get; set; }
}

public class WeatherApiResponseRequest
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }
}

public class WeatherApiResponseLocation
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("lat")]
    public string Latitude { get; set; }

    [JsonPropertyName("lon")]
    public string Longitude { get; set; }

    [JsonPropertyName("timezone_id")]
    public string TimeZoneId { get; set; }

    [JsonPropertyName("localtime")]
    public string LocalTime { get; set; }

    [JsonPropertyName("localtime_epoch")]
    public int LocalTimeEpoch { get; set; }

    [JsonPropertyName("utc_offset")]
    public string UtcOffset { get; set; }
}

public class WeatherApiResponseCurrent
{
    [JsonPropertyName("observation_time")]
    public string ObservationTime { get; set; }

    [JsonPropertyName("temperature")]
    public int Temperature { get; set; }

    [JsonPropertyName("weather_code")]
    public int WeatherCode { get; set; }

    [JsonPropertyName("weather_icons")]
    public string[] WeatherIcons { get; set; }

    [JsonPropertyName("weather_descriptions")]
    public string[] WeatherDescriptions { get; set; }

    [JsonPropertyName("wind_speed")]
    public int WindSpeed { get; set; }

    [JsonPropertyName("wind_degree")]
    public int WindDegree { get; set; }

    [JsonPropertyName("wind_dir")]
    public string WindDirection { get; set; }

    [JsonPropertyName("pressure")]
    public int Pressure { get; set; }

    [JsonPropertyName("precip")]
    public float PrecipitationLevel { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("cloudcover")]
    public int CloudCoverLevel { get; set; }

    [JsonPropertyName("feelslike")]
    public int FeelsLike { get; set; }

    [JsonPropertyName("uv_index")]
    public int UvIndex { get; set; }

    [JsonPropertyName("visibility")]
    public int Visibility { get; set; }

    [JsonPropertyName("is_day")]
    public string IsDay { get; set; }
}

