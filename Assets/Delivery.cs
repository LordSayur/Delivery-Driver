using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] 
    Color32 withPackageColor = new Color32(1, 1, 1, 1);
    Color32 noPackageColor = new Color32(1, 1, 1, 1);
    
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        noPackageColor = spriteRenderer.color;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log(other.name + " picked up.");
            hasPackage = true;
            spriteRenderer.color = withPackageColor;
            Destroy(other.gameObject);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log(other.name + " delivered.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
