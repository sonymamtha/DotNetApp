public class CastMember
{
    public CastMember(string Character)
    {
        character = Character;
    }
    public string character {get; set;}
}

public class Show
{
    public Show(int showIdValue, string ShowNameValue)
    {
        showId = showIdValue;
        showName = ShowNameValue;
    }
    private int showId {get; set;}
    private string showName {get; set;}
}
