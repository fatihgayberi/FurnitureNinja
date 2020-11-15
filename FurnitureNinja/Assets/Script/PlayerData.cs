/** 
 * Oyunun verilerini saklamak icin kullanilan Class yapisidir.
 */

public class PlayerData
{
    public int highScore = 0;

    public void SetHighScore(int newHighScore)
    {
        highScore = newHighScore;
    }

    public int GetHighScore()
    {
        return highScore;
    }
}
