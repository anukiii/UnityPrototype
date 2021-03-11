using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFeatures : MonoBehaviour
{

    void Start()
    {
       // timeoutDestructor();
    }
    void timeoutDestructor()
    {
        Destroy(gameObject, 5);
    }
}
