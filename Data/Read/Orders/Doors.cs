using Archetypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows;

namespace Data.Read.Orders
{
    public static class Doors
    {
        public static List<Door> GetAllByProjId(string workorderId)
        {
            /*
            return new List<Door>()
            {
                new Door(){ProductCode="1001", CustomerCode="asd-1", DoorLeafWidth=100, Lock1=new Property(){Code="Assa565", Name="Assa 565"}, Lock2=new Property()},
                new Door(){ProductCode="1002", CustomerCode="asd-2", DoorLeafWidth=100, Lock1=new Property(){Code="Assa560", Name="Assa 560"}, Lock2=new Property()},
                new Door(){ProductCode="1003", CustomerCode="asd-3", DoorLeafWidth=100, Lock1=new Property(){Code="Assa565", Name="Assa 565"}, Lock2=new Property()},
                new Door(){ProductCode="1004", CustomerCode="asd-4", DoorLeafWidth=100, Lock1=new Property(){Code="Assa565", Name="Assa 565"}, Lock2=new Property()}
            };
            */

            var result = new List<Door>();

            try
            {
                using (SqlConnection conn = new SqlConnection(Configuration.AxConnectionString))
                {
                    conn.Open();
                    var query = getAllDoorsSQL;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@workorderId", workorderId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var readDoor = new Door()
                                {
                                    ProductCode = reader["CONFIGID"].ToString(),
                                    CustomerCode = reader["PRODUCTCUSTOMERDESCRIPTION"].ToString(),
                                    ActiveFrameWidth = float.Parse(reader["ACTIVESIDEWIDTH"].ToString()),
                                    PassiveFrameWidth = float.Parse(reader["PASSIVESIDEWIDTH"].ToString()),
                                    FrameHeight = float.Parse(reader["UNITHEIGHT"].ToString()),
                                    DoorLeafWidth = 100
                                };
                                result.Add(readDoor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }

        private static string getAllDoorsSQL =
            "SELECT WOHeader.[PROJID] ,WOHeader.[REPORTDATE] ,WOHeader.[DUEDATE] ,WOHeader.[NOTESPRODUCTION] ,WOHeader.[NOTESINSTALLATION] " +
            ",WOLines.[LINENUM] ,InventDim.CONFIGID ,InventDim.INVENTSIZEID ,WOLines.[QTY] ,ProductData.* " +
            "FROM[AX6R2_TAMMER_TEST2].[dbo].[ESTWORKORDERLINES] as WOLines " +
            "JOIN[AX6R2_TAMMER_TEST2].[dbo].[ESTWORKORDERHEADER] as WOHeader " +
            "ON WOHeader.WORKORDERID = WOLines.WORKORDERID AND WOHeader.DATAAREAID = WOLines.DATAAREAID AND WOHeader.PARTITION = WOLines.PARTITION " +
            "JOIN[AX6R2_TAMMER_TEST2].[dbo].[SALESLINE] " +
            "ON SalesLine.RECID = WOLines.SALESLINEREFRECID AND SalesLine.DATAAREAID = WOLines.DATAAREAID AND SalesLine.PARTITION = WOLines.PARTITION " +
            "JOIN[AX6R2_TAMMER_TEST2].[dbo].[INVENTDIM] " +
            "ON InventDim.INVENTDIMID = SalesLine.INVENTDIMID AND InventDim.DATAAREAID = SalesLine.DATAAREAID AND InventDim.PARTITION = SalesLine.PARTITION " +
            "JOIN[AX6R2_TAMMER_TEST2].[dbo].[ESTPRODUCTDATA] as ProductData " +
            "ON ProductData.REFRECID = SalesLine.RECID AND ProductData.REFTABLEID = '359' AND ProductData.DATAAREAID = SalesLine.DATAAREAID AND ProductData.PARTITION = SalesLine.PARTITION " +
            "WHERE WOLines.DATAAREAID = 'tta' AND WOLines.WORKORDERID = @workorderId";
    }
}
