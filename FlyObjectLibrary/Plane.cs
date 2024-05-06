namespace FlyObjectLibrary
{
    public class Plane : FlyObject
    {
        public event EventHandler<OnRunwayEventArgs>? Runway;

        private double _runwayLength;

        public double RunwayLength
        {
            get => _runwayLength;
            set => _runwayLength = value is >= 200 and <= 2000 ? value : 0;
        }

        public override bool TakeOff()
        {
            if (Height == 0 && RunwayLength != 0)
            {
                Random r = new Random();
                Height = r.Next(2000, 20000);
                return true;
            }
            return false;
        }

        public override bool Land()
        {
            if (Height > 0)
            {
                Height = 0;
                return true;
            }
            return false;
        }

        public void OnRunway()
        {
            Runway?.Invoke(this, new OnRunwayEventArgs("Самолёт на взлётной полосе!"));
        }
        
        public class OnRunwayEventArgs(string onRunwayMessage) : EventArgs
        {
            public string OnRunwayMessage { get; } = onRunwayMessage;
        }
    }
}
