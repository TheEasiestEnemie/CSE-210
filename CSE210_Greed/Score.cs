using Raylib_cs;

public class Score
{
    public int score
    {
        get;
        set;
    }

    public Score()
    {
        score = 60;
    }
    
    public void DisplayScore(Score score)
    {
        int points = score.score;
        Raylib.DrawText($"Score: {points}" , 12, 12, 20, Color.WHITE);
    }

    public void ChangeScore(Score score, Collectable collectable, Player player)
    {
        if (Raylib.CheckCollisionRecs(player.model, collectable.model))
        {
            score.score += collectable.GetPointValue();
        }
       
    }

}