using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;// directory,fileinfo
using System.Diagnostics; //для Process.Start
using System.Windows.Forms;//для ListView
using System.Drawing;// для icon

namespace File_Manager
{
    public class Func
    {

           public static List<string> forward = new List<string>();
           public static string PathToFile = "";
           public static string PathToFile_copy = "";
           public static string CopyORcut = "";
           public static List<string> COPYorCUT = new List<string>();
           public static bool hidden = false;

           public static All_Type Get_File_Directory_Disk()
            {
               All_Type ALLTYPE = new All_Type();                              //создание обьекта класса All_Type

               if (PathToFile == "")                                           //если мы в начальной директории
                {
                    string[] drivers = Directory.GetLogicalDrives();
                    foreach (string drive in drivers)
                    {
                        Disks_ Disks = new Disks_();
                        DriveInfo fi = new DriveInfo(drive);
                        Disks.freeSpace = fi.AvailableFreeSpace;
                        Disks.driveFormat = fi.DriveFormat;
                        Disks.name = fi.Name;
                        Disks.totalSize = fi.TotalSize;
                        ALLTYPE.list_disks.Add(Disks);
                    }
                }
                else
                {
                    try
                    {
                        string[] dirs = Directory.GetDirectories(PathToFile);
                        foreach (string s in dirs)
                        {
                            Directory_ DY = new Directory_();
                            DY.name = Path.GetFileName(s);
                            DirectoryInfo fi = new DirectoryInfo(PathToFile + "\\" + DY.name);
                            if (fi.Attributes.ToString().Contains("Hidden") == hidden)//показывать ли скрытые
                            {
                                DY.Attributes = fi.Attributes.ToString();
                                DY.data = fi.LastWriteTime.ToShortDateString();
                                DY.sortdata = fi.LastWriteTime.Year.ToString() + fi.LastWriteTime.Month.ToString() + fi.LastWriteTime.Day.ToString();
                                DY.type = fi.Extension;
                                DY.fullname = fi.FullName;
                                ALLTYPE.list_dir.Add(DY);
                            }
                        }

                        string[] files = Directory.GetFiles(PathToFile);
                        foreach (var s in files)
                        {
                            Files_ FS = new Files_();
                            FS.name = Path.GetFileName(s);
                            FileInfo fi = new FileInfo(PathToFile + "\\" + FS.name);
                            if (fi.Attributes.ToString().Contains("Hidden") == hidden)//показывать ли скрытые
                            {
                                FS.Attributes = fi.Attributes.ToString();
                                FS.data = fi.LastWriteTime.ToShortDateString();
                                FS.sortdata = fi.LastWriteTime.Year.ToString() + fi.LastWriteTime.Month.ToString() + fi.LastWriteTime.Day.ToString();
                                FS.type = fi.Extension;
                                FS.fullname = fi.FullName;
                                FS.size = fi.Length;
                                FS.Extension = fi.Extension;
                                FS.icon = Icon.ExtractAssociatedIcon(FS.fullname);
                                ALLTYPE.list_files.Add(FS);
                            }
                        }
                    }
                    catch { MessageBox.Show("ERROR", "ERROR"); };
                }
                return ALLTYPE;
            }
           public static void Item__Activate(string path)
           {
               if (File.Exists(PathToFile + "\\" + path))
               {
                   try { Process.Start(PathToFile + "\\" + path); }
                   catch { MessageBox.Show("нет необходимой программы для открытия", "ERROR"); }
               }
               else
               {
                   if (Directory.Exists(PathToFile + "\\" + path))
                   {
                       PathToFile += "\\" + path;
                   }
                   else
                   {
                       PathToFile += path;
                   }
               } 
           }

           public static void button_back()
           {
                 try
                   {
                       forward.Add(PathToFile);
                       DirectoryInfo dirinfo = Directory.GetParent(PathToFile);
                       PathToFile = dirinfo.ToString();
                   }
                   catch (NullReferenceException)
                   {
                       PathToFile = "";
                   }
           }
           public static void button_forward()
           {
               PathToFile = forward[forward.Count() - 1];
               forward.RemoveAt(forward.Count() - 1);
           }
           public static void button_home()
           {
               forward.Add(PathToFile);
               PathToFile = "";
           }

           public static void delete(List<string> check)
           {
               if (MessageBox.Show("Удалить: " + string.Join(", ", check) +" ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                   foreach (string item in check)
                   {
                       try
                       {
                           if (Directory.Exists(PathToFile + "\\" + item))
                           {

                               Directory.Delete(PathToFile + "\\" + item, true);
                           }
                           else
                           {
                               File.Delete(PathToFile + "\\" + item);
                           }
                       }
                       catch { MessageBox.Show("Невозможно удалить " + PathToFile + "\\" + item, "ERROR"); }
                   }
               }
           }

           public static void PASTE_copy()
           {
                           if (MessageBox.Show("Копировать: " + string.Join(", ", COPYorCUT) + "\nВ " + PathToFile + " ?", "Копирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                           {
                               foreach (string item in COPYorCUT)
                               {
                                   try
                                   {
                                       if (System.IO.Directory.Exists(Path.Combine(PathToFile_copy, item)))
                                       {
                                           if (Path.Combine(PathToFile, item).Contains(Path.Combine(PathToFile_copy, item)))
                                           { MessageBox.Show("Конечная папка, в которую следует поместить файлы, является дочерней для папки, в которой они находятся."); }
                                           else CopyDirectory(Path.Combine(PathToFile_copy, item), PathToFile);
                                       }
                                       else File.Copy(Path.Combine(PathToFile_copy, item), Path.Combine(PathToFile, item));
                                   }
                                   catch { MessageBox.Show("Невозможно вставить " + Path.Combine(PathToFile_copy, item), "ERROR"); }
                               }
                           }
           }
           private static void CopyDirectory(string sourceDirectoryPath, string destinationDirectoryPath)
           {
               var sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryPath);

               var destinationDirectoryInfo = new DirectoryInfo(Path.Combine(destinationDirectoryPath, sourceDirectoryInfo.Name));

               CopyDirectoryRecursive(sourceDirectoryPath, destinationDirectoryInfo.FullName);
           }
           private static void CopyDirectoryRecursive(string sourceDirectoryPath, string destinationDirectoryPath)
           {
               var sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryPath);
               var destinationDirectoryInfo = new DirectoryInfo(destinationDirectoryPath);

               if (!destinationDirectoryInfo.Exists) destinationDirectoryInfo.Create();

               foreach (var fileInfo in sourceDirectoryInfo.GetFiles())
               {
                   File.Copy(fileInfo.FullName, Path.Combine(destinationDirectoryInfo.FullName, fileInfo.Name));
               }

               foreach (var directoryInfo in sourceDirectoryInfo.GetDirectories())
               {
                   CopyDirectoryRecursive(directoryInfo.FullName, Path.Combine(destinationDirectoryInfo.FullName, directoryInfo.Name));
               }
           }

           public static void PASTE_cut()
            {
                   if (MessageBox.Show("Переместить: " + string.Join(", ", COPYorCUT) + "\nИз " + PathToFile_copy + "\nВ " + PathToFile + " ?", "Перемещение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       foreach (string item in COPYorCUT)
                       {
                              try
                              {
                                  if (System.IO.Directory.Exists(Path.Combine(PathToFile_copy, item)))
                                  {
                                      if (Path.Combine(PathToFile, item).Contains(Path.Combine(PathToFile_copy, item)))
                                      { MessageBox.Show("Конечная папка, в которую следует поместить файлы, является дочерней для папки, в которой они находятся."); }
                                      else Directory.Move(Path.Combine(PathToFile_copy, item), Path.Combine(PathToFile, item));
                                  }
                                  else { File.Move(Path.Combine(PathToFile_copy, item), Path.Combine(PathToFile, item)); }
                              }
                              catch { MessageBox.Show("Невозможно переместить " + Path.Combine(PathToFile_copy, item), "ERROR"); }
                        }                              
                   }                           
            }
    }
}
