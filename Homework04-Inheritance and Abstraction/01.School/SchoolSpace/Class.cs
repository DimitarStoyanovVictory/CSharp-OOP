using System.Collections.Generic;

namespace SchoolSpace
{
    public class Class
    {
        public Class(string uniqueTextIndentifier)
        {
            this.UniqueTextIndentifier = uniqueTextIndentifier;
        }

        public string UniqueTextIndentifier { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}

