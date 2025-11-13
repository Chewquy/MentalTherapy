using UnityEngine;
using UnityEngine.Tilemaps;

public class addictionHandler : MonoBehaviour
{
    public Tilemap water;
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
        SuicideHandler.vanquised[2]= true;
        if(collision.gameObject.tag == "HitboxTher")
        {
            water.color = new Color(1, 1, 1, 1);
            Debug.Log("Entered Collision Hitbox");
            gameObject.SetActive(false);
        }
    }
}