using UnityEngine;

public class EnemyMissileShoot : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

    public GameObject bulletPrefab;
    int bulletLayer;

    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;

    public int HP = 100;
    public int ShootHP = 60;
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    void Start()
    {/*
        bulletLayer = gameObject.layer;
        spriteRend = GetComponent<SpriteRenderer>();

        if (spriteRend == null)
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

            if (spriteRend == null)
            {
                Debug.LogError("Object '" + gameObject.name + "' has no sprite renderer.");
            }
        }
     */
    }

    void OnTriggerEnter2D()
    {
        HP--;


        if (invulnPeriod > 0)
        {
            invulnTimer = invulnPeriod;
            gameObject.layer = 10;
        }
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("yes1");

        cooldownTimer -= Time.deltaTime;

        invulnTimer -= Time.deltaTime;

        if (HP <= ShootHP)
        {

            if (cooldownTimer <= 0)
            {
                Debug.Log("SHOOT THE MISSILE!!!");
                // SHOOT!
                cooldownTimer = fireDelay;

                Vector3 offset = transform.rotation * bulletOffset;

                GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
                bulletGO.layer = bulletLayer;
            }
        }

    }
}
