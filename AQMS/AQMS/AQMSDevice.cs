using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQMS
{
    [Serializable]
    public class Device
    {
        /// <summary>
        /// 设备英文缩写名称
        /// </summary>
        public string devName { get; set; }
        /// <summary>
        /// 设备中文名称
        /// </summary>
        public string devChName { get; set; }
        /// <summary>
        /// 设备型号
        /// </summary>
        public string devMode { get; set; }
        /// <summary>
        /// 设备串口
        /// </summary>
        public ComPort devCom { get; set; }
        /// <summary>
        /// 设备类型：1、气态污染物；2、颗粒物；3、气象参数；4、其他
        /// </summary>
        public int devType { get; set; }
        /// <summary>
        /// 设备包含的监测因子数
        /// </summary>
        public int childNum { get; set; }
        /// <summary>
        /// 设备的监测因子List
        /// </summary>
        public List<AirItem> childs { get; set; }
    }

    [Serializable]
    public class ComPort
    {
        public int portIndex { get; set; }
        public string baudRate { get; set; }
        public string dataBit { get; set; }
        public string stopBit { get; set; }
        public string parityBit { get; set; }
    }

    [Serializable]
    public class AirItem
    {        
        /// <summary>
        /// 监测因子中文名称
        /// </summary>
        public string childChName { get; set; }
        /// <summary>
        /// 监测因子英文缩写名称
        /// </summary>
        public string childName { get; set; }
        /// <summary>
        /// 监测因子数据库中字段名称
        /// </summary>
        public string dataName { get; set; }
        /// <summary>
        /// 监测因子主界面显示单位
        /// </summary>
        public string showUnit { get; set; }
        /// <summary>
        /// 监测因子是否统计AQI
        /// </summary>
        public bool hasAQI { get; set; }
        /// <summary>
        /// 监测因子入库测量值，单位（ug/m3）
        /// </summary>
        public double dataValue { get; set; }
        /// <summary>
        /// 数据状态：0(仪器正常)，1(串口错误)，2(连接错误)，3(零点校准)，
        /// 4(跨度校准)，5(零点检查)，6(跨度检查)，7(数据异常), 
        /// 8(多点检查), 9(精密度检查), 10(示值误差检查), 11(维护)
        /// </summary>
        public int dataStatues { get; set; }

    }

    public class AirDevice
    {
        public static List<Device> m_Device = new List<Device>();
    }
}
