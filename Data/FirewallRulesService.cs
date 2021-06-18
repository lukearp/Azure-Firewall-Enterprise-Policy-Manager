using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public class FirewallRuleService 
    {
        private readonly IFirewallConfigManager _configuration;
        private IAzure azure;

        public FirewallRuleService(IFirewallConfigManager configuration)
        {
            this._configuration = configuration;
            var creds = new Microsoft.Azure.Management.ResourceManager.Fluent.Authentication.AzureCredentialsFactory().FromServicePrincipal(this._configuration.ClientId, this._configuration.ClientSecret, this._configuration.TenantId, AzureEnvironment.AzureGlobalCloud);
            azure = Microsoft.Azure.Management.Fluent.Azure.Authenticate(creds).WithDefaultSubscription();
        }
        public async Task<FirewallRules[]> GetRules()
        {
            var creds = new Microsoft.Azure.Management.ResourceManager.Fluent.Authentication.AzureCredentialsFactory().FromServicePrincipal(this._configuration.ClientId, this._configuration.ClientSecret, this._configuration.TenantId, AzureEnvironment.AzureGlobalCloud);
            List<FirewallRules> rules = new List<FirewallRules>();
            IPagedCollection<IResourceGroup> groups = await azure.ResourceGroups.ListAsync();
            foreach(IResourceGroup group in groups)
            {
               rules.Add(new FirewallRules() { name = group.Name });
            }
            return rules.ToArray();
        }
    }
}