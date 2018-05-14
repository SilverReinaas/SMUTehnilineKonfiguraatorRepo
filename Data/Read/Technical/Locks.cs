using Archetypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Read.Technical
{
    public static class Locks
    {
        public static List<Component> GetAll()
        {
            return new List<Component>()
            {
                new Component(){Code="Assa565", Name="Assa 565"},
                new Component(){Code="Assa560", Name="Assa 560"},
                new Component(){Code="Abloy4190", Name="Abloy 4190"},
                new Component(){Code="EL502", Name="EL 502"}
            };
        }
    }
}
