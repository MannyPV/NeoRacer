using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float Smoothing = 0.3f;
    public float TurnSmoothing = 0.3f;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, Smoothing);
        transform.rotation = Quaternion.Slerp(transform.rotation,player.rotation,TurnSmoothing);
        transform.rotation = Quaternion.Euler(new Vector3(0,transform.rotation.eulerAngles.y, 0));
    }
}
