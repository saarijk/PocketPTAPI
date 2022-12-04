namespace TestingApi.Models
{
    public class User { 
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int HeightCm { get; set; }
        public double Bmi { get; set; }
        //public double Bmi => (Weight / ((HeightCm/100) * (HeightCm/100)));
        public long Id { get; set; }

    }
}
