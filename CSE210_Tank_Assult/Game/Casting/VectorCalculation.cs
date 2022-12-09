using System.Numerics;
using Raylib_cs;
public static class VectorCalculation {

    public static Vector2 GetDirectionVector(Vector2 startPoint, Vector2 endPoint) {
        Vector2 directionVector;
        directionVector.X = endPoint.X - startPoint.X;
        directionVector.Y = endPoint.Y - startPoint.Y;
        //Raylib.DrawLine((int)startPoint.X, (int)startPoint.Y, (int)directionVector.X /* + (int)startPoint.X */, (int)directionVector.Y /*+ (int)startPoint.Y*/, Raylib_cs.Color.BLUE);

        //Console.WriteLine("Direction Vector: " + directionVector.X + ", " + directionVector.Y);
        Raylib.DrawLine((int)startPoint.X, (int)startPoint.Y, (int)endPoint.X, (int)endPoint.Y, Raylib_cs.Color.WHITE);
        return directionVector;
    }

    public static double GetAngle(Vector2 firstVector, Vector2 secondVector) {
        double dotProduct = (firstVector.X * secondVector.X) + (firstVector.Y * secondVector.Y);
        double step2 = dotProduct / (GetVectorMagnitude(firstVector) * GetVectorMagnitude(secondVector));
        double angle = Math.Acos(step2);

        if (Math.Sqrt(Math.Pow(angle, 2)) < 0.00001 || angle.Equals(double.NaN)) {
            angle = 0;
        }
        
        return angle;
    }

    public static double GetVectorMagnitude(Vector2 vector) {
        double sum = Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2);
        double final = Math.Sqrt(sum);
        //Console.WriteLine("Magnitude: " + final);
        return final;
    }

    public static double ConvertToDegrees(double angle) {
        return angle * (180.0 / Math.PI);
    }
}

