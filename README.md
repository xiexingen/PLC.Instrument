
���� aspnetboilerplate �Ļ����û�����ɫ��Ȩ��ϵͳ

����ջ: .net 4.x + sqlserver + entityframework 6.x + abp + WPF + HandyControl

# ��ʼ

1. �򿪰��������̨��ѡ��EntityFramework��Ŀ��ΪĬ����Ŀ��ִ�� `Update-Database` ��������Ǩ�ƴ���
2. ִ�� Tools�е� Migrator �������ݿ�
3. ����App
4. ��¼����Ĭ��Ϊ admin  Abcd1234

# ��������µ�DB
1. �򿪰��������̨��ѡ��EntityFramework��Ŀ��ΪĬ����Ŀ��ִ�� `Add-Migration [Your_Migration_Name] -Context ManagerDbContext` ��������Ǩ�ƴ���
2. ִ�� Tools�е� Migrator �������ݿ�







# �����������ݿ�ķ���

``` bash
dotnet ef migrations script [from] [to]
//  ��: dotnet ef migrations script 20230427151027_init 20230511150003_Add_NextLogin_ChangePassword
```