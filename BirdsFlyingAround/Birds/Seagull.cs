namespace BirdsFlyingAround.Birds
{
    public class Seagull : Bird, IFly
    {
        public Seagull(double longitude, double latitude, double altitude)
            : base(longitude, latitude)
        {
            Altitude = altitude;
        }

        public double Altitude { get; private set; }

        public void SetAltitude(double altitude)
        {
            Altitude = altitude;
        }
    }
}
