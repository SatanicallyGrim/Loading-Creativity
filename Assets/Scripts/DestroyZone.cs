using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyObject());
    }
    //Destroys the gameobject after 15 Seconds
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }
}
