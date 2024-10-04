using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float forceMult = 10.0f;

    public bool respawnShouldHappen = false;
    public Material Injured;
    public Material Healthy;
    public Vector3 respawnPosition = new Vector3(0, 2, 0);
    private int score = 0;
    public TextMeshProUGUI ScoreText;

    void Start()
    {
        ScoreText.text = "Score: " + score;
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(h, 0.0f, v) * forceMult;
        GetComponent<Rigidbody>().AddForce(force);
    }

    public void RespawnPlayer()
    {
        transform.position = respawnPosition;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
        }
        respawnShouldHappen = false;
        GetComponent<Renderer>().material = Healthy;
        Debug.Log("Player respawned");
    }

    public void InjurePlayer()
    {
        GetComponent<Renderer>().material = Injured;
        respawnShouldHappen = true;
        Debug.Log("Player injured");
    }

    public void HealPlayer()
    {
        GetComponent<Renderer>().material = Healthy;
        respawnShouldHappen = false;
        Debug.Log("Player Healed");
    }

    public void AddToScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
        Debug.Log("Player Score now "+score);
    }

    public void RemoveFromScore()
    {
        if (score > 0) {
            score--;
            ScoreText.text = "Score: " + score;
            Debug.Log("Player Score now " + score);
        }
    }
}
