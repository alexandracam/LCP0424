namespace a // folder
{
    public class Person // public here means we want to use it outside folder a
    {
        public string Name;
        public double Age;
        public double Weight;

        public string GetInfor()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight:F2}";
        
        }
    }

}