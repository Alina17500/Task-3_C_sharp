namespace FlyObjectLibrary
{
    public class Helicopter : FlyObject
    {
        public override bool TakeOff()
        {
            if (Height == 0)
            {
                Random r = new Random();
                Height = r.Next(3000, 6000);
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
    }
}
