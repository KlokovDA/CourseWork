using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace File_Manager
{
    public class Files_:IComparable<Files_>
    {
        public string name;
        public string type;
        public string data;
        public string sortdata;
        public string fullname;
        public long size;
        public string Attributes;
        public Icon icon;
        public string Extension;

       
        public int CompareTo(Files_ item)
        {
            if (FM.Up_Down == "up")
            {
                switch (FM.sortby)
                {
                    case 1: { return this.sortdata.CompareTo(item.sortdata); }
                    case 2: { return this.size.CompareTo(item.size); }
                    default: { return this.name.CompareTo(item.name); }
                }
            }
            else
            {
                switch (FM.sortby)
                {
                    case 1: { return item.sortdata.CompareTo(this.sortdata); }
                    case 2: { return item.size.CompareTo(this.size); }
                    default: { return item.name.CompareTo(this.name); }
                }
            }
        }
    }
}
