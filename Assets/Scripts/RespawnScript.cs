using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public Transform respawnPoint; // De respawn positie (0, 0.5, 0) moet hieraan worden toegewezen.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Border"))
        {
            // Controleer of de speler de grens raakt.
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        // Zet de positie van de speler terug naar het respawn-punt.
        transform.position = respawnPoint.position;
    }
}