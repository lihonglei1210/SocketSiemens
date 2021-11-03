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
    public partial class TextShow : UserControl
    {
        public TextShow()
        {
            InitializeComponent();
        }

        public int Start { get; set; }

        public int Offset { get; set; }

        public DataType Datatype { get; set; }

        private string varValue;

        public string VarValue
        {
            get { return varValue; }
            set { varValue = value;

                this.textBox1.Text = value;
            }

            
        }

    }
}
