using UnityEngine;
using UnityEngine.InputSystem;

public class Dog : MonoBehaviour
{
    Vector2 pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + (Time.deltaTime * pos * 5);
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        pos = input;
    }
}
