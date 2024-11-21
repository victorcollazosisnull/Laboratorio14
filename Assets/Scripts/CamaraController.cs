using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 vector3;

    void FixedUpdate()
    {
        Vector3 position = new Vector3(player.position.x + vector3.x, transform.position.y, transform.position.z);

        Vector3 moveSmooth = Vector3.Lerp(transform.position, position, smoothSpeed);

        transform.position = moveSmooth;
    }
}