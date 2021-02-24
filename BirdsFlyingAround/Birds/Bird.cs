namespace BirdsFlyingAround.Birds
{
    public abstract class Bird
    {
        public Bird(double longitude, double latitude)
        {
            Longtitude = longitude;
            Latitude = latitude;
        }

        public double Longtitude { get; private set; }
        public double Latitude { get; private set; }

        public virtual void SetLocation(double longitude, double latitude)
        {
            Longtitude = longitude;
            Latitude = latitude;
        }
    }
}
