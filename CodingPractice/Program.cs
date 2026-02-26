using System;

// README.md를 읽고 아래에 코드를 작성하세요.

//1
case1.Player player = new case1.Player();
player.Health = 100;
player.Health = -999;

//2
case2.Player player2 = new case2.Player();
player2.SetHealth(100);
Console.WriteLine(player2.GetHealth());

//3
case1.Person person = new case1.Person();
person.Name = "홍길동";
Console.WriteLine(person.Name);

//4
Developer developer = new Developer();
developer.Name = "김개발";
developer.Age = 25;
Console.WriteLine($"{developer.Name}, {developer.Age}세");

//5
case3.Player player3 = new case3.Player();
Console.WriteLine($"이름: {player3.Name}");
Console.WriteLine($"레벨: {player3.Level}");
Console.WriteLine($"최대 체력: {player3.MaxHealth}");

//6
Car car = new Car();
car.Name = "소나타";
car.Color = "검정";
Console.WriteLine($"{car.Name}, {car.Color}");

//7
Product product = new Product();
Console.WriteLine(product.Manufacturer);

//8
Page page = new Page();

Console.WriteLine(page.Message);
page.UpdateMessage();
Console.WriteLine(page.Message);

//9
SecureData secureData = new SecureData();
secureData.Password = "secret123";
Console.WriteLine(secureData.Validate("secret123"));

//10
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}\n넓이: {circle.Area}\n둘레: {circle.Circumference}");

//11
Counter counter = new Counter();
counter.Count = 10;
counter.Increase();

Console.WriteLine($"카운트: {counter.Count}");

//12
case4.Player player4 = new case4.Player();
player4.Health = 150;
Console.WriteLine($"체력: {player4.Health}");
player4.Health = -50;
Console.WriteLine($"체력: {player4.Health}");

//13
case2.Person person2 = new case2.Person();
person2.Name = "홍길동";
person2.BirthYear = 2000;
Console.WriteLine($"{person2.Name}님의 나이: {person2.Age}세");

//14
Course course = new Course();
course.Id = 1;
course.Title = "C# 기초";

Console.WriteLine($"{course.Id} - {course.Title}");

//15
Course[] course2 =
{
    new Course {Id = 2, Title = "Unity 게임 개발"},
    new Course {Id = 1, Title = "C# 기초"},
    new Course {Id = 2, Title = "C# 중급"},
    new Course {Id = 3, Title = "Unity 입문"}
};

foreach(var temp in course2)
{
    Console.WriteLine($"{temp.Id} - {temp.Title}");
}

//16
Customer customer = new Customer
{
    Id = 1,
    Name = "김철수",
    Email = "kim@example.com",
    City = "서울"
};

Console.WriteLine($"고객 #{customer.Id}");
Console.WriteLine($"이름: {customer.Name}");
Console.WriteLine($"이메일: {customer.Email}");
Console.WriteLine($"도시: {customer.City}");

//17
Console.WriteLine($"게임: {GameSettings.GameTitle}");
Console.WriteLine($"최대 플레이어: {GameSettings.MaxPlayers}");
Console.WriteLine($"사운드: {GameSettings.IsSoundEnabled}");

GameSettings.MaxPlayers = 8;
Console.WriteLine($"변경된 최대 플레이어: {GameSettings.MaxPlayers}");

//18
Monster goblin = new Monster("고블린");
goblin.Level = 5;
goblin.Attack = 15;

Console.WriteLine($"이름: {goblin.Name}");
Console.WriteLine($"레벨: {goblin.Level}");
Console.WriteLine($"체력: {goblin.Health}");
Console.WriteLine($"공격력: {goblin.Attack}");
Console.WriteLine($"방어력: {goblin.Defense}");
Console.WriteLine($"생존: {goblin.IsAlive}");

goblin.TakeDamage(50);
Console.WriteLine($"50 대미지 후 체력: {goblin.Health}");