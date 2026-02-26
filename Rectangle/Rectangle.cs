class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    public int Area { get { return Width * Height; } }
    public int Perimeter { get { return 2 * (Width + Height); } }
    public bool IsSquare { get { return Width == Height; } }
}