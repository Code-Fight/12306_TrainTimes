using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FTools.Encode;
using FTools.HTTP;
using TrainTimeEntity.TrainStation;
using TrainTime_BLL.HTTP;
using TrainTime_BLL.TrainStation;
using TrainTime_BLL.TrainTime;

namespace TrainTime
{
    public partial class Form1 : Form
    {
        private List<TrainStationEntity> list_trianstation { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            Station_AutoComplete();
            GetVerCode();
        }

        private void Station_AutoComplete()
        {
            
            //TODO:测试
            TrainStationBll trainStationBll=new TrainStationBll();
            list_trianstation = trainStationBll.GetAllStation();
            txt_station_name.AutoCompleteCustomSource.AddRange(trainStationBll.GetStationNameArry(list_trianstation));
            txt_station_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_station_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetVerCode()
        {
            HttpBll httpBll=new HttpBll();
            pictureBox1.Image = httpBll.GetVerCode();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetVerCode();
        }

        private void btn_GetTrainTime_Click(object sender, EventArgs e)
        {
            string stationname = txt_station_name.Text.Trim()
                .Substring(txt_station_name.Text.Trim().IndexOf('-') + 1,
                    txt_station_name.Text.Trim().Length - txt_station_name.Text.Trim().IndexOf('-')-1);
            HttpBll httpBll=new HttpBll();
            if (!httpBll.CheckVerCode(txt_vercode.Text.Trim()))
            {
                MessageBox.Show("验证码错误,请重新输入");
                GetVerCode();
                return;
            }
            if (!httpBll.CheckVerCode(txt_vercode.Text.Trim()))
            {
                MessageBox.Show("验证码错误,请重新输入");
                GetVerCode();
                return;
            }
            TrainStationBll trainStationBll=new TrainStationBll();
            string stationCode;
            string xcode;
            trainStationBll.GetCodeByStationName(stationname.Trim(), out stationCode, out xcode, list_trianstation);
            if (stationCode.Length==0)
            {
                MessageBox.Show("车站不存在,请重新输入");
                return;
            }
            TrainTimeBll trainTimeBll=new TrainTimeBll();
            DataTable retTable= trainTimeBll.GetTrainTime(DateTime.Parse(dateTimePicker1.Text), txt_vercode.Text, stationname,
                stationCode,xcode);
            dgv_trainlist.DataSource = retTable;

            GetVerCode();
        }
        

    }
}