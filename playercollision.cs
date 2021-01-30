using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playerovement movement;
   
    void OnCollisionEnter (Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "obsticle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
        
   
}