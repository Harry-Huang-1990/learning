using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.IO.Ports;

namespace WinFormsApp1
{
    public partial class FormModbus : Form
    {
        public FormModbus()
        {
            InitializeComponent();
        }
        Modbus objMod = new Modbus();

        private void btn_Connect_Click(object sender, EventArgs e)

        {
            if (objMod.OpenMyComm(9600, "COM1", 8, Parity.None, StopBits.One))
            {
                Light light = new Light(label1);
                light.Green();
            }
            else
            {
                Light light = new Light(label1);
                light.Red();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] Res = objMod.ReadKeepReg(1, 0, 10);
            list_ReedReg_mes.Items.Clear();
            for (int i = 0; i < Res.Length; i++)
            {
                list_ReedReg_mes.Items.Add(Res[i].ToString("X2"));
            }
        }

        private void list_ReedReg_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
