using UnityEngine;
public class HealthPack : MonoBehaviour
{ private void OnTriggerEnter2D(Collider2D other)
    { PlayerHealth player = other.GetComponentInParent<PlayerHealth>();
        if (player != null)
        { player.health = Mathf.Min(player.health + 10, 100);
            Destroy(gameObject);
}
    }
}
