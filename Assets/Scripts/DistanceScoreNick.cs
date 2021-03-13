using UnityEngine;
// Needed when using any UI object
using UnityEngine.UI;

public class DistanceScoreNick : MonoBehaviour
{
    // Assigning name of transform component
    public Transform player;
    // Assigning name of text components
    public Text scoreText;
    public Text highScore;
    public Text highScore2;
   
    

    private void Start()
    {
        // Both text objects are stored as a floats in player preferences 
        // They are displayed as whole numbers because of ("0")
        // High score is initially set to 0
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        highScore2.text = PlayerPrefs.GetFloat("HighScore2", 0).ToString("0");
    }

    private void Update()
    {
        // Setting text equal to player position
        // ToString converts player position from float to string
        // "0" allows only whole numbers to be shown
        scoreText.text = player.position.x.ToString("0");
        
        // If player position is greater than high score
        // Set high score to player position (creates a new high score)
        if (player.position.x > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", player.position.x);
            highScore.text = player.position.x.ToString("0");
        }
        if (player.position.x > PlayerPrefs.GetFloat("HighScore2", 0))
        {
            PlayerPrefs.SetFloat("HighScore2", player.position.x);
            highScore2.text = player.position.x.ToString("0");
        }
    }
}

   


        



