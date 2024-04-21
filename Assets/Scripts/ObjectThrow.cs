using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrow : MonoBehaviour
{
    public float throwForce = 10f;
    public GameObject ballPrefab;
    private Animator animator;
    private ScreenShaker screenShake;

    void Start()
    {
        // Animator bileþenine eriþimi al
        animator = GameObject.Find("AnimatedCharacter").GetComponent<Animator>();
        GameObject screenShakeObject = GameObject.FindWithTag("ScreenShakeController");

        if (screenShakeObject != null)
        {
            screenShake = screenShakeObject.GetComponent<ScreenShaker>();
        }
        else
        {
            Debug.LogError("ScreenShake GameObject not found!");
        }

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !animator.GetBool("bombaAtiyorMu")) // Check if left mouse button is pressed
        {
            animator.SetBool("bombaAtiyorMu", true);
        }

        if (Input.GetMouseButtonUp(0) && animator.GetBool("bombaAtiyorMu"))
        {
            // Animator'deki boolean parametresine deðeri ata
            StartCoroutine(StopAnim());
        }
    }

    public void SpawnAndThrowBall()
    {
        // Spawn the ball at the current position of the GameObject this script is attached to
        GameObject newBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);

        // Get the direction from the camera to the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 direction = ray.direction;

        // Apply force to the ball in the direction of the mouse position
        Rigidbody ballRigidbody = newBall.GetComponent<Rigidbody>();
        if (ballRigidbody != null)
        {
            ballRigidbody.AddForce(direction * throwForce, ForceMode.Impulse);
        }
        
        
    }

    IEnumerator StopAnim()
    {

        yield return new WaitForSeconds(1.5f);
        SpawnAndThrowBall();
        screenShake.ShakeScreen();
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("bombaAtiyorMu", false);
        
    }
}
