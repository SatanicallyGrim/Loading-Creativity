using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Player/Movement")]
public class Movement : MonoBehaviour
{
    #region Variables
    [SerializeField]
    //private float p1Speed = 3f;
    [Header("Jump Variables")]
    public float jmpHeight = 3f;
    private bool p1jumping = false;
    private Rigidbody2D rb;
    #endregion
    private void Awake()
    {
        // calls the Rigidbody2D before the first frame
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves and object to the right multiplied by the player's move speed (Changed it so the background moves instead of the player allowing for the illusion of movement)
        //transform.Translate(Vector2.right * Time.deltaTime * p1Speed);

        if (Input.GetKeyDown(KeyCode.Space) && p1jumping == false)
        {
            //Allows the player to jump multiplied by the player's jump height 
            rb.velocity = (Vector2.up * jmpHeight);
            // once the player has jumped set player's jump to true
            p1jumping = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        // detects if an object has a tag called Ground
        if (col.gameObject.tag == "Ground")
        {
            //if player is colliding with ground tag player's jum is set to false
            p1jumping = false;
        }
    }
}
