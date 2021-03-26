using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Powerups/Speed")]
public class SpeedPowerUp : MonoBehaviour
{
    #region Variables
    [Header("Grounds")]
    public LoopedGround loop1;
    public LoopedGround loop2;
    [Header("Powerup Variables")]
    public float multiplier = 5f;
    public float pUpMoveSpeed = 5f;
    public float powerUpDuration = 5f;
    [Header("Effects")]
    public GameObject fireEffect1;
    public GameObject fireEffect2;
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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Collect(collision));
            
        }

    }
    // IEnumerator used in order to allow for a Coroutine 
    public IEnumerator Collect(Collider2D player)
    {
        //turns on the animation effect
        fireEffect1.SetActive(true);
        fireEffect2.SetActive(true);
        // Multiplies the speed by the powerup multiplier for both objects 
        loop1.speed *= multiplier;
        loop2.speed *= multiplier;
        //Disables both the Sprite Renderer and the collider due to the powerup not deleting until the waitforseconds has finished
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        // sets a timer for the powerups duration effect
        yield return new WaitForSeconds(powerUpDuration);
        //Removes the effect of the powerup by dividing the by out muliplier to get the base stats
        loop1.speed /= multiplier;
        loop2.speed /= multiplier;
        //turns off the animation effect
        fireEffect1.SetActive(false);
        fireEffect2.SetActive(false);
        //Destroys the powerup/Removes from Scene after 20 due to an issue where it will stop it from instantiating 
        Destroy(gameObject , 20);
    }
}
