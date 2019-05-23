using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main()
        {
            // Создание наблюдателя и сосредоточение его внимания на системном диске.
            var watcher = new FileSystemWatcher { Path = @"C:\" };

            // Зарегистрировать обработчики событий.
            // watcher.Created += new FileSystemEventHandler(WatcherChanged);
            // watcher.Deleted += WatcherChanged;
            // watcher.Renamed += new RenamedEventHandler(WatcherRenamed);
            // watcher.Error += new ErrorEventHandler(WatcherError);

            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;

            var change = watcher.WaitForChanged(WatcherChangeTypes.All);
            Console.WriteLine(change.ChangeType);

            Console.ReadKey();
        }

        // Обработчик события.
        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
        }

        // Обработчик события.
        static void WatcherRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed from {0} to {1}", e.OldFullPath, e.FullPath);
        }

        // Обработчик события.
        static void WatcherError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Error {0}", e.GetException());
        }
    }

}
