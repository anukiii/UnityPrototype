using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform respawn;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Bullet"){
            other.transform.position = respawn.position;

        }
        else
        {
            Destroy(other.gameObject);

        }
    }
}
