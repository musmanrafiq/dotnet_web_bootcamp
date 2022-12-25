
// dont ever put business logic inside startup class
using AllConsole;

struct Location
{
    public int x, y;

    public Location(int x, int y) { this.x = x; this.y = y; }

}
public class Program
{
    public static void Main(string[] args)
    {

        Location location = new Location(10,10);
        Location location1 = location;
        location.x = 20;

        Console.WriteLine(location.x + " "+ location1.x);

        
       
    }
}