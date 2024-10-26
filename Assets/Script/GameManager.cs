using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource Audio;
    public bool start;
    public ArrowScroll Sc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start != true && Input.anyKey){
            start = true;
            Sc.IsStart = true;
            Audio.Play();
        }
    }
}
