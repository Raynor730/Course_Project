using System.Xml.Serialization;

namespace Game
{   
    public class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());
        }
    }
}