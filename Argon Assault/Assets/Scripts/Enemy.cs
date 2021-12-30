using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] int scorePerHit = 1;
    [SerializeField] int hitPoints = 2;
    Rigidbody rigidBody;

    ScoreBoard scoreBoard;
    GameObject parentGameObject;


    void Start() {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        parentGameObject = GameObject.FindWithTag("SpawnAtRuntime");
        AddRigidbody();
        
    }

    void AddRigidbody() {
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnParticleCollision(GameObject other) {
        ProcessHit();
        if (hitPoints == 0) {
            KillEnemy();
        }
    }

    void ProcessHit() {
        hitPoints = hitPoints - 1;
    }

    void KillEnemy() {
        scoreBoard.IncreaseScore(scorePerHit);
        GameObject vfx = Instantiate(deathFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parentGameObject.transform;
        Destroy(gameObject);
        
    }
}
