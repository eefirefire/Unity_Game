using UnityEngine;

public class bottom : MonoBehaviour
{
    public SpriteRenderer SR1;
    public Sprite DefaultImage;
    public Sprite PressedImage;

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
            Debug.Log("you pressed a key");
            SR1.sprite = PressedImage;
        }
        if (Input.GetKeyUp(KeyToPress))
        {
            Debug.Log("you UNpressed a key");
            SR1.sprite = DefaultImage;
        }
    }
}
