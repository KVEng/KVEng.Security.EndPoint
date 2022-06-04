namespace KVEng.Security.EndPoint.Library;
public class AllPass : IVerifiable
{
    public bool Verify(string str)
    {
        return true;
    }
}
