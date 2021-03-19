using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHighScoreNick : MonoBehaviour
{
    // Function that will be called when clicking button
    public void Reset()
    {
        // Deletes specific player preferences data named inbetween the brackets
        PlayerPrefs.DeleteKey("HighScore");
        PlayerPrefs.DeleteKey("HighScore2");
    }
}
