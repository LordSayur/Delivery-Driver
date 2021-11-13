using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log(other.name + " picked up.");
        }

        if (other.tag == "Customer")
        {
            Debug.Log(other.name + " delivered.");
        }
    }
}
