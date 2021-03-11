using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Destination : MonoBehaviour
{

    public Transform Dest;
    public NavMeshAgent agent;
    public Transform respawn;
    public Rigidbody enemy;
    

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Dest.position;


    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            transform.position = respawn.position;
            Destroy(other.gameObject);
            Rigidbody enemyOther;
            enemyOther = Instantiate(enemy, respawn.position, transform.rotation);
            healthBAr.SetHealthBarValue(healthBAr.GetHealthBarValue() + 0.005f);

        }





    }

    void OnTriggerStay(Collider other)
    {

        if (other.tag == "Bullet")
        {
            transform.position = respawn.position;
            Destroy(other.gameObject);
            //Rigidbody enemyOther;
           //enemyOther = Instantiate(enemy, respawn.position, transform.rotation);
        }
        if (other.tag == "Health")
        {
           healthBAr.SetHealthBarValue(healthBAr.GetHealthBarValue() - 0.001f);
        }
}

}




