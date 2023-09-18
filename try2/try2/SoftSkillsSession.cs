using try2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try2
{
    public class SoftSkillsSession : Session
    {
        private readonly ISoftSkills _softSkillsType;  
        public SoftSkillsSession(int id, string topic, string decription, DateTime startDate,DateTime endDate,SoftSkills softSkillsType) : base(id, topic, decription, startDate,endDate)
        {
            _softSkillsType = softSkillsType;
        }


        public override string ToString()
        {
            return $"Session Type : {nameof(SoftSkillsSession)}\n" +
                $"ID : {Id}\n" +
                $"Topic : {Topic} \n" +
                $"Description : {Description}\n" +
                $"Start Date : {StartTime}\n" +
                $"End Date : {EndTime}\n" +
                $"Duration : {Duration} Hours\n" +
                _softSkillsType.ToString()+ "\n";

        }


    }
}
