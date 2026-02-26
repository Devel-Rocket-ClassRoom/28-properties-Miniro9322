class Page
{
    public string Message { get; private set; } = "읽기 전용 메시지";

    public void UpdateMessage()
    {
        Message = "업데이트된 메시지";
    }
}