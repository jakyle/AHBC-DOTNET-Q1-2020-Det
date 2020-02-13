namespace CarTionary
{
    public class RoomMath
    {
        public static double Pi { get; set; } = 3.14;

        public double GetArea(double length, double width)
        {
            return length * width;
        }

        public static double GetVolume(double length, double width, double height)
        {
            var roomMath = new RoomMath();

            var area = roomMath.GetArea(length, width);

            return area * height;
        }
    }
}
