using try2;
using try2.Interface;
using try2.RecordVendores;
using try2.Repository;
using try2.SoftSkillesSessionTypes;
using Try2.SoftSkillesSessionTypes;

internal class Program
{
    private static void Main(string[] args)
    {

        IRecord v1 = new RecordVendor1();
        IRecord v2 = new RecordVendor2();
        IRecord v3 = new RecordVendor3();
        Repository.Sessions.Add(new try2.TechnicalSession(1, "C# Fundamental", "C# Syntax & Looping ...", new DateTime(2023, 05, 08, 10, 00, 00), new DateTime(2023, 05, 08, 12, 00, 00), true));
        Repository.Sessions.Add(new try2.TechnicalSession(2, "C# OOP Principle", "Inhirtance & Abstraction ...", new DateTime(2023, 05, 09, 10, 00, 00), new DateTime(2023, 05, 09, 12, 00, 00), true));
        Repository.Sessions.Add(new try2.TechnicalSession(3, "C# OOP Desgin", "SOLID Principles ...", new DateTime(2023, 05, 10, 10, 00, 00), new DateTime(2023, 05, 10, 12, 00, 00), true));
        Repository.Sessions.Add(new try2.TechnicalSession(4, "Data Base Fundmantal", "ERD & Mapping ...", new DateTime(2023, 05, 11, 10, 00, 00), new DateTime(2023, 05, 11, 12, 00, 00), true));
        Repository.Sessions.Add(new try2.SoftSkillsSession(5, "MindSet Session", "Soft Skills Session", new DateTime(2023, 05, 12, 10, 00, 00), new DateTime(2023, 05, 12, 12, 00, 00), new PresntationSkills()));
        Repository.Sessions.Add(new try2.SoftSkillsSession(5, "MindSet Session", "Soft Skills Session", new DateTime(2023, 05, 12, 10, 00, 00), new DateTime(2023, 05, 12, 12, 00, 00), new CommucationSkills()));

        for (int i = 0; i < Repository.Sessions.Count; i++)
        {

            //Console.WriteLine(Repository.Sessions[i].ToString());
            //if (i == 2)
            //{
            //    TechnicalSession mySession = (TechnicalSession)Repository.Sessions[i];
            //    mySession.CreateRecord(v2);
            //}
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------");

        }

       



    }
}