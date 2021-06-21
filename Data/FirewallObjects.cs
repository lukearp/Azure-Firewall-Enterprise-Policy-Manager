using System;
using System.Collections.Generic;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public class FirewallObjectReference
    {
        public List<FirewallObjectGroup> firewallObjectGroups {get;set;}
        public List<FirewallRules> firewallRules {get;set;}
    }

    public class FirewallObject
    {
        public string name {get;set;}
        public string network {get;set;}
        public string description {get;set;}
        public FirewallObjectReference references {get;set;}
    }

    public class FirewallObjectGroup
    {
        public string name {get;set;}
        public List<FirewallObject> firewallObjects {get;set;}
        public string description {get;set;}
        public FirewallObjectReference references {get;set;}
    }
}