namespace ConsultarFipeLibrary.Models
{
    public class Vehicle
    {
        public (string Name, int Index) Type { get; set; }
        public (string Name, string Code) Brand { get; set; }
        public (string Name, string Code) Model { get; set; }
        public (string Name, string Code) Year { get; set; }
        public Vehicle()
        {
            Type = (null, -1);
        }
    }
}
