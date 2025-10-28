using UnityEngine;

public class moreaudio : MonoBehaviour
{
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        Debug.Log("audio played");
    }
}