using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void CambiarColor(Color nuevoColor)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = nuevoColor;
        }
    }
}