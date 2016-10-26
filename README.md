# Contoso University

This repro contains Microsoft's ASP.NET MVC sample site adapted for my Octopus Deploy demos and talks.  The original sources came from https://code.msdn.microsoft.com/ASPNET-MVC-Application-b01a9fe8.

I have adapted Microsoft's solution by splitting the MVC project into three:

1. There is a project containing just the MVC site.
2. A data project contains the Entitiy Framework `DbContext`, entities and migrations.
3. A core project contains code shared by the site and data access projects.

The `master` branch is the starting point for my demos and talks.

## Deploying SQL databases using Entity Framework migrations and Octopus Deploy

The sample code used in my talks and on [my blog](http://www.kevinkuszyk.com/2016/10/26/deploying-sql-databases-using-entity-framework-migrations-and-octopus-deploy/) can be found in the [`octopus-deploy`](https://github.com/kevinkuszyk/contoso-university/commits/octopus-deploy) branch.  Commit [`6c40dc6`](https://github.com/kevinkuszyk/contoso-university/commit/6c40dc64e6d89b4f1008d96c88b0ed53ce705365) has all the detail of the `Deploy.ps1`, custom `.nuspec` file etc. that I use.

For a full write up, please see my blog post here:
http://www.kevinkuszyk.com/2016/10/26/deploying-sql-databases-using-entity-framework-migrations-and-octopus-deploy.
