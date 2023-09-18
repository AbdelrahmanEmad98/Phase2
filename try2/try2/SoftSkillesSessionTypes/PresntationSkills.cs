using try2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Try2.SoftSkillesSessionTypes
{
    public class PresntationSkills : SoftSkills
    {
        public  string PresentationPreparing()
        {
            return "Start PresentationPreparing...\n";
        }
        public override string SoftSkillesPractice()
        {
            return "Start SoftSkillesPractice...\n";
        }
        public string PresentationQuestions()
        {
            return "Start PresentationQuestions...\n";
        }

        public string PresentationDiscussion()
        {
            return "Start PresentationDiscussion...\n";

        }


        public override string ToString()
        {
            return PresentationPreparing()
                + SoftSkillesPractice()
                + PresentationQuestions()
                + PresentationDiscussion();
        }

    }
}
