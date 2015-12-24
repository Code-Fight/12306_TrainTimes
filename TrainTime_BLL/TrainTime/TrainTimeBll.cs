using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FTools.HTTP;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TrainTime_BLL.HTTP;

namespace TrainTime_BLL.TrainTime
{
    public class TrainTimeBll
    {
        
        public DataTable GetTrainTime(DateTime sTime, string verCode, string stationName, string stationCode,string xcode)
        {
            HttpBll httpBll=new HttpBll();
            string retHtml= httpBll.GetTrainTime(sTime, verCode, stationName, stationCode, xcode);
            JObject json=JObject.Parse(retHtml);
            JObject firstData = JObject.Parse(json["data"].ToString());
            JArray dataJson = JArray.Parse(firstData["data"].ToString());
            if (dataJson.Count==0)
            {
                return null;
            }
            DataTable dt=new DataTable();
            dt.Columns.Add("number", typeof(string));
            dt.Columns.Add("traincode", typeof (string));
            dt.Columns.Add("level", typeof(string));
            dt.Columns.Add("StartStation", typeof(string));
            dt.Columns.Add("endStation", typeof(string));
            dt.Columns.Add("startTime", typeof(string));
            dt.Columns.Add("endTime", typeof(string));
            dt.Columns.Add("arrTime", typeof(string));
            dt.Columns.Add("depTime", typeof(string));
            dt.Columns.Add("stationName", typeof(string));
            int index = 1;
            foreach (var temp in dataJson)
            {
                dt.Rows.Add(
                    index,
                    JObject.Parse(temp.ToString())["station_train_code"],
                    JObject.Parse(temp.ToString())["train_class_name"],
                    JObject.Parse(temp.ToString())["start_station_name"],
                    JObject.Parse(temp.ToString())["end_station_name"],
                    JObject.Parse(temp.ToString())["start_start_time"],
                    JObject.Parse(temp.ToString())["end_arrive_time"],
                    JObject.Parse(temp.ToString())["arrive_time"], 
                    JObject.Parse(temp.ToString())["start_time"],
                    JObject.Parse(temp.ToString())["station_name"]
                    );
                index++;
            }
            return dt;
        }
    }
}
