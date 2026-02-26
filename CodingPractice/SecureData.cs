class SecureData
{
    private string _password;
    
    public string Password { set {  _password = value; } }

    public bool Validate(string input)
    {
        return _password == input;
    }
}