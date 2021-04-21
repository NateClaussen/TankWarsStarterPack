using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace TankWarsStarter
{
    class Program
    {
        static void Main(string[] args) {
            MoveFiles();
            //Start the TankWars Application...
            ProcessStartInfo processInfo = new();
            processInfo.FileName = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\Dep\\MonoGameBoard.exe";
            processInfo.ErrorDialog = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.WorkingDirectory = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\Dep";
            Process.Start(processInfo);
            Console.WriteLine("Good Luck :)");
        }

        private static void MoveFiles() {
            string RootDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //replace PlayerTanks.dll
            File.Move(RootDirectory + "\\PlayerTanks.dll", RootDirectory + "\\Dep\\PlayerTanks.dll", true);
            //Delete all images
            if (Directory.Exists(RootDirectory + "\\Dep\\Images")) {
                foreach (var file in Directory.GetFiles(RootDirectory + "\\Dep\\Images")) {
                    File.Delete(file);
                }
                Directory.Delete(RootDirectory + "\\Dep\\Images");
            }
            //Move Images Folder to correct location...
            Directory.Move(RootDirectory + "\\Images", RootDirectory + "\\Dep\\Images");

        }
    }
}
