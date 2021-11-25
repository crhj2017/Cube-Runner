using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    private Rigidbody player;

    void LateUpdate()
    {
        transform.LookAt(player.transform);
    }
}
