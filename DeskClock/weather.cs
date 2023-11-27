//如果好用，请收藏地址，帮忙分享。
using System.Collections.Generic;

public class Location
{
    /// <summary>
    /// 
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// 南京
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string country { get; set; }
    /// <summary>
    /// 南京,南京,江苏,中国
    /// </summary>
    public string path { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string timezone { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string timezone_offset { get; set; }
}

public class DailyItem
{
    /// <summary>
    /// 
    /// </summary>
    public string date { get; set; }
    /// <summary>
    /// 多云
    /// </summary>
    public string text_day { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string code_day { get; set; }
    /// <summary>
    /// 多云
    /// </summary>
    public string text_night { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string code_night { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string high { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string low { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string rainfall { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string precip { get; set; }
    /// <summary>
    /// 东南
    /// </summary>
    public string wind_direction { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string wind_direction_degree { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string wind_speed { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string wind_scale { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string humidity { get; set; }
}

public class ResultsItem
{
    /// <summary>
    /// 
    /// </summary>
    public Location location { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<DailyItem> daily { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string last_update { get; set; }
}

public class Root
{
    /// <summary>
    /// 
    /// </summary>
    public List<ResultsItem> results { get; set; }
}
