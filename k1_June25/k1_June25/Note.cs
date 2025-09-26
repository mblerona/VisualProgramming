using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_June25
{
    public class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Note(string title, string description, string type)
        {
            Title = title;
            Description = description;
            Type = type;
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} ", Type, Title);

        }
    }
}
