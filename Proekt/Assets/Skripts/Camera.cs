using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour

{
    [SerializeField] private Transform player;
    private Vector3 pos;



    private void Awake()
    {
        if (!player)
            player = FindObjectOfType<Hero>().transform;
    }

    private void Update()
    {
        if (!player)
            return;
        pos = player.position;
        pos.z = -10F;
        pos.y += 2.5f;

        // изменение плавности камеры 
       // transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, pos, 3* Time.deltaTime);
    }
}
