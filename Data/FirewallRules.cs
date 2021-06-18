using System;
using Microsoft.Extensions.Configuration;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public interface IFirewallConfigManager
    {
        string Instance {get;}
        string Domain {get;}
        string TenantId {get;}
        string ClientId {get;}
        string ClientSecret {get;}
        string CallbackPath {get;}
        IConfigurationSection GetConfigurationSection(string Key);
    }

    public class FirewallConfigManager : IFirewallConfigManager
    {
        private readonly IConfiguration _configuration;
        public FirewallConfigManager(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string Instance
        {
            get
            {
                return this._configuration["AzureAd:Instance"];
            }
        }
        public string Domain
        {
            get
            {
                return this._configuration["AzureAd:Domain"];
            }
        }
        public string TenantId
        {
            get
            {
                return this._configuration["AzureAd:TenantId"];
            }
        }
        public string ClientId
        {
            get
            {
                return this._configuration["AzureAd:ClientId"];
            }
        }
        public string ClientSecret
        {
            get
            {
                return this._configuration["AzureAd:ClientSecret"];
            }
        }
        public string CallbackPath
        {
            get
            {
                return this._configuration["AzureAd:CallbackPath"];
            }
        }
        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }
    }

    public class FirewallRules 
    {
        public string name {get;set;}
    }
}