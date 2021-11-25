using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public Rigidbody rb;
    public float Force = -1000;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Force pushing obstacles towards the player
        rb.AddForce(0, 0, Force * Time.deltaTime);

        //Destroy once offscreen
        if (rb.transform.position[2] < -5)
        {
            Destroy(this.gameObject);
        }
    }
}
