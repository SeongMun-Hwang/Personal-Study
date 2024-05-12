using UnityEngine;

public class AudioDebug : MonoBehaviour
{
    public Transform listener;
    public AudioSource audioSource;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, listener.position);
        Debug.Log("Distance: " + distance + ", Volume: " + audioSource.volume);
    }
}
