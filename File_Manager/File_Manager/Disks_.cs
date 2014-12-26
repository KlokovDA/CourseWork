using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace File_Manager
{
    public class Disks_
    {
        public long freeSpace;//свободное место
        public string driveFormat;//имя файловой системы (FAT32)
        public string name;//name диска
        public long totalSize;// общий размер области хранения на диске
    }
}
