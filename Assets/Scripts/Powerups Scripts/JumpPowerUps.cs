using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Powerups/Jump")]
public class JumpPowerUps : MonoBehaviour
{
    #region Variables
    [Header("Jump Powerup variables")]
    public float pUpMoveSpeed = 5f;
    public float multiplier = 5f;
    public float powerUpDuration = 5f;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves Object to the left multiplied by a speed variable 
        transform.Translate(Vector2.left * Time.deltaTime * pUpMoveSpeed);
    }
    #region Collect/Dettect
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if a cllision occurs with an object with a tag marked as Player
        if (collision.gameObject.tag == "Player")
        {
            // Use the Collect Function inside of a coroutine
           StartCoroutine(Collect(collision));
        }
    }
    //function used to Collect powerups by detecting a 2D Collider and the player
    IEnumerator Collect(Collider2D player)
    {
        //calls the movement script and defines it as stats as well as making stats inherit the veriables whithin the movement script
        Movement stats = player.GetComponent<Movement>();
        //Multiplies the values of the jump multplier and the powerup jump multiplier  
        stats.jmpHeight *= multiplier;
        //Disables both the Sprite Renderer and the collider due to the powerup not deleting until the waitforseconds has finished
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        // sets a timer for the powerups duration effect
        yield return new WaitForSeconds(powerUpDuration);
        //Removes the effect of the powerup by dividing the by out muliplier to get the base stats
        stats.jmpHeight /= multiplier;
        //once the powerup has found the player and the collision has occured destroy the gameobject
        Destroy(gameObject);
    }
    #endregion
}
