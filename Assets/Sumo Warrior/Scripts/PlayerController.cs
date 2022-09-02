using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;

    [Space]
    [SerializeField] private Transform focalPoint;
    [SerializeField] private GameObject powerupIndicator;

    [Space]
    [SerializeField] private float powerupStrength = 15.0f;
    public bool hasPowerup;


    Rigidbody playerRb;
    IEnumerator countdownCo;

    void Start()
    {
        countdownCo = PowerupCountdownRoutine();

        hasPowerup = false;

        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleInput();

        PositionPowerupIndicator();
    }

    private void HandleInput()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce
            (force: focalPoint.forward * forwardInput * speed);
    }

    private void PositionPowerupIndicator()
    {
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);


            hasPowerup = true;
            powerupIndicator.SetActive(true);

            StopCoroutine(countdownCo); // stop it.
            StartCoroutine(countdownCo); // start the coroutine
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {

            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            enemyRb.AddForce
                (force: awayFromPlayer * powerupStrength, mode: ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);

        hasPowerup = false;
        powerupIndicator.SetActive(false);
    }
}
