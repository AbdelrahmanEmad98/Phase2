using try2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace try2
{
    public class TechnicalSession : Session
    {
        public bool OnSide {  get; set; }
       // public bool Recorded { get; private set; } = false;
        public IRecord? Record { get; private set; } = null;
        public TechnicalSession(int id, string topic, string decription, DateTime startDate, DateTime endDate,bool onSide) : base(id, topic, decription, startDate, endDate)
        {
            OnSide = onSide;
        }

        //

        public void CreateRecord(IRecord recordVendor)
        {
            Record = recordVendor;
        }


        public void StartRecord()
        {
            Record.StartRecord();
        }
        public void EndtRecord()
        {
            Record.EndtRecord();

        }

        public void ChanegeRecordStatus()
        {
            Record.ChangeRecordStatus();

        }



        public override string ToString() 
        {
            return $"Session Type : {nameof(TechnicalSession)}\n" +
                $"ID : {Id}\n" +
                $"Topic : {Topic} \n" +
                $"Description : {Description}\n" +
                $"Start Date : {StartTime}\n" +
                $"End Date : {EndTime}\n" +
                $"Duration : {Duration} Hours";
        }
    }
}
