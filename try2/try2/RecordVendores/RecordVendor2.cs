using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using try2.Interface;

namespace try2.RecordVendores
{
    public class RecordVendor2 : IRecord
    {
        public string Name { get; } = "Discord"; 
        public bool RecordStatus { get; set; } = false;

        public RecordVendor2()
        {
            Name = "Discord";
        }
        public void EndtRecord()
        {
            Console.WriteLine($"Record Ending ...");
            Thread.Sleep(500);
            Console.WriteLine($"Saved In : {Name}");
        }

        public void StartRecord()
        {
            Console.Write("Record Preparing .... ");
            Thread.Sleep(1000);
            Console.WriteLine($"Recording Start in : {Name}");

            
        }
        public void ChangeRecordStatus()
        {
            if (RecordStatus)
                RecordStatus = false;
            else
                RecordStatus = true;
        }
    }
}
