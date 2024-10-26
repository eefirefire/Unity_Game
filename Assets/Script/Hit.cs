using UnityEngine;

public class Hit : MonoBehaviour
{
    public bool PressRight;
    public KeyCode presskey;

    void Update(){
        if(PressRight == true && Input.GetKeyDown(presskey)){
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Button")){
                PressRight = true;

        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Button")){
            PressRight = false;
        }
    }

}
