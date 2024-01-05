using POO.ContentContext;

// var articles = new List<Article>();
// articles.Add(new Article("Artigo sobre POO", "Orientação objetos"));
// articles.Add(new Article("Artigo sobre typescript", "typescript"));
// articles.Add(new Article("Artigo sobre fundamentos em c#", "C#"));
// articles.Add(new Article("Artigo sobre Lista em .NET", "dotnet"));

// foreach (var article in articles)
// {
//   Console.WriteLine(article.Id);
//   Console.WriteLine(article.Title);
//   Console.WriteLine(article.Url);
// }

var courses = new List<Course>();
var courseCSharp = new Course("curso de c#", "csharp");
var courseDotnet = new Course("curso de .NET", "dotnet");
var coursePoo = new Course("curso de POO", "csharp-poo");
courses.Add(courseCSharp);
courses.Add(courseDotnet);
courses.Add(coursePoo);

var careers = new List<Career>();
var careersData = new Career("especialista dotnet", "especialista-dotnet");
var careerItem = new CareerItem(1, "Comece por aqui", " ", null);
careersData.Items.Add(careerItem);
careers.Add(careersData);

foreach (var career in careers)
{
  Console.WriteLine(career.Title);
  foreach (var item in career.Items.OrderBy(x => x.Order))
  {
    Console.WriteLine($"{item.Order} - {item.Title}");
    Console.WriteLine($"{item.Course?.Title}");
    Console.WriteLine($"{item.Course?.Level}");
    foreach (var notification in item.Notifications)
    {
      Console.WriteLine($"{notification.Property}- {notification.Message}");
    }
  }
}