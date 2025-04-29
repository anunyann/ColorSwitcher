using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 0, -10); 

    void Update()
    {
        if (player != null)
        {
            Vector3 newPos = player.position + offset;
            transform.position = new Vector3(newPos.x, offset.y, newPos.z); 
        }
    }
}