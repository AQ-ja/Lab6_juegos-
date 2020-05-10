using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
