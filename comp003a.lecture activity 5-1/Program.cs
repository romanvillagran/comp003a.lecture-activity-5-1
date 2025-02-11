using System.Xml.Serialization;

namespace comp003a.lecture_activity_5_1
{
    internal class car
    {
        //fields 
        public string Make;
        public string Model;
        public int Year;

        ///<summary>
        ///Displays the car information
        ///</summary>

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Model} {Year}");
        }
    }

    internal class program
    {
        static void Main( string[] args )
        {

        }
    }
}
