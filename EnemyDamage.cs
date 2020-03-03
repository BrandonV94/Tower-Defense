using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int enemyHitPoints = 5;
    [SerializeField] ParticleSystem hitPartclePrefab = null;
    [SerializeField] ParticleSystem deathParticlePrefab = null;

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPartclePrefab.Play();
        enemyHitPoints--;
        if (enemyHitPoints <= 0)
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        var deathVFX = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
        deathVFX.Play();
        Destroy(gameObject);
    }
}
