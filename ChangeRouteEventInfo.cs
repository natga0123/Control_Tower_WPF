﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Tower_WPF
{
    public class ChangeRouteEventInfo : EventArgs
    {
        public int heading { get; set; }

        public string Flight_Id { get; set; }
        public DateTime Time_of_command { get; set; }
        public string Command_Info { get; set; }

    }
}
