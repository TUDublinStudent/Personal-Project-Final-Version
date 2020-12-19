using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5.0f;
    public int pointValue;
    private GameManager gameManager;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            dirtParticle.Play();
        }
    }
}
