using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log(other.name + " picked up.");
            hasPackage = true;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log(other.name + " delivered.");
            hasPackage = false;
        }
    }
}