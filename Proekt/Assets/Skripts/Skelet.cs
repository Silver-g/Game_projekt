using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Gocha : Entity
{ 
    
    private SpriteRenderer sprite;
[SerializeField] private AIPath aiPath;
// Update is called once per frame
private void Awake()
{
    sprite = GetComponentInChildren<SpriteRenderer>();
        
        lives = 2;
}
    private void Update()
    {
        sprite.flipX = aiPath.desiredVelocity.x <= 0.01f;
    }
}
