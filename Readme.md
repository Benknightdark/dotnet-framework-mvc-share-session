# Usage (Please Using CommandLine)
## (1) Create Sql Server Instance
- If you have installed SQL Server Instance, you can ignore this step.
- docker-compose -f "docker-compose.yml" up -d --build
## (2) Create Session Store DB
- cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
- ./aspnet_regsql.exe -S '.,1469' -U 'sa' -P 'yourStrong(!)Password' -ssadd -sstype p
## (3) 參考此作者方法
-  https://baechang.pixnet.net/blog/post/60892711-%5Basp.net%5Dsessoin%E5%AD%98%E5%88%B0sql-server-%E4%B8%A6%E5%85%B1%E9%80%9A%E6%96%BC%E5%A4%9A%E5%8F%B0iis%E7%AB%99%E5%8F%B0
# Refrence
- https://blog.miniasp.com/post/2011/09/13/Configure-SQL-Server-Session-State-Modes-for-ASPNET
- https://baechang.pixnet.net/blog/post/60892711-%5Basp.net%5Dsessoin%E5%AD%98%E5%88%B0sql-server-%E4%B8%A6%E5%85%B1%E9%80%9A%E6%96%BC%E5%A4%9A%E5%8F%B0iis%E7%AB%99%E5%8F%B0