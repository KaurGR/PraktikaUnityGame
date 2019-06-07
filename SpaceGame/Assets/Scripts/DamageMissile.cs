using UnityEngine;

public class DamageMissile : MonoBehaviour
{
    public int health = 10;

    int correctLayer;

    SpriteRenderer spriteRend;

    void Start()
    {
        correctLayer = gameObject.layer;

        spriteRend = GetComponent<SpriteRenderer>();

        if (spriteRend == null)
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

            if (spriteRend == null)
            {
                Debug.LogError("Object '" + gameObject.name + "' has no sprite renderer.");
            }
        }
    }

    void OnTriggerEnter2D(Collider hit)
    {
        health--;

        if (hit.CompareTag("Player"))
        {
            Destroy(GameObject.FindWithTag("Player"));
        }
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);        
    }
}
