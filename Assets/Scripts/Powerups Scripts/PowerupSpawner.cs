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
        StartCoroutine(PowerupSpawn(powerUp));
    }

    private void SpawnItem()
    {
         powerUp = Instantiate(powerUp, transform.position, transform.rotation);
    }
    public IEnumerator PowerupSpawn(GameObject drop)
    {
        while (spawnable)
        {
            powerUp.GetComponent<SpriteRenderer>().enabled = true;
            powerUp.GetComponent<Collider2D>().enabled = true;
            SpawnItem();
            Debug.Log("Object has been dropped");
            yield return new WaitForSeconds(spawnTime);

        }
        
    }
}
