using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        public int Id {get; set; }  
        private static int nextId = 1;
        public string Value {get; set; } 

        // TODO: Change the fields to auto-implemented properties.
        //Okay, if I understand correctly, the private fields are still there, but we see the public properties that are being autoimplemented.
        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
    }
    }
}
