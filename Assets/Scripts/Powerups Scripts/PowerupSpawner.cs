using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    #region Variables
    public GameObject powerUp;
    public bool spawnable = true;
    public float spawnTime;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        // starts a Coroutine of PowerupSpawn
        StartCoroutine(PowerupSpawn(powerUp));
    }

    private void SpawnItem()
    {
        //Instantiating a Powerup At the current postion 
         powerUp = Instantiate(powerUp, transform.position, transform.rotation);
    }
    public IEnumerator PowerupSpawn(GameObject drop)
    {
        //while Loop to continously spawn power ups
        while (spawnable)
        {
            //Reactivates the sprite render and 2DCollider
            powerUp.GetComponent<SpriteRenderer>().enabled = true;
            powerUp.GetComponent<Collider2D>().enabled = true;
            //calls the function to spawn/instantiate an object
            SpawnItem();
            //Quick Debug to see if an object was spawning
            Debug.Log("Object has been dropped");
            //A Timer so before it spawns another powerup based on the the set spawn time 
            yield return new WaitForSeconds(spawnTime);

        }
        
    }
}
