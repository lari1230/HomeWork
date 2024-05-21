using Newtonsoft.Json;
public class Class1
{
    public int[] arr { get; set; }
    public List<Class2> listClass2 { get; set; }
}
public class Class2
{
    public int num { get; set; }
    public string str { get; set; }
    public float[] arr { get; set; }
}
class Program
{
    static void Main()
    { 
        Class1 class1 = new Class1()
        {
            listClass2 = new List<Class2>
            {

                    new Class2
                    {
                        num = 1,
                        str = "ааа",
                        arr = new float[] { 1.1f, 2.2f, 3.3f },
                    },

                    new Class2
                    {
                        num = 2,
                        str = "ddd",
                        arr = new float[] { 4.4f, 5.5f, 6.6f },
                    },
            }
        };

        string json = JsonConvert.SerializeObject(class1);
        File.WriteAllText("file.json", json);
        Console.WriteLine("JSON created.");
    }
}
