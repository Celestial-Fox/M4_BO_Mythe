using UnityEngine;

public class setworldbounds : MonoBehaviour
{
    private void Awake()
    {
        Bounds spriteBounds = GetComponent<SpriteRenderer>().bounds;

        // Zet globale waarde
        globals.worldbounds = new Bounds(spriteBounds.center, spriteBounds.size);
    }
}
