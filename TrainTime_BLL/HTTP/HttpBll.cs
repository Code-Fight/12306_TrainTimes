using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using FTools.HTTP;
using System.Drawing;
using FTools.Encode;

namespace TrainTime_BLL.HTTP
{
    /// <summary>
    ///     http 操作逻辑
    /// </summary>
    public class HttpBll
    {
        private static CookieContainer cc = new CookieContainer();
        private string CerPath = string.Empty;
        public HttpBll()
        {
            //初始化的时候 检测12306的证书
            var path = Environment.CurrentDirectory + "\\12306";
            CerPath = path + "\\12306.cer";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(CerPath))
            {
                FileStream fs = new FileStream(CerPath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                try
                {
                    sw.Write(Resource1.srca);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }
            }
            CerPath = CerPath.Replace("\\", @"\");
        }

        /// <summary>
        ///     获取所有的车站
        /// </summary>
        /// <returns></returns>
        public string GetStationName()
        {
            try
            {
                var url = "https://kyfw.12306.cn/otn/resources/js/framework/station_name.js"; //请求地址
                var res = string.Empty; //请求结果,请求类型不是图片时有效
                var helper = new HttpHelpers(); //发起请求对象
                var items = new HttpItems(); //请求设置对象
                var hr = new HttpResults(); //请求结果
                items.URL = url; //设置请求地址
                items.CerPath = CerPath;
                items.Container = cc; //自动处理Cookie时,每次提交时对cc赋值即可
                hr = helper.GetHtml(items); //发起请求并得到结果
                res = hr.Html; //得到请求结果
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        public Image GetVerCode()
        {
            //First get init cookie
            string url = "https://kyfw.12306.cn/otn/czxx/init";//请求地址
            HttpHelpers helper = new HttpHelpers();//发起请求对象
            HttpItems items = new HttpItems();//请求设置对象
            items.URL = url;//设置请求地址
            items.Container = cc;//自动处理Cookie时,每次提交时对cc赋值即可
            helper.GetHtml(items);//发起请求并得到结果

            //Next get vercode with init cookie
            url = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=other&rand=sjrand&0.9220453924847556";//请求地址
            items.Container = cc;
            items.URL = url;//设置请求地址
            items.ResultType = ResultType.Byte;//设置请求返回值类型为Byte
            return helper.GetImg(helper.GetHtml(items));//picImage图像控件Name

        }

        /// <summary>
        /// 验证码效验
        /// </summary>
        /// <param name="vercode"></param>
        /// <returns></returns>
        public bool CheckVerCode(string vercode)
        {
            string url = "https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn"; //请求地址
            HttpHelpers helper = new HttpHelpers(); //发起请求对象
            HttpItems items = new HttpItems(); //请求设置对象
            items.URL = url; //设置请求地址
            items.Container = cc; //自动处理Cookie时,每次提交时对cc赋值即可
            items.Method = "Post";
            items.Postdata = "randCode=" + vercode + "&rand=sjrand";
            string res = helper.GetHtml(items).Html; //发起请求并得到结果
            if (res.IndexOf("randCodeRight", StringComparison.Ordinal) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取列车时刻表
        /// </summary>
        /// <returns></returns>
        public string GetTrainTime(DateTime sTime, string verCode, string stationName, string stationCode,string xcode)
        {
            try
            {
                string url = "https://kyfw.12306.cn/otn/czxx/query?"
                             + "train_start_date=" + sTime.ToString("yyyy-MM-dd")
                             + "&train_station_name=" + Encode.UrlEncode(stationName)
                             + "&train_station_code=" + xcode
                             + "&randCode=" + verCode;//请求地址
                HttpHelpers helper = new HttpHelpers();//发起请求对象
                
                //添加cookie
                //Cookie ck=new Cookie("_jc_save_czxxcx_toStation", (Encode.UnicodeEn(stationName) + Encode.UrlEncode(",") + xcode).Replace("\\", @"%"));
                //ck.Domain
                //cc.Add(new Cookie("_jc_save_czxxcx_toStation", (Encode.UnicodeEn(stationName) + Encode.UrlEncode(",") + xcode).Replace("\\", @"%"), "/", @"kyfw.12306.cn"));
                //cc.Add(new Cookie("_jc_save_czxxcx_fromDate", sTime.ToString("yyyy-MM-dd"), "/", "kyfw.12306.cn"));


                //string ck= new XJHTTP().CookieTostring(cc);
                //ck += "_jc_save_czxxcx_toStation=" +
                //      (Encode.UnicodeEn(stationName) + Encode.UrlEncode(",") + xcode).Replace("\\", @"%");
                //ck += ";_jc_save_czxxcx_fromDate=" + sTime.ToString("yyyy-MM-dd");
                //cc = new XJHTTP().StringToCookie("kyfw.12306.cn", ck);
                HttpItems items = new HttpItems       //请求设置对象
                {
                    URL = url,
                    Container = cc,
                    Referer = @"https://kyfw.12306.cn/otn/czxx/init"
                }; 
                //设置请求地址
                //自动处理Cookie时,每次提交时对cc赋值即可
                string ret= helper.GetHtml(items).Html;//发起请求并得到结果
                return ret;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}