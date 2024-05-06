namespace FlyObjectLibrary
{
    public abstract class FlyObject
    {
        protected double Height { get; set; }

        public abstract bool TakeOff();
        public abstract bool Land();
    }
}
