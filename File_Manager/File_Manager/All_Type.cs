using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Manager
{
    public class All_Type
    {
       public List<Files_> list_files;
       public List<Directory_> list_dir;
       public List<Disks_> list_disks;
       public All_Type()
       { 
           list_files = new List<Files_>();
           list_dir = new List<Directory_>();
           list_disks = new List<Disks_>();
       }
    }
}
