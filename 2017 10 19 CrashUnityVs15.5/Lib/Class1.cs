public class Class1
{
    public static unsafe int Unsafe(string s)
    {
        fixed (char* ps = s)
        {
            return ps[0];
        }
    }
}