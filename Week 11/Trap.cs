using UnityEngine;

public class Trap : MonoBehaviour
{    // Player Trap affects player health and reveals enemy
  
    public PlayerHealth playerHealth;
    public GameObject objectToReveal;

   
    // Player touches trap 10 damage is taken new enemy is revealed 
    private void OnTriggerEnter2D(Collider2D other)
    { if(other.CompareTag("Player"))
        { playerHealth.health -= 10;
            objectToReveal.SetActive(true);
        }
    }
}
