Student Management App

Oddiy C# Console Application — studentlarni boshqarish tizimi. CRUD amallarini bajaradi va ma’lumotlar List<Student> orqali saqlanadi.

Texnologiyalar

C# (.NET Console Application)

Repository Pattern

LINQ

Layered Architecture (Domain → Application → Infrastructure → Client)

Loyihaning Strukturasi
Domain/       → Student modeli
Application/  → StudentService
Infrastructure/ → AppDbContext va StudentRepository
Client/       → Program.cs (konsol menyu)

Asosiy Imkoniyatlar

Student qo‘shish

ID bo‘yicha student topish

Ism bo‘yicha qidirish

Studentni yangilash

Studentni o‘chirish

Barcha studentlarni ko‘rish

Ishga tushurish
git clone https://github.com/AIZUEldor/student-management-app
cd student-management-app
dotnet run

Muallif

Eldor Ro‘ziyev
