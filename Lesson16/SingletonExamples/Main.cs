namespace Lesson16.SingletonExamples;

public class Main
{
    public static Singleton singleton = new Singleton();

    public static void Run()
    {
        singleton.Do();
    }
}