using AbstractionPractice;

public class Program
{
    public static void Main(string[] args)
    {
        Worker worker1 = new Worker("Ahmet", "Yılmaz", "Yazılım", "Yazılım Geliştirici");
        worker1.Mission();

        Worker worker2 = new Worker("Gizem", "Çelik", "x", "Proje Yöneticisi");
        worker2.Mission();

        Worker worker3 = new Worker("x", "y", "b", "Satış Temsilcisi");
        worker3.Mission();

    }
}