public interface IFruit
{
    string GetColor();
}
public class Apple : IFruit
{
    public string GetColor()
    {
        return "Red";
    }
}
public class Orange : IFruit
{
    public string GetColor()
    {
        return "Orange";
    }
}
