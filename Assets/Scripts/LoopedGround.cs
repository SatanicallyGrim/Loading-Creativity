using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Environment/Repeating Grounds")]
public class LoopedGround : MonoBehaviour
{
    #region Variables
    public float speed;
    public float startPoint;
    public float endPoint;
    #endregion
    void Update()
    {
        //Moves Object to the Left of the Screen to the speed of our float 
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //If objects position is lower then the set endpoint it will change position to the start point
        if (transform.position.x <= endPoint)
        {
            Vector2 pos = new Vector2(startPoint, transform.position.y);
            transform.position = pos;
        }
    }


}
