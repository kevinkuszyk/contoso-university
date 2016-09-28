$connectionString = $OctopusParameters["SQL.ContosoUniversity.DeployConnectionString"]

.\migrate.exe ContosoUniversity.Data.dll /connectionString="$($connectionString)" /connectionProviderName="System.Data.SqlClient"