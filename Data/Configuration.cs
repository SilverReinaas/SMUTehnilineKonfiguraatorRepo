using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Configuration
    {
        public static string
            AxConnectionString =
                "Data Source=TAMMER-SRV-AX2;Initial Catalog=AX6R2_TAMMER_TEST2;Integrated Security=True;Connection Timeout=30",
            SemuConnectionString = 
                "Data Source=TAMMER-SRV-AX2;Initial Catalog=SEMU;Integrated Security=True;Connection Timeout=30",
            ParamsDescriptionDefaultTable = "ParamsDescriptionDefault";
    }
}
