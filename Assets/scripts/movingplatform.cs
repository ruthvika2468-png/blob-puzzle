using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 3f;
    public float speed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * speed) * distance;

        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}