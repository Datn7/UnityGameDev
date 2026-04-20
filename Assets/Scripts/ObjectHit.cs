using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        GetComponent<MeshRenderer>().material.color = Color.white;

        Debug.Log("Someething Hit ME!");
    }
}
