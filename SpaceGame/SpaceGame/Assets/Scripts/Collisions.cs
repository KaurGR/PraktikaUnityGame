using UnityEngine;

public class Collisions : MonoBehaviour
{ 
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");

        if (col.gameObject.name=="EnemyMissile")
        {
            Destroy(col.gameObject);
        }
    }
    private void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");
    }

}
