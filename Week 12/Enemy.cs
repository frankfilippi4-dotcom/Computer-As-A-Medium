using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    private bool isDying;

    private void Update()
    {
        if (enemyHealth <= 0 && !isDying)
        {
            isDying = true;
            StartCoroutine(DeathSequence());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isDying && other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
    }

    private IEnumerator DeathSequence()
    {
        transform.localScale *= 0.5f;
        yield return new WaitForSeconds(0.75f);
        Destroy(gameObject);
    }
}
