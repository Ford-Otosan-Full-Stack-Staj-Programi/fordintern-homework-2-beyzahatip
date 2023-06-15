[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/3bErTxjD)
Sql Server'da Person ve Account Tabloları oluşturuldu.Person tablosu içerisindeki AccoountId foreignkey yapılarak account tablosu ile relation kuruldu.
Vİsual Studio'da Person ve Account için model ve DTO oluşturulup özellikler tanımlandı.İki model için de service oluşturulup repository işlemleri burada gerçekleştirildi.BaseResponse cevabı dönüldü.
Person ve Account için controller oluşturulup tüm metodlar yazıldı.
Token işlemleri için TokenManagementService oluşturuldu.Gerekli injectionlar yapıldı.TokenManagementService'te GenerateToken ile seçilen algoritma ile şifreleme yapıldı.claims dizisi içinde kullanıcıya token'da dönülecek bilgiler oluşturuldu.
Jwt Token ile Auth işlemleri gerçekleştirildi.Token metodu üzerinde bu sayede login işlemi yapıldı.
Account ve Person'daki tüm metodlar [Authorize] ile yetkilendirildi.Bu sayede login yapıp token almayan kimse bu actionları çalıştıramadı.
Account üzerinde yeni account eklemeyi sağlayan POST metodu [Authorize(Roles = $"{Role.Admin}")] attribute'u ile sadece admin rolüne sahip olanların yapabileceği şekilde kısıtlandı.
Person contoller uzerindeki tum actionlarda sessiondaki account id degerine gore filtreleme yapilabilmesi için Homework2.Web FilterByAccountId sınıfı oluşturuldu Filtreleme işlemini accountId üzerinden yapabilmesi için PersonControllerda bu dosya attribute olarak eklendi.
