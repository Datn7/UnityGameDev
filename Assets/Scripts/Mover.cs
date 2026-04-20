using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
     MovePlayer();  
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome!");
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float y = 0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(x, y, z);
    }
}
