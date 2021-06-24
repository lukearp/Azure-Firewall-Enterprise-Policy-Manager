using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public interface IFirewallConfigManager
    {
        string Instance {get;}
        string Domain {get;}
        string TenantId {get;}
        string ClientId {get;}
        string ClientSecret {get;}
        string SubscriptionId {get;}
        string ResourceGroup {get;}
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
        public string SubscriptionId
        {
            get
            {
                return this._configuration["AzureAd:SubscriptionId"];
            }
        }
        public string ResourceGroup
        {
            get
            {
                return this._configuration["AzureAd:ResourceGroup"];
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

    public class FirewallRule
    {
        public string name {get;set;}
        public string description {get;set;}
        public List<FirewallObject> sourceObjects {get;set;}
        public List<FirewallObjectGroup> sourceObjectGroups {get;set;}
        public List<FirewallObject> destinationObjects {get;set;}
        public List<FirewallObjectGroup> destinationObjectGroups {get;set;} 
        public List<FirewallProtocol> services {get;set;}       
    }
}