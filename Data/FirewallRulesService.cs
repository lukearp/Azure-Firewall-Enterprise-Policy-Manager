using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public class FirewallRuleService 
    {
        private readonly IFirewallConfigManager _configuration;
        private string accessToken;
        private string startUri;
        private string firewallPolicyApiVersion = "2021-02-01";

        public FirewallRuleService(IFirewallConfigManager configuration)
        {
            this._configuration = configuration;            
            this.startUri = "/subscriptions/"+ this._configuration.SubscriptionId +"/resourceGroups/" + this._configuration.ResourceGroup + "/providers/Microsoft.Network/";
            GetAuthorizationToken();
        }
        public async Task<string> GetFirewallPolicy()
        {          
            return await FirewallHttp.GetHttp(accessToken,startUri + "firewallPolicies?api-version=" + firewallPolicyApiVersion);
        }
        private void GetAuthorizationToken()
        {
            ClientCredential cc = new ClientCredential(this._configuration.ClientId, this._configuration.ClientSecret);
            var context = new AuthenticationContext("https://login.microsoftonline.com/" + this._configuration.TenantId);
            var result = context.AcquireTokenAsync("https://management.azure.com/", cc);
            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the Access token");
            }
            accessToken = result.Result.AccessToken;
        }
    }
}