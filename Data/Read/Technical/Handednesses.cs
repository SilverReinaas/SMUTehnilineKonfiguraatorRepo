using Archetypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Read.Technical
{
    public static class Handednesses
    {
        public static List<Property> GetAll()
        {
            return new List<Property>() { new Property() { Code = "1", Name = "Parem" }, new Property() { Code = "2", Name = "Vasak" } };
        }
    }
}
