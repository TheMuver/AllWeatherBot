using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AllWeatherBot
{
    /// <summary>
    /// Хранит информацию о погоде.
    /// </summary>
    public class Weather
    {
        [JsonProperty("now")]
        public int Now { get; set; }

        [JsonProperty("now_dt")]
        public DateTime NowDt { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("geo_object")]
        public GeoObject GeoObject { get; set; }

        [JsonProperty("yesterday")]
        public Yesterday Yesterday { get; set; }

        [JsonProperty("fact")]
        public Fact Fact { get; set; }

        [JsonProperty("forecasts")]
        public List<Forecast> Forecasts { get; set; }
    }

    public class Tzinfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("dst")]
        public bool Dst { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class Info
    {
        [JsonProperty("n")]
        public bool N { get; set; }

        [JsonProperty("geoid")]
        public int Geoid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("tzinfo")]
        public Tzinfo TzInfo { get; set; }

        [JsonProperty("def_pressure_mm")]
        public int DefPressureMm { get; set; }

        [JsonProperty("def_pressure_pa")]
        public int DefPressurePa { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("zoom")]
        public int Zoom { get; set; }

        [JsonProperty("nr")]
        public bool Nr { get; set; }

        [JsonProperty("ns")]
        public bool Ns { get; set; }

        [JsonProperty("nsr")]
        public bool Nsr { get; set; }

        [JsonProperty("p")]
        public bool P { get; set; }

        [JsonProperty("f")]
        public bool F { get; set; }

        [JsonProperty("_h")]
        public bool H { get; set; }
    }

    public class District
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Locality
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Province
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GeoObject
    {
        [JsonProperty("district")]
        public District District { get; set; }

        [JsonProperty("locality")]
        public Locality Locality { get; set; }

        [JsonProperty("province")]
        public Province Province { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }
    }

    public class Yesterday
    {
        [JsonProperty("temp")]
        public int Temp { get; set; }
    }

    public class AccumPrec
    {
        [JsonProperty("7")]
        public double _7 { get; set; }

        [JsonProperty("1")]
        public double _1 { get; set; }

        [JsonProperty("3")]
        public double _3 { get; set; }
    }

    public class Fact
    {
        [JsonProperty("obs_time")]
        public int ObsTime { get; set; }

        [JsonProperty("uptime")]
        public int Uptime { get; set; }

        [JsonProperty("temp")]
        public int Temp { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_strength")]
        public int PrecStrength { get; set; }

        [JsonProperty("is_thunder")]
        public bool IsThunder { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("accum_prec")]
        public AccumPrec AccumPrec { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }
    }

    public class Night
    {
        [JsonProperty("_source")]
        public string Source { get; set; }

        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }

        [JsonProperty("temp_max")]
        public int TempMax { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public double PrecMm { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public double PrecStrength { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }
    }

    public class Day
    {
        [JsonProperty("_source")]
        public string Source { get; set; }

        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }

        [JsonProperty("temp_max")]
        public int TempMax { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public int PrecMm { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public int PrecStrength { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }
    }

    public class Evening
    {
        [JsonProperty("_source")]
        public string Source { get; set; }

        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }

        [JsonProperty("temp_max")]
        public int TempMax { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public double PrecMm { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public double PrecStrength { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }
    }

    public class Morning
    {
        [JsonProperty("_source")]
        public string Source { get; set; }

        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }

        [JsonProperty("temp_max")]
        public int TempMax { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public int PrecMm { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public int PrecStrength { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }
    }

    public class NightShort
    {
        [JsonProperty("_source")]
        public string Source { get; set; }

        [JsonProperty("temp")]
        public int Temp { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public double PrecMm { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public double PrecStrength { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }
    }

    public class DayShort
    {
        [JsonProperty("_source")]
        public string Source { get; set; }

        [JsonProperty("temp")]
        public int Temp { get; set; }

        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public double PrecMm { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public double PrecStrength { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("daytime")]
        public string Daytime { get; set; }

        [JsonProperty("polar")]
        public bool Polar { get; set; }
    }

    public class Parts
    {
        [JsonProperty("night")]
        public Night Night { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }

        [JsonProperty("evening")]
        public Evening Evening { get; set; }

        [JsonProperty("morning")]
        public Morning Morning { get; set; }

        [JsonProperty("night_short")]
        public NightShort NightShort { get; set; }

        [JsonProperty("day_short")]
        public DayShort DayShort { get; set; }
    }

    public class Hour
    {
        [JsonProperty("hour")]
        public string HourStr { get; set; }

        [JsonProperty("hour_ts")]
        public int HourTs { get; set; }

        [JsonProperty("temp")]
        public int Temp { get; set; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }

        [JsonProperty("prec_type")]
        public int PrecType { get; set; }

        [JsonProperty("prec_strength")]
        public double PrecStrength { get; set; }

        [JsonProperty("is_thunder")]
        public bool IsThunder { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        [JsonProperty("prec_mm")]
        public double PrecMm { get; set; }

        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }
    }

    public class Biomet
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }

    public class Forecast
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("date_ts")]
        public int DateTs { get; set; }

        [JsonProperty("week")]
        public int Week { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("rise_begin")]
        public string RiseBegin { get; set; }

        [JsonProperty("set_end")]
        public string SetEnd { get; set; }

        [JsonProperty("moon_code")]
        public int MoonCode { get; set; }

        [JsonProperty("moon_text")]
        public string MoonText { get; set; }

        [JsonProperty("parts")]
        public Parts Parts { get; set; }

        [JsonProperty("hours")]
        public List<Hour> Hours { get; set; }

        [JsonProperty("biomet")]
        public Biomet Biomet { get; set; }
    }
}