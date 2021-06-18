# What is the project goal
Be an overlay for the Azure Firewall manager to add enterprise focused features.  

Be a very light weight web application that will manage rules for multiple Azure Firewall Policies cross Tenant and Cross Cloud. 

# What are the immediate features targeted
- Associate Metadata to configured rules
   - Purpose of Rule
   - Rule Authorizer
   - Key value pair taging for custom requirements (example: ChangeControlNumber: 00036)
- Firewall Rule Expiration and Schedules
   - When a rule is created, the ability to set an expiration date on that rule.  
   - The ability to schedule when a rule is created and when existing rules are removed.
- Better Object and Object Group organization
   - Enhance Azure's IPGroups so they are more inline with Firewall Vendors
   
# How will the app be secured
Early builds will be targeting Azure Active Directory and using User Delegated Permissions.  When I'm ready to start supporting cross tenant and multi-cloud (Azure Commercial and Azure Government), I will probably use Application Permissions.  
