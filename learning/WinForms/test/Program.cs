namespace test
{
    internal class Test
    {
        static void Main()
        {
            //byte[] data_1 = { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01 };
            //byte[] data_crc16 = Crc16(data_1);

            //Console.WriteLine(BitConverter.ToString(data_crc16));
        }


        #region 高低位转换

        //int data = 0x1234;
        //byte[] data2 = new byte[2];
        //data2[0] = (byte)((data- data % 256)/256);
        //data2[1] = (byte)(data % 256);
        //int[] data3 = new int[2];
        //data3[0] = data&0xff;
        //data3[1] = (data >> 8) & 0xff;


        //string c = data.ToString("X4");
        //    Console.WriteLine($"data(0x)={c}");

        //foreach (byte b in data2)
        //{
        //    string d = b.ToString("X4");
        //    Console.WriteLine($"data2(0x)={d}");
        //}
        //foreach (int b in data3)
        //{
        //    string e = b.ToString("X4");
        //    Console.WriteLine($"data3(0x)={e}");
        //}
        #endregion

        #region CRC16校验
        //string inPut = "010300000001"; 
        //int len = inPut.Length/2;   //每两个字符转换成一个字节,所以长度除以2
        //byte[] inPut_U8 = new byte[len];    //创建一个字节数组来存储转换后的结果,长度为len
        //for (int i = 0; i < len; i++)
        //{
        //    inPut_U8[i] = Convert.ToByte(inPut.Substring(i*2, length: 2), fromBase: 16);//从输入字符串中每两个字符提取出来,转换成一个字节,存储到字节数组中
        //}

        ////foreach (byte item in inPut_U8)
        ////{
        ////    Console.WriteLine(item);
        ////}
        //ushort crc16 = 0xffff;
        //for (int i = 0; i < len; i++)
        //{
        //    crc16 ^= inPut_U8[i];
        //    int n = 0;
        //    while (n < 8)
        //    {

        //        bool a = ( crc16 & 0x0001) == 1; 
        //        crc16 = (ushort)((crc16 >> 1));
        //        if (a)
        //        {
        //            crc16 ^= 0xa001;
        //            n++;

        //        }
        //        else 
        //        {
        //            n++;
        //        }

        //    }
        //}
        //crc16 = (ushort)(((crc16 & 0x00ff) << 8) | ((crc16 & 0xff00) >> 8));
        //Console.WriteLine(crc16.ToString("x4"));
        #endregion


        #region CRC16另一种方式

        //byte[] inPut = { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01 };

        //public static byte[] Crc16(byte[] data)
        //{

        //    int len = data.Length;

        //    int crc = 0xffff;
        //    for (int i = 0; i < len; i++)
        //    {
        //        crc ^= data[i];
        //        int n = 0;
        //        for (int j = 0; j < 8; j++)
        //        {
        //            int temp;
        //            temp = crc & 1;
        //            crc >>= 1;
        //            crc = crc & 0x7fff;
        //            if (temp == 1)
        //            {
        //                crc = crc ^ 0xa001;
        //            }
        //            crc = crc & 0xffff;

        //        }

        //    }
        //    byte[] crc16 = new byte[data.Length + 2];
        //    Array.Copy(data, crc16, data.Length);

        //    crc16[data.Length] = (byte)(crc & 0xff);
        //    crc16[data.Length + 1] = (byte)((crc >> 8) & 0xff);

        //    return crc16;
        //}

        #endregion












    }
}
