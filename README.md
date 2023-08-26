
基于 aspnetboilerplate 的基础用户、角色、权限系统

技术栈: .net 4.x + sqlserver + entityframework 6.x + abp + WPF + HandyControl

# 开始

1. 打开包管理控制台，选择EntityFramework项目作为默认项目，执行 `Update-Database` 命令生成迁移代码
2. 执行 Tools中的 Migrator 生成数据库
3. 启动App
4. 登录密码默认为 admin  Abcd1234

# 新增表更新到DB
1. 打开包管理控制台，选择EntityFramework项目作为默认项目，执行 `Add-Migration [Your_Migration_Name] -Context ManagerDbContext` 命令生成迁移代码
2. 执行 Tools中的 Migrator 生成数据库







# 另类生成数据库的方法

``` bash
dotnet ef migrations script [from] [to]
//  如: dotnet ef migrations script 20230427151027_init 20230511150003_Add_NextLogin_ChangePassword
```