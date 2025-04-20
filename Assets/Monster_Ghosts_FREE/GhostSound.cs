using UnityEngine;

public class GhostSound : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float triggerDistance = 5f;
    [SerializeField] private AudioClip ghostSound;
    [SerializeField] private bool loopSound = false;

    private AudioSource audioSource;
    private bool hasPlayed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = ghostSound;
        audioSource.loop = loopSound;

        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;  // Find player by tag
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerTransform == null || ghostSound == null) return;

        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (distance <= triggerDistance)
        {
            if (!audioSource.isPlaying && !hasPlayed)
            {
                audioSource.Play();
                hasPlayed = !loopSound; // only block replay if not looping
            }
        }
        else
        {
            if (!loopSound)
            {
                hasPlayed = false; // allow it to play again if the player moves out and back in
            }
        }
    }
}
