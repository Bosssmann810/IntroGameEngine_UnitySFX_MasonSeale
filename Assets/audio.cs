using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource Audio;
    private bool IsOn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Audio.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(IsOn == true)
        {
            Audio.Pause();
            IsOn = false;
            Debug.Log("its off now");
            return;
        }
        if(IsOn == false)
        {
            Audio.UnPause();
            IsOn = true;
            Debug.Log("its on now");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
