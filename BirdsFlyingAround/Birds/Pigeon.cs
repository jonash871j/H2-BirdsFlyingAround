namespace BirdsFlyingAround.Birds
{
    public class Pigeon : Bird, IFly
    {
        public Pigeon(double longitude, double latitude, double altitude)
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
