﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationSRAS.Config.Automation
{
    [XmlType(TypeName = "Topologies")]
    public class TopologiesCfg
    {
        [XmlElement(ElementName = "Topology")]
        public List<TopologyCfg> topologies;
    }
}
