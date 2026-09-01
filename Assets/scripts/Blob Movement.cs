using UnityEngine;
using UnityEngine.InputSystem;

public class BlobMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.forward * 5f * Time.deltaTime);
        }

    }
}
