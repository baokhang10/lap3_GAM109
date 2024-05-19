using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {

        string username ="1";
        string password ="123";
        string time= "1/2/2021";
        var sw = new StringWriter();

        sw.WriteLine("UserName: " + username);
        sw.WriteLine("Password: " +password);
        var content = sw.ToString();

        //"Username: 1\nPassword: 123\n;

        var sr =new StringReader(content);
       string line1 = sr.ReadLine();
        Console.WriteLine("line 1: " +line1);
        string line2 = sr.ReadLine();
        Console.WriteLine("line 2: "+line2);
        
        Console.ReadLine();
    }
}
