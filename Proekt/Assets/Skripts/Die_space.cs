
using UnityEngine;

public class Die_space : MonoBehaviour
{
    public GameObject Respawn;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = Respawn.transform.position;
        }
    }
    
}
