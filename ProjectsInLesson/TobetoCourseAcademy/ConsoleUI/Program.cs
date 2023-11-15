using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;


CourseManager courseManager = new CourseManager(new EfCourseDal());

foreach (var course in courseManager.GetAll())
{
    Console.WriteLine("Kurs Adı: " + course.Name);
    Console.WriteLine("Kurs Açıklaması: " + course.Description);
    Console.WriteLine("Eğitmenler :");
    foreach (var instructor in course.GetCourseInstructors)
    {
        Console.WriteLine("   - " + instructor.Instructor.FirstName + " " + instructor.Instructor.LastName);
    }
    Console.WriteLine("Kategori: " + course.Category.Name);
    Console.WriteLine("Fiyat: TL" + course.Price);
    Console.WriteLine("-----------------");
}



//CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

//foreach (var category in categoryManager.GetAll())
//{
//    Console.WriteLine(category.Name);
//}


//foreach (var course in courseManager.GetAll())
//{
//    Console.WriteLine(course.Name);
//}

//Course course = new Course();
//course.Id = 4;
//course.Name = "CSharpA";
//course.Price = 200;
//course.Description = "CSharpA ";
//course.CategoryId = 1;
//course.ImageUrl = "csharpimage2.jpg";

//courseManager.Add(course);
//courseManager.Update(course);
//courseManager.Delete(course);


















//---------------------------------------



//Derste Yapıldı
//using Business.Concretes;
//using Entities.Concretes;

//Category category1 = new Category { Id = 1, Name = "Programlama" };

//CategoryManager categoryManager = new CategoryManager();
//categoryManager.Add(category1);



//Sıfırdan proje (solution) oluşturunuz-->TobetoETrade //Product sınıfını katmanlarında işletiniz. //Product -->Id,Name,UnitPrice
//program.cs de mutlaka veri girişleri yapınız.
//tüm pairler bitmeden sonraki aşamaya geçmek yok :)
//tüm pairler bitince 10 dk mola.
//İkinci aşama. Önceki derste (çarşamba) oluşturduğumuz 4 varlığı (entity) //TobetoCourseAcademy projesine uygulayınız. //program.cs de mutlaka veri girişleri yapınız.



// 
//using Business.Concretes;
//using DataAccess.Abstracts;
//using DataAccess.Concretes;
//using Entities.Concretes;

//IGenericRepository categoryDal = new AdoNetCategoryDal();
//IGenericRepository courseDal = new AdoNetCourseDal();
//IGenericRepository instructorDal = new AdoNetInstructorDal();

//CategoryManager categoryManager = new CategoryManager();

//categoryManager.Add(categoryDal);
//categoryManager.Add(courseDal);
//categoryManager.Add(instructorDal);


////Kategorileri oluştur
//var category1 = new Category { Id = 1, Name = "Bilgisayar Bilimleri" };
//var category2 = new Category { Id = 2, Name = "Mühendislik" };


//// Kursları oluştur
//var course1 = new Course
//{
//    Id = 1,
//    CategoryId = 1,
//    Name = "C# Programlama",
//    Description = "C# programlamaya giriş kursu",
//    ImageUrl = "csharp.jpg",
//    Price = 99
//};

//var course2 = new Course
//{
//    Id = 2,
//    CategoryId = 1,
//    Name = "Veritabanı Yönetimi",
//    Description = "Veritabanı yönetimi kursu",
//    ImageUrl = "database.jpg",
//    Price = 79
//};

//var course3 = new Course
//{
//    Id = 3,
//    CategoryId = 2,
//    Name = "Elektrik Mühendisliği Temelleri",
//    Description = "Elektrik mühendisliği temel kursu",
//    ImageUrl = "elektrik.jpg",
//    Price = 119
//};



//// Eğitmenleri oluştur
//var instructor1 = new Instructor { Id = 1, FirstName = "Özkan", LastName = "Akkaya" };
//var instructor2 = new Instructor { Id = 2, FirstName = "Özkan1", LastName = "Akkaya1" };

//// Kurs ve eğitmen ilişkilerini oluştur
//var courseInstructor1 = new CourseInstructor { Id = 1, CourseId = 1, InstructorId = 1 };
//var courseInstructor2 = new CourseInstructor { Id = 2, CourseId = 2, InstructorId = 2 };
//var courseInstructor3 = new CourseInstructor { Id = 3, CourseId = 3, InstructorId = 1 };
//var courseInstructor4 = new CourseInstructor { Id = 4, CourseId = 1, InstructorId = 2 };


//// Kategorilere kursları ekle
//category1.Courses = new List<Course> { course1, course2 };
//category2.Courses = new List<Course> { course3 };

//// Eğitmenlere kursları ekle
//instructor1.GetCourseInstructors = new List<CourseInstructor> { courseInstructor1, courseInstructor3 };
//instructor2.GetCourseInstructors = new List<CourseInstructor> { courseInstructor2, courseInstructor4 };

//// Kurslara kategori ve eğitmen bilgileri ekle
//course1.Category = category1;
//course2.Category = category1;
//course3.Category = category2;

//course1.GetCourseInstructors = new List<CourseInstructor> { courseInstructor1, courseInstructor4 };
//course2.GetCourseInstructors = new List<CourseInstructor> { courseInstructor2 };
//course3.GetCourseInstructors = new List<CourseInstructor> { courseInstructor3 };


//Console.WriteLine("Kategori Adı: " + category1.Name);

//foreach (var course in category1.Courses)
//{
//    Console.WriteLine("Kurs Adı: " + course.Name);
//    Console.WriteLine("Kurs Açıklaması: " + course.Description);
//    foreach (var item in course.GetCourseInstructors)
//    {
//        Console.WriteLine("Eğitmen: " + item.InstructorId);
//    }
//    Console.WriteLine("Fiyat: TL" + course.Price);
//    Console.WriteLine("Kategori: " + course.Category.Name);
//    Console.WriteLine();
//}

//Console.WriteLine("Kategori Adı: " + category2.Name);
//foreach (var course in category2.Courses)
//{
//    Console.WriteLine("Kurs Adı: " + course.Name);
//    Console.WriteLine("Kurs Açıklaması: " + course.Description);
//    foreach (var item in course.GetCourseInstructors)
//    {
//        Console.WriteLine("Eğitmen: " + item.InstructorId);
//    }
//    Console.WriteLine("Fiyat: TL" + course.Price);
//    Console.WriteLine("Kategori: " + course.Category.Name);
//    Console.WriteLine();
//}