using System;
using System.Collections.Generic;
using System.Text;

namespace Archetypes
{
    public class Door
    {
        public List<Component> Components { get; set; } // koost

        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public float DoorLeafWidth { get; set; }
        public Property Lock1 { get; set; }
        public Property Lock2 { get; set; }
        public float ActiveFrameWidth { get; set; }
        public float PassiveFrameWidth { get; set; }
        public float FrameHeight { get; set; }
        public Property Handedness { get; set; }
    }
}
