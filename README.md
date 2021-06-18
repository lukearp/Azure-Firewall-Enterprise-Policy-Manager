# What is the project goal
Be an overlay for the Azure Firewall manager to add enterprise focused features.  

Be a very light weight web application that will manage rules for multiple Azure Firewall Policies cross Tenant and Cross Cloud. 

# What are the immediate features targeted
1. Associate Metadata to configured rules
   a. Purpose of Rule
   b. Rule Authorizer
   c. Key value pair taging for custom requirements (example: ChangeControlNumber: 00036)
2. Firewall Rule Expiration and Schedules
   a. When a rule is created, the ability to set an expiration date on that rule.  
   b. The ability to schedule when a rule is created and when existing rules are removed.
3. Better Object and Object Group organization
   a. Enhance Azure's IPGroups so they are more inline with Firewall Vendors
   
# How will the app be secured
Early builds will be targeting Azure Active Directory and using User Delegated Permissions.  When I'm ready to start supporting cross tenant and multi-cloud (Azure Commercial and Azure Government), I will probably use Application Permissions.  
