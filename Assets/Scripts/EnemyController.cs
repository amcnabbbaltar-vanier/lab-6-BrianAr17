using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private EnemyHealth enemyHealth;
    private Animator animator;
    private ParticleSystem system;
    private AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        system = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    public void GotHit()
    {
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(10);
            animator.SetTrigger("GotHit");
            system.Play();
            audioSource.Play();
        }
    }
}
