using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    public float leftLimit = -10f;
    public float resetPosition = 20f;

    void Update()
{
    transform.position += Vector3.left * GameManager.gameSpeed * Time.deltaTime;

    if (transform.position.x < leftLimit)
    {
        transform.position = new Vector3(resetPosition, transform.position.y, transform.position.z);
    }
}
}