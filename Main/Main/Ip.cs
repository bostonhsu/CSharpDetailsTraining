using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Main
{
    public class Ip : IConvertible
    {
        IPAddress _ip;

        public Ip(string ip)
        {
            _ip = IPAddress.Parse(ip);
        }

        public static implicit operator Ip(string ip)
        {
            Ip iptemp = new Ip(ip);
            return iptemp;
        }

        public override string ToString()
        {
            return _ip.ToString();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public string ToString(IFormatProvider provider)
        {
            return _ip.ToString();
        }

        public TypeCode GetTypeCode()
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
        }
    }
}