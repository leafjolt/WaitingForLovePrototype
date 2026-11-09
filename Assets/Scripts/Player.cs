using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 pos;
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

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
