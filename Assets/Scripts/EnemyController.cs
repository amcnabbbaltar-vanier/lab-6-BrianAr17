using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem system;
    private AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        system = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    public void GotHit()
    {
        animator.ResetTrigger("GotHit");
        animator.SetTrigger("GotHit");
        system.Play();
        audioSource.Play();

        if(GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1);
        }

    }
}
