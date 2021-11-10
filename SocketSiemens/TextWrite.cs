using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.cn.DataConvertHelper;

namespace SocketSiemens
{
    public partial class TextWrite : UserControl
    {
        public TextWrite()
        {
            InitializeComponent();
        }

        public int Start { get; set; }

        public int Offset { get; set; }

        public Parse Datatype { get; set; }
        public string VarValue
        {
            get { return this.textBox1.Text;}
            set
            {
                
                this.textBox1.Text = value;
            }


        }

        public enum Parse
        {
            Bool = 0,
            Short = 1,
            Int = 2,
            Float = 3,
            Uint = 4
        }
    }
}
