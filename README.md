# BudgetReport

## Dependency Inversion Principle

> Bizga bu prinsipni tushunish uchun quyidagi ikki loyiha berildi

### 1-loyiha
![1-loyiha](https://github.com/AlijonovAzamjon2303/BudgetReport/assets/112892881/3ec4fce3-c591-41ae-93f3-7485bee284be)  

### 2-loyiha
![image](https://github.com/AlijonovAzamjon2303/BudgetReport/assets/112892881/9faab05e-23ec-4e36-aab9-863b3a0895a8)

Yuqoridagi ikki loyihani amalga oshirish mobaynida DIP prinsipini to'liq tushunib olish mumkin.
Hozir DIP qo'llangandan keyin dastur qanday ishlayotkani haqida qisqacha ma'lumot beraman.


### Ishning borishi

> DIP qo'llangandan keyin oradagi bog'liqlikni yo'qotish uchun IDatabase interface'i qo'llanildi.
> Shu sababli o'rtadagi bog'liqlik bartaraf etildi. BudgetReport clasi ham MySql, Mongodb clasi ham bir vaqtda
> impelentatsiya qilinishi mumkin bo'ldi. Bu loyiha te va sifatli bitishi, Open/Closed prinsiplariga ham mos kelishida
> muhim ro'l o'ynaydi. 

#### IDatabase
![image](https://github.com/AlijonovAzamjon2303/BudgetReport/assets/112892881/56833871-921d-4787-90b8-a15487a4e4d9)

#### IReport
![image](https://github.com/AlijonovAzamjon2303/BudgetReport/assets/112892881/4952fde5-e003-4f2a-bca9-3f9d513e5c03)  
IDatabase qabul qiladigan constructor orqali biz Dependency Injection methodini qo'lladik. Bu esa bog'liqlikni tashqaridan boshqarishga yordam beradi.
