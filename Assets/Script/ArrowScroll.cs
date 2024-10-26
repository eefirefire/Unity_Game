using UnityEngine;

public class ArrowScroll : MonoBehaviour
{
    public int BeatTempo;
    public bool IsStart=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsStart == true){
            transform.position -= new Vector3(0, BeatTempo* Time.deltaTime,0);  
        }
    }
}
