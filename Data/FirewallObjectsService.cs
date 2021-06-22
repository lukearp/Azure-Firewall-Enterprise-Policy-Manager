using System;
using System.Collections.Generic;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public class FirewallObjectsService
    {
        public List<FirewallObject> firewallObjects {get;set;}
        public List<FirewallObjectGroup> firewallObjectGroups {get;set;}

        public FirewallObjectsService()
        {
            firewallObjects = new List<FirewallObject>() { new FirewallObject() { name="OnPrem-DC", network="192.168.1.25", description="The Domain Controller On-Prem", references = new FirewallObjectReference() }, new FirewallObject() { name="Colo-Network", network="192.168.16.0/22", description="Address Range for our Colocation Datacenter", references = new FirewallObjectReference() }};
            firewallObjectGroups = new List<FirewallObjectGroup>() {new FirewallObjectGroup { name="My Group", firewallObjects = firewallObjects, description="Azure Routeable", references=new FirewallObjectReference()}};
        }
    }
}