using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;

    [Space]
    [SerializeField] float minY;


    Rigidbody enemyRb;
    Transform playerTransform;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        HandleMovement();

        DestroyIfFalling();
    }

    private void HandleMovement()
    {
        if (playerTransform.position.y < minY)
            return;


        Vector3 lookDirection = (playerTransform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);
    }

    private void DestroyIfFalling()
    {
        if (transform.position.y < minY)
        {
            Destroy(gameObject);
        }
    }
}
