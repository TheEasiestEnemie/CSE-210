using System.Numerics;
public static class VectorCalculation {

    public static Vector2 GetDirectionVector(Vector2 startPoint, Vector2 endPoint) {
        Vector2 directionVector;
        directionVector.X = endPoint.X - startPoint.X;
        directionVector.Y = endPoint.Y - startPoint.Y;
        return directionVector;
    }

    public static double GetAngle(Vector2 firstVector, Vector2 secondVector) {
        double dotProduct = (firstVector.X * secondVector.X) + (firstVector.Y * secondVector.Y);
        double step2 = dotProduct / (GetVectorMagnitude(firstVector) * GetVectorMagnitude(secondVector));
        double angle = Math.Acos(step2);
        return angle;
    }

    public static double GetVectorMagnitude(Vector2 vector) {
        double sum = Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2);
        return Math.Sqrt(sum);
    }

    
}

