using UnityEngine;

public class LonelinessHandler : MonoBehaviour
{
    public GameObject badHouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Collision");
        if(collision.gameObject.tag == "HitboxLove")
        {
            SuicideHandler.vanquised[0]= true;
            badHouse.SetActive(false);
            Debug.Log("Entered Collision Hitbox");
            gameObject.SetActive(false);
        }
    }
}