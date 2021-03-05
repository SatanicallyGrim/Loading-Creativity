using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    #region Variables
    [Header("Powerup variables")]
    public float pUpspeed = 5f;
    public float multiplier = 5f;
    

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves Object to the left multiplied by a speed variable 
        transform.Translate(Vector2.left * Time.deltaTime * pUpspeed);
    }
    #region Collect/Dettect
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if a cllision occurs with an object with a tag marked as Player
        if (collision.gameObject.tag == "Player")
        {
            // Use the Collect Function 
            Collect(collision);
        }
    }
    //function used to Collect powerups by detecting a 2D Collider and the player
    void Collect(Collider2D player)
    {
        //calls the movement script and defines it as stats as well as making stats inherit the veriables whithin the movement script
        Movement stats = player.GetComponent<Movement>();
        //Adds the values of the jump multplier and the powerup jump multiplier  
        stats.jmpHeight += multiplier;
        //once the powerup has found the player and the collision has occured destroy the gameobject
        Destroy(gameObject);
    }
    #endregion
}
