using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_5__Attributes_
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\w|\.+\.[a-z0-9]{3,4}$";
            string startPath = @"C:\Programing\Video";
            int position = 0;
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            DirectoryInfo startFolder = new DirectoryInfo(startPath);

            if (!startFolder.Exists)
                Console.WriteLine("Incorrect path!!!");

            List<FileInfo> matchFiles = new List<FileInfo>();
            List<DirectoryInfo> matchFolders = new List<DirectoryInfo>();


            DirectoryInfo[] folders = startFolder.GetDirectories();


            FindMatches(startFolder, regex, matchFiles, matchFolders);

            foreach (var file in matchFiles)
            {
                Console.WriteLine("{0,-60}\t - {1,10}", file.Name, position++);
            }

            Console.ReadKey();
        }

        static void FindMatches(DirectoryInfo inputFolder, Regex regex, List<FileInfo> matchFiles, List<DirectoryInfo> matchFolders)
        {
            DirectoryInfo[] innerFolders = inputFolder.GetDirectories();

            foreach (var folder in innerFolders)
            {
                matchFolders.AddRange(folder.GetDirectories().Where(directory=>regex.IsMatch(directory.Name)));

                matchFiles.AddRange(folder.GetFiles().Where(file => regex.IsMatch(file.Name)));

                FindMatches(folder, regex, matchFiles, matchFolders);
            }
        }
    }
}
