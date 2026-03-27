namespace DAL
{
    public class CRC16
    {
        public static byte[] Crc16(byte[] data)
        {




            int len = data.Length;



            int crc = 0xffff;
            for (int i = 0; i < len; i++)
            {
                crc ^= data[i];
                int n = 0;
                for (int j = 0; j < 8; j++)
                {
                    int temp;
                    temp = crc & 1;
                    crc >>= 1;
                    crc = crc & 0x7fff;
                    if (temp == 1)
                    {
                        crc = crc ^ 0xa001;
                    }
                    crc = crc & 0xffff;

                }

            }
            byte[] crc16 = new byte[data.Length + 2];
            Array.Copy(data, crc16, data.Length);

            crc16[data.Length] = (byte)(crc & 0xff);
            crc16[data.Length + 1] = (byte)((crc >> 8) & 0xff);


            return crc16;
        }
    }
}
