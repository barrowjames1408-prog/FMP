using UnityEngine;

public class SnakeSoundEffect : MonoBehaviour
{
    public AudioSource SnakeSounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void playhiss()
    {
        SnakeSounds.Play();
    }
    public void stophiss() 
    {
        SnakeSounds.Stop();   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
