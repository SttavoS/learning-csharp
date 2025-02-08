// See https://aka.ms/new-console-template for more information

public class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine(HowManyLightsabersDoYouOwn("Adam"));
    Console.WriteLine(HowManyLightsabersDoYouOwn("Zach"));
  }

  public static int HowManyLightsabersDoYouOwn(string name)
  {
    return name.Equals("Zach") ? 18 : 0;
  }
}
