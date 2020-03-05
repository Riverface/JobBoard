using System.Collections.Generic;
namespace JobBoard.Models
{
    public class Job
    {
        static public List<Job> _Instances { get; set; } = new List<Job>();
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public int ID { get; }
        public Job(string name, string company, string position)
        {
            Name = name;
            Company = company;
            Position = position;
            _Instances.Add(this);
            ID = _Instances.Count;
        }
        public static List<Job> GetAll()
        {
            return _Instances;
        }
        public static Job GetOpeningByID(int id)
        {
            return _Instances[id-1];
        }
        public static void ClearAll()
        {
            _Instances = new List<Job>();
        }
    }
}