using UnityEngine;

public class Mover : MonoBehaviour
{
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0f;
        float z = Input.GetAxis("Vertical");

    transform.Translate(x,y,z);
    }
}
