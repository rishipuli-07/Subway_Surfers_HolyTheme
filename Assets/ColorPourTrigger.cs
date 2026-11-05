using UnityEngine;

public class ColorPourTrigger : MonoBehaviour
{
    [Header("Assign the Particle System here")]
    public ParticleSystem holiPourEffect;

    private void Start()
    {
        // Ensure it doesn't play before the player gets there
        if (holiPourEffect != null)
        {
            holiPourEffect.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks if the object passing through is the player
        if (other.CompareTag("Player"))
        {
            if (holiPourEffect != null && !holiPourEffect.isPlaying)
            {
                holiPourEffect.Play();
            }
        }
    }
}