using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try2.Interface
{
    public interface IRecord
    {
        public bool RecordStatus { get; set; }
        public void StartRecord();
        public void EndtRecord();
        public void ChangeRecordStatus();

    }
}
