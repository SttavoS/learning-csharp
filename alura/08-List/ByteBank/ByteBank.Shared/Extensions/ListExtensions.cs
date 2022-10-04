namespace ByteBank.Shared.Extensions;

public static class ListExtensions
{
    public static void AddSeveral<T>(this List<T> list, params T[] itens)
    {
        foreach (var item in itens)
        {
            list.Add(item);
        }
    }
}