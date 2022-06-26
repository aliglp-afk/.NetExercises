using System;
namespace ExerciseTen
{
    class Questions{
        public int ID { get; set; }
        public int SectionID { get; set; }
        public string Question { get; set; }
        public Questions(int id,int sectionid,string ques)
        {
            Question=ques;
            ID=id;
            SectionID=sectionid;
        }
    }
}