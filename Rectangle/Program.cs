using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Rectangle square1 = new Rectangle { Width = 10, Height = 5 };
Rectangle square2 = new Rectangle { Width = 7, Height = 7 };
Rectangle square3 = new Rectangle();

Console.WriteLine("=== 사각형 1 ===");
Console.WriteLine($"가로: {square1.Width}, 세로: {square1.Height}");
Console.WriteLine($"넓이: {square1.Area}");
Console.WriteLine($"둘레: {square1.Perimeter}");
Console.WriteLine($"정사각형: {square1.IsSquare}");

Console.WriteLine("\n=== 사각형 2 ===");
Console.WriteLine($"가로: {square2.Width}, 세로: {square2.Height}");
Console.WriteLine($"넓이: {square2.Area}");
Console.WriteLine($"둘레: {square2.Perimeter}");
Console.WriteLine($"정사각형: {square2.IsSquare}");

Console.WriteLine("\n=== 사각형 3 ===");
Console.WriteLine($"가로: {square3.Width}, 세로: {square3.Height}");
Console.WriteLine($"넓이: {square3.Area}");
Console.WriteLine($"둘레: {square3.Perimeter}");
Console.WriteLine($"정사각형: {square3.IsSquare}");