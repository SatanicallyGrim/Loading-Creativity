using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    #region Variables
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
        transform.Translate(Vector2.left * Time.deltaTime * pUpspeed);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Collect(collision);
        }
    }
    void Collect(Collider2D player)
    {
        Movement stats = player.GetComponent<Movement>();
        stats.jmpHeight += multiplier;
        Destroy(gameObject);
    }
}
