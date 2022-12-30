using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    public GameManager GameManager;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
