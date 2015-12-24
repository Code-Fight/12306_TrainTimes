using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainTimeEntity.TrainStation
{
    /// <summary>
    /// 车站 实体
    /// </summary>
    public  class TrainStationEntity
    {
        /// <summary>
        /// 站码
        /// </summary>
        public string StationCode { get; set; }
        /// <summary>
        /// 站名
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 未知代码
        /// </summary>
        public string XCode { get; set; }
        /// <summary>
        /// 站名全拼
        /// </summary>
        public string StationQP { get; set; }
        /// <summary>
        /// 站名简拼
        /// </summary>
        public string StationJP { get; set; }
        /// <summary>
        /// 站编号
        /// </summary>
        public string StationNumber { get; set; }

    }
}
