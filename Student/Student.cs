class Student
{
    private readonly string _name;
    private int _koreanScore;
    private int _englishScore;
    private int _mathScore;
    private int _totalScore;
    private double _average;
    private char _grade;

    public string Name
    {
        get { return _name; }
    }
    public int KoreanScore
    {
        get { return _koreanScore; }

        set
        {
            if(value < 0)
            {
                _koreanScore = 0;
            }
            else if(value > 100)
            {
                _koreanScore = 100;
            }
            else
            {
                _koreanScore = value;
            }
        }
    }

    public int EnglishScore
    {
        get { return _englishScore; }

        set
        {
            if (value < 0)
            {
                _englishScore = 0;
            }
            else if (value > 100)
            {
                _englishScore = 100;
            }
            else
            {
                _englishScore = value;
            }
        }
    }

    public int MathScore
    {
        get { return _mathScore; }

        set
        {
            if (value < 0)
            {
                _mathScore = 0;
            }
            else if (value > 100)
            {
                _mathScore = 100;
            }
            else
            {
                _mathScore = value;
            }
        }
    }

    public int TotalScore { get { return KoreanScore +  EnglishScore + MathScore; }  }

    public double Average { get { return (double)TotalScore / 3; } }
    public char Grade
    {
        get
        {
            if(TotalScore >= 90)
            {
                return _grade = 'A';
            }
            else if (TotalScore >= 80)
            {
                return _grade = 'B';
            }
            else if (TotalScore >= 70)
            {
                return _grade = 'C';
            }
            else if (TotalScore >= 60)
            {
                return _grade = 'D';
            }
            else
            {
                return _grade = 'F';
            }

        }
    }

    public Student(string name, int koreanScore, int englishScore, int mathScore)
    {
        this._name = name;
        KoreanScore = koreanScore;
        EnglishScore = englishScore;
        MathScore = mathScore;

    }
}