using UnityEngine;

public class BlameHandler : MonoBehaviour
{
    public GameObject[] goodSprite;
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
        if(collision.gameObject.tag == "HitboxIntro")
        {
            foreach(GameObject obj in goodSprite)
            {
                obj.SetActive(true);
            }
            SuicideHandler.vanquised[1]= true;
            Debug.Log("Entered Collision Hitbox");
            gameObject.SetActive(false);
            Mouvement.canMove = true;
        }
    }
}