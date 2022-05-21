
using UnityEngine;

public class Smert : MonoBehaviour
{
    public GameObject Tp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = Tp.transform.position;
        }
    }

}
