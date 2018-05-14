using System;
using System.Collections.Generic;
using System.Text;

namespace Archetypes
{
    public class Door
    {
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public float DoorLeafWidth { get; set; }
        public Component Lock1 { get; set; }
        public Component Lock2 { get; set; }
        public float ActiveFrameWidth { get; set; }
        public float PassiveFrameWidth { get; set; }
        public float FrameHeight { get; set; }
        public Component Handedness { get; set; }
    }
}
