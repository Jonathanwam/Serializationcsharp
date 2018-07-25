using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace Serialization
{
    [Serializable]
    public class Customer
    {
        public int id;
        public String info;
    }
}
