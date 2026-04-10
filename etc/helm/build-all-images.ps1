./build-image.ps1 -ProjectPath "../../src/Fiovana_v2.DbMigrator/Fiovana_v2.DbMigrator.csproj" -ImageName fiovana_v2/dbmigrator
./build-image.ps1 -ProjectPath "../../src/Fiovana_v2.Web.Public/Fiovana_v2.Web.Public.csproj" -ImageName fiovana_v2/webpublic
./build-image.ps1 -ProjectPath "../../src/Fiovana_v2.HttpApi.Host/Fiovana_v2.HttpApi.Host.csproj" -ImageName fiovana_v2/httpapihost
./build-image.ps1 -ProjectPath "../../angular" -ImageName fiovana_v2/angular -ProjectType "angular"
