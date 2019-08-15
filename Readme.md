# Usage (Please Using CommandLine)
## (1) Create Sql Server Instance
- If you have installed SQL Server Instance, you can ignore this step.
- docker-compose -f "docker-compose.yml" up -d --build
## (2) Create Session Store DB
- cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
- ./aspnet_regsql.exe -S '.,1469' -U 'sa' -P 'yourStrong(!)Password' -ssadd -sstype p
# Refrence
- https://blog.miniasp.com/post/2011/09/13/Configure-SQL-Server-Session-State-Modes-for-ASPNET