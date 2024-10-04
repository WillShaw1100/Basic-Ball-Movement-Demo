using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            BallController ball = collision.gameObject.GetComponent<BallController>();

            if (ball.respawnShouldHappen)
            {
                ball.HealPlayer();
                
            }
            ball.AddToScore();

            Destroy(gameObject);
        }
    }
}
