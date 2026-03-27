using System.IO.Ports;

namespace DAL
{
    public class Modbus //类
    {
        //定义串口类的对象
        private SerialPort MyCom; //成员变量
        //定义接收字节数组
        byte[] bData = new byte[1024];
        byte mReceiveByte;
        int mReceiveByteCount = 0;
        //定义设备地址、寄存器地址、寄存器长度等变量
        int CurrentAddr;//当前寄存器地址
        int IMWordLen;
        int IMBitLen;

        string strUpData;//定义一个字符串变量来存储接收到的数据


        //构造函数
        public Modbus() //构造函数
        {
            //新建实例化串口对象
            MyCom = new SerialPort();
        }
        #region 串口操作方法
        /// <summary>
        /// 打开串口方法
        /// </summary>
        /// <参数   名称= "代号">          </参数>
        /// <param name="iBaudRate">波特率</param>
        /// <param name="iPortname">端口名称</param>
        /// <param name="idataBits">数据位</param>
        /// <param name="iParity">奇偶校验</param>
        /// <param name="iStopBits">停止位</param>
        /// <returns>是否成功打开串口</returns>

        //私有非公开方法，返回值为布尔类型，参数为波特率、端口名称、数据位、奇偶校验和停止位
        public bool OpenMyComm(int iBaudRate, string iPortname, int idataBits, Parity iParity, StopBits iStopBits)
        {
            try
            {
                //关闭已经打开的串口
                if (MyCom.IsOpen)
                {
                    MyCom.Close();
                }

                //设置串口的各个属性
                MyCom.BaudRate = iBaudRate;
                MyCom.PortName = iPortname;
                MyCom.DataBits = idataBits;
                MyCom.Parity = iParity;
                MyCom.StopBits = iStopBits;
                MyCom.ReceivedBytesThreshold = 1;
                MyCom.DataReceived += MyCom_DataReceived;


                MyCom.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 关闭串口方法
        /// </summary>
        /// <returns></returns>
        public bool ClosePort()
        {

            if (MyCom.IsOpen)
            {
                MyCom.Close();
                return true;
            }
            else
            {
                return false;
            }


        }
        #endregion
        // 串口数据接收事件处理方法，参数为发送者对象和串口数据接收事件参数
        void MyCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (MyCom.BytesToRead > 0)
            {
                mReceiveByte = (byte)MyCom.ReadByte();
                bData[mReceiveByteCount] = mReceiveByte;
                mReceiveByteCount +=1;
                if (MyCom.BytesToRead > 1024)
                {
                    mReceiveByteCount = 0;
                    //清除串口接收缓冲区
                    MyCom.DiscardInBuffer();
                    return;
                }
            }
            //读取保持型寄存器 功能码0x03
            if (bData[0] == CurrentAddr &&
                bData[1] == 0x03 &&
                mReceiveByteCount >= (IMWordLen * 2 + 5))
            {
                strUpData = "";
                //将接收到的字节数据转换为十六进制字符串，并存储在strUpData变量中
                for (int i = 0; i < IMWordLen * 2 + 5; i++)
                {
                    strUpData = strUpData + " " + bData[i].ToString("X2");
                }
                MyCom.DiscardInBuffer();
                mReceiveByteCount = 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iDevAdd"></param>
        /// <param name="iAddress"></param>
        /// <param name="iLength"></param>
        /// <returns></returns>

        //读取保持型寄存器的方法，参数为设备地址、寄存器地址和寄存器长度，返回值为字节数组
        public byte[] ReadKeepReg(int iDevAdd, int iAddress, int iLength)
        {
            byte[] ResByte = null;
            IMWordLen = iLength;
            CurrentAddr = iDevAdd;
            //第一步拼接报文
            byte[] SendCommand = new byte[6];
            SendCommand[0] = (byte)iDevAdd;
            SendCommand[1] = 0x03;
            SendCommand[2] = (byte)((iAddress >> 8) & 0xff);
            SendCommand[3] = (byte)(iAddress & 0xff);
            SendCommand[4] = (byte)((iLength >> 8) & 0xff);
            SendCommand[5] = (byte)(iLength & 0xff);
            byte[] newSendCommand = CRC16.Crc16(SendCommand);


            //第二步发送报文
            try
            {
                MyCom.Write(newSendCommand, 0, newSendCommand.Length);
            }
            catch (Exception)
            {

                return null;
            }
            //第三部解析报文
            //mReceiveByteCount = 0;
            Thread.Sleep(100);
            ResByte = HexStringToByteArray(this.strUpData);

            return ResByte;
        }

        private byte[] HexStringToByteArray(string S)
        {
            byte[] Res = null;
            if (S != null && S.Length > 5)
            {
                //将输入的十六进制字符串进行处理，去除空格并分割成字符串数组
                string[] str = S.Trim().Split(' ');
                string[] Result = new string[str.Length - 5];
                for (int i = 0; i < str.Length - 5; i++)
                {
                    Result[i] = str[i + 3];
                }

                Res = new byte[Result.Length];
                for (int i = 0; i < Result.Length; i++)
                {
                    Res[i] = Convert.ToByte(Result[i], 16);
                }
            }

            return Res;
        }













    }
}
