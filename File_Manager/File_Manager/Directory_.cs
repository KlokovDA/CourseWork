using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace File_Manager
{
    public class Directory_:IComparable<Directory_>
    {
        public string name;
        public string type;
        public string data;
        public string sortdata;
        public string fullname;
        public string Attributes;
        
        public int CompareTo(Directory_ item)
        {
            if (FM.Up_Down == "up")
            {
                switch (FM.sortby)
                {
                    case 1: { return this.sortdata.CompareTo(item.sortdata); }
                    default: { return this.name.CompareTo(item.name); }
                }
            }
            else
            {
                switch (FM.sortby)
                {
                    case 1: { return item.sortdata.CompareTo(this.sortdata); }
                    default: { return item.name.CompareTo(this.name); }
                }
            }
        }
    }
}
