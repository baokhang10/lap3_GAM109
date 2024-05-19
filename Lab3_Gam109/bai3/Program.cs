using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void create(string path)
    {
        
        Directory.CreateDirectory(path);
        string filePath = Path.Combine(path,"data.txt");

        StreamWriter streamWinter = new StreamWriter(path);
        streamWinter.WriteLine("mssv: pd09955");
        streamWinter.WriteLine("Ho va ten: Huynh Duong Bao Khang");
        streamWinter.Dispose();
    }
    static void copy(string sourcePath, string destinationPath)
    {
        if (Directory.Exists(destinationPath) == false) 
        {
            Directory.CreateDirectory(destinationPath);

            string[] fileList = Directory.GetFiles(sourcePath);
            foreach (string file in fileList)
            {
                
            }
        }
    }
    static void Main(string[] args)
    {   string path1 = "data1";
        string path2 = "data2";
        create(path1);
        copy(path1, path2);
    }
}