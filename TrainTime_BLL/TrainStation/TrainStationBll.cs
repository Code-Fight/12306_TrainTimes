using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainTimeEntity.TrainStation;
using TrainTime_BLL.HTTP;

namespace TrainTime_BLL.TrainStation
{
    /// <summary>
    /// 获取车站信息
    /// </summary>
    public class TrainStationBll
    {

        /// <summary>
        /// 取站点名数组
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public string[] GetStationNameArry(List<TrainStationEntity> list)
        {
            try
            {
                if (list == null || list.Count == 0)
                {
                    return null;
                }
                string[] ret = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    ret[i] =list[i].StationJP+"-"+list[i].StationName;
                }
                return ret;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取所有的车站
        /// </summary>
        /// <returns></returns>
        public List<TrainStationEntity> GetAllStation()
        {
            HttpBll httpBll = new HttpBll();

            string station = httpBll.GetStationName();
            station = station.Substring(station.IndexOf('\'') + 1, station.LastIndexOf('\'') - station.IndexOf('\'') - 1);
            List<TrainStationEntity> ret = new List<TrainStationEntity>();
            foreach (var temp in station.Split('@'))
            {
                if (temp == "")
                {
                    continue;
                }


                TrainStationEntity model = new TrainStationEntity()
                {
                    StationCode = temp.Split('|')[0].ToString(),
                    StationName = temp.Split('|')[1].ToString(),
                    XCode = temp.Split('|')[2].ToString(),
                    StationQP = temp.Split('|')[3].ToString(),
                    StationJP = temp.Split('|')[4].ToString(),
                    StationNumber = temp.Split('|')[5].ToString()
                };
                ret.Add(model);

            }
            return ret;
        }

        /// <summary>
        /// 通过车站名称获获取车站码
        /// </summary>
        /// <returns></returns>
        public void GetCodeByStationName(string name, out string stationcode, out string xcode,
            List<TrainStationEntity> list_station)
        {
            stationcode = string.Empty;
            xcode = string.Empty;
            foreach (var trainStationEntity in list_station)
            {
                if (trainStationEntity.StationName.Trim() == name.Trim())
                {
                    stationcode = trainStationEntity.StationCode;
                    xcode = trainStationEntity.XCode;
                    return;
                }
            }
        }
    }
}
