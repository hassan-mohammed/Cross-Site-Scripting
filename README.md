# Cross Site Scripting

A Simple ASP.NET application vulnerable to XSS attacks with code example for fixing it
Each code commit show one layer of defending aganist XSS attacks, and the last commit "Putting it all toghether" show all the defenses applied here 

### Defenses used 
1. Whitelisting filter 
2. Contextual Output Encoding
3. Enabling browser mitigations
4. Enabling Content Security Policy
5. Enable ASP.NET Request Validation

References:
- [OWASP XSS Prevention Cheat Shee](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.md)
- [.NET AntiXssEncoder Class link](https://docs.microsoft.com/en-us/dotnet/api/system.web.security.antixss?view=netframework-4.6.2)
- [Content Security Policy](https://content-security-policy.com/)
