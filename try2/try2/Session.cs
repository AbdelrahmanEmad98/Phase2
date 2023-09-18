using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try2
{
    public abstract class Session
    {
        public int Id { get;}
        [MaxLength(50)]
        public string Topic { get; } = null!;
        [MaxLength(100)]
        public string Description {  get; }=string.Empty;
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Duration { get; }
        


        public Session(int id, string topic, string decription, DateTime startDate,DateTime endDate)
        {
            Id = id;
            Topic = topic;
            Description = decription;
            StartTime=startDate;
            EndTime=endDate;

            Duration = endDate-startDate;
        }


    }
}
