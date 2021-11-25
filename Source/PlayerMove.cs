using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float Force;

    // Restarts game
    void Restart()
    {
        // Resets and position of player
        rb.position = new Vector3(0, 20, 5);
        rb.velocity = Vector3.zero;

        /* Resets rotation of player
        Vector3 rotationVector = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);
        rb.rotation = rotation;
        */    
    }

    void Update()
    {
        // Checks for losing state
        if (rb.position[1] <= -5)
        {
            Invoke("Restart", 0.0f);
        }
    }

    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.AddForce(moveHorizontal * Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
