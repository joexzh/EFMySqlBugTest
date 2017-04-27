# EFMySqlBugTest

A bug experiment for MySql.Data.Entity.EF6, and a workaround using EF Core and [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)

## DEBUG build configuration to test the MySql.Data.Entity.EF6

Throws exception if 'include' multiple layers, and mysql team not fixed it yet.

## EFCore build configuration to test the MySql EF Core using [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)

It works fine in this scenario. But EF Core not yet supports the very useful feature which EF6 has provided: the complex type, many-to-many without explicit defining a third relation table, etc.

