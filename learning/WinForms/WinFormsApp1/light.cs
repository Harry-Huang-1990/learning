using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WinFormsApp1
{
     class Light
    {
        private Label _lightLabel;

        public Light(Label label)
        {
            _lightLabel = label;
            Off();

        }

        public void Red() => _lightLabel.BackColor = Color.Red;

        public void Green() => _lightLabel.BackColor = Color.Green;

        public void Off() => _lightLabel.BackColor = Color.LightGray;


    }
}
