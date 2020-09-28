using PH2_WriteBinaryFile.Manager;
using System;

namespace PH2_WriteBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            BacDTManager bacDTManager = new BacDTManager();
            bacDTManager.InsertBacDT("1", "Tien Si");
            bacDTManager.InsertBacDT("2", "Giao Su");

            bacDTManager.PrintBacDT();

            Console.WriteLine("-----------");
            bacDTManager.UpdateBacDT("2", "UPDATED");
            bacDTManager.PrintBacDT();

            Console.WriteLine("-----------");
            bacDTManager.DeleteBacDT("1");
            bacDTManager.PrintBacDT();
        }

    }
}
