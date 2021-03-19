using UnityEngine;
// Needed when using any UI object
using UnityEngine.UI;

public class DistanceScoreNick : MonoBehaviour
{
    // Assigning names to text components
    public Text scoreText;
    public Text highScore;
    public Text highScore2;

    // Score Variables
    public float pointsAmount;
    public float pointsIncreasedPerSecond;
   
    

    private void Start()
    {
        // initial amount of points
        // initial amount of points increase per second
        pointsAmount = 0f;
        pointsIncreasedPerSecond = 1f;

        // Both text objects are stored as a floats in player preferences 
        // They are displayed as whole numbers because of ("0")
        // High score is initially set to 0
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        highScore2.text = PlayerPrefs.GetFloat("HighScore2", 0).ToString("0");
    }

    private void Update()
    {                
        // Setting text equal to amount of points
        // ToString converts player position from float to string
        // "0" allows only whole numbers to be shown
        scoreText.text = pointsAmount.ToString("0");
        pointsAmount += pointsIncreasedPerSecond * Time.deltaTime;

        // If amount of points is greater than high score
        // Set high score to amount of points (creates a new high score)
        if (pointsAmount > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", pointsAmount);
            highScore.text = pointsAmount.ToString("0");
        }
        if (pointsAmount > PlayerPrefs.GetFloat("HighScore2", 0))
        {
            PlayerPrefs.SetFloat("HighScore2", pointsAmount);
            highScore2.text = pointsAmount.ToString("0");
        }
    }
}

   


        



