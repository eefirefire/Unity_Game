using UnityEngine;

public class Script : MonoBehaviour
{
    
    public SpriteRenderer SR1;
    public Sprite defaultImage;
    public Sprite pressedImage; 

    public KeyCode KeyToPress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SR1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress))
        {
            Debug.Log("pressed button");
            SR1.sprite = pressedImage;
        }
        if(Input.GetKeyUp(KeyToPress))
        {
            SR1.sprite = defaultImage;
        }
    }
}
