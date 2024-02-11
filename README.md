# Apartment Management System
**Coderspace ve Papara** işbirliği ile gerçekleştirilen **Kadın Yazılımcı Bootcamp'i** için bitirme projesi olarak **Apartment Management System** isimli bir api projesi geliştirdim. 
Bu proje bir site yönetim projesidir. Site yönetici yeni binalar ve daireler ekleyip bu dairelere yeni kiracılar atayabilir. Fatura ve aidatları girebilir ve güncelleyebilir. 

<hr>

### Running the Project
Projeyi çalıştırmak için: 
- Projeyi klonlayın.
- Projede bulunan appsettings.Development kısmından SqlServer bağlantı dizesini kendi local veritabanı bağlantısı ile değiştirin.
- Daha sonra Package Manager Console'u açın ve Default Project kısmını DataAccess olarak değiştirin.
- Add-migration komutunu giriniz.
```bash
  add-migration init
```
- Daha sonra update-database komutu ile veritabanını kurunuz
```bash
  update-database
```
- Veritabanı kurulduktan sonra size varsayılan olarak bir admin bilgileri atanacaktır.
    - UserName = "admin"
    - Password = 123456

<hr>

### Project Images
Database
<img src="https://github.com/arzutp/ApartmentManagementSystem/blob/master/Images/Database.png"/>
Api
<img src="https://github.com/arzutp/ApartmentManagementSystem/blob/master/Images/1.png"/>
<img src="https://github.com/arzutp/ApartmentManagementSystem/blob/master/Images/2.png"/>
<img src="https://github.com/arzutp/ApartmentManagementSystem/blob/master/Images/3.png"/>
<img src="https://github.com/arzutp/ApartmentManagementSystem/blob/master/Images/4.png"/>
<img src="https://github.com/arzutp/ApartmentManagementSystem/blob/master/Images/5.png"/>

<hr>

## 4- Kullanılan Teknolojiler 
<img src="https://img.shields.io/badge/-C%23-lemon"></img><br/>
<img src="https://img.shields.io/badge/-ASP.NET%20CORE%20-purple"></img><br/>
<img src="https://img.shields.io/badge/-Entity%20Framework-red"></img><br/>
<img src="https://img.shields.io/badge/-AutoMapper-purple"></img><br/>
<img src="https://img.shields.io/badge/-Identity-orange"></img><br/>
<img src="https://img.shields.io/badge/-Sql%20Server-yellow"></img><br/>
<img src="https://img.shields.io/badge/-UnitOfWork-darkblue"></img><br/>
<img src="https://img.shields.io/badge/-json-blue"></img><br/>




## Authors

- [@arzutp](https://github.com/arzutp)
