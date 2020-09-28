using PH2_WriteBinaryFile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PH2_WriteBinaryFile.Manager
{
    class BacDTManager
    {
        private String filename = Directory.GetCurrentDirectory() + "/../../../Data/BacDT.dat";
        private List<BacDT> bacDTList;

        public BacDTManager()
        {
            bacDTList = new List<BacDT>();
        }

        public bool InsertBacDT(String iDBDT, String tenBacDT)
        {
            bool existed = bacDTList.Exists(x => x.IDBDT.Equals(iDBDT));

            if(existed)
            {
                return false;
            }

            bacDTList.Add(new BacDT(iDBDT, tenBacDT));
            WriteFile();
            return true;
        }

        public void PrintBacDT()
        {
            Console.WriteLine("IDBDT \tTenBacDT");
            bacDTList.ForEach(x => Console.WriteLine(x));
        }

        public bool UpdateBacDT(String iDBDT, String tenBacDT)
        {
            BacDT bacDT = bacDTList.Find(x => x.IDBDT.Equals(iDBDT));
            if(bacDT == null)
            {
                return false;
            }

            bacDT.TenBacDT = tenBacDT;
            WriteFile();
            return true;
        }

        public bool DeleteBacDT(String iDBDT)
        {
            BacDT bacDT = bacDTList.Find(x => x.IDBDT.Equals(iDBDT));
            if(bacDT == null)
            {
                return false;
            }

            bacDTList.Remove(bacDT);
            WriteFile();
            return true;
        }

        private void WriteFile()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    bacDTList.ForEach(x =>
                    {
                        writer.Write(x.IDBDT);
                        writer.Write(x.TenBacDT);
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot write to file: ERROR {0}", e);
            }
        }
    }
}
