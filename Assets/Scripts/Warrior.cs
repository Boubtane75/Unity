using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Warrior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Arrow")
        {
            GetComponent<Animator>().SetBool("isDead",true);
            GetComponent<NavMeshAgent>().speed = 0;
            GameController.instance.addScore(10);
            Destroy(collision.gameObject);
            //Destroy(this.gameObject);

        }
    }
}
