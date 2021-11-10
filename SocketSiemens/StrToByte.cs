using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.cn.DataConvertHelper;

namespace SocketSiemens
{
    class StrToByte
    {
        public byte[] StringTobyte(TextWrite.Parse value_type,string value)
        { 
            byte[] buffer=new byte[4] ;
            byte[] array = new byte[4];
            switch (value_type)
            {
                case TextWrite.Parse.Bool:
                    bool[] a = { false };
                    a[0] = bool.Parse(value);
                    buffer = ByteArrayLib.GetByteArrayFromBoolArray(a);
                    break;
                case TextWrite.Parse.Short:
                    buffer = ByteArrayLib.GetByteArrayFromShort(short.Parse(value));
                    break;
                case TextWrite.Parse.Int:
                    buffer = ByteArrayLib.GetByteArrayFromInt(int.Parse(value));
                    break;
                case TextWrite.Parse.Float:
                    buffer = ByteArrayLib.GetByteArrayFromFloat(float.Parse(value));
                    break;
                case TextWrite.Parse.Uint:
                    buffer = ByteArrayLib.GetByteArrayFromUInt(uint.Parse(value));
                    break;
                default:
                    break;

            }
            return buffer;
           
        }

    
    }
}
