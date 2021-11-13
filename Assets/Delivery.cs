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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = withPackageColor;
            Destroy(other.gameObject);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
