using Archetypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Read.Technical
{
    public static class Handednesses
    {
        public static List<Component> GetAll()
        {
            return new List<Component>() { new Component() { Code = "1", Name = "Parem" }, new Component() { Code = "2", Name = "Vasak" } };
        }
    }
}
