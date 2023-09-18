using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using try2.Interface;

namespace try2.SoftSkillesSessionTypes
{
    public class CommucationSkills : SoftSkills
    {
        public override string SoftSkillesPractice()
        {
            return "Commucation Skills Session";
        }

       

        public override string ToString()
        {
            return SoftSkillesPractice();
        }
    }
}
