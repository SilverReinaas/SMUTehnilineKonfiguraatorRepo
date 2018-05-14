using Archetypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Read.Technical
{
    public static class Locks
    {
        public static List<Property> GetAll()
        {
            return new List<Property>()
            {
                new Property(){Code="Assa565", Name="Assa 565"},
                new Property(){Code="Assa560", Name="Assa 560"},
                new Property(){Code="Abloy4190", Name="Abloy 4190"},
                new Property(){Code="EL502", Name="EL 502"}
            };
        }
    }
}
