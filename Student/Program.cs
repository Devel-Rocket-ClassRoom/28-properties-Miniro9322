using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Student[] students =
{
    new Student("김철수", 85, 90, 95),
    new Student("이영희", 75, 80, 70),
    new Student("박민수", 100, 100, 0)
};

foreach(var student in students)
{
    Console.WriteLine($"=== 성적표: {student.Name} ===");
    Console.WriteLine($"국어: {student.KoreanScore}, 영어: {student.EnglishScore}, 수학: {student.MathScore}");
    Console.WriteLine($"총점: {student.TotalScore}");
    Console.WriteLine($"평균: {student.Average:f2}");
    Console.WriteLine($"학점: {student.Grade}\n");
}
