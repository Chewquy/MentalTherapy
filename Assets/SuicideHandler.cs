using UnityEngine;
using UnityEngine.Tilemaps;

public class SuicideHandler : MonoBehaviour
{
    public static bool[] vanquised = new bool[3];
    public Tilemap[] island;

     bool[] toBeVanquised = new bool[3];

     public static bool yay = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(toBeVanquised[0] && toBeVanquised[1] && toBeVanquised[2])
        {
            yay = true;
            island[0].color = new Color(1, 1, 1, 1);
            island[1].color = new Color(1, 1, 1, 1);
            island[2].gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Collision");
        if(collision.gameObject.tag == "HitboxLove")
        {
            toBeVanquised[0] = true;
        }
        if(collision.gameObject.tag == "HitboxIntro")
        {
            toBeVanquised[1] = true;
        }
        if(collision.gameObject.tag == "HitboxTher")
        {
            toBeVanquised[2] = true;
        }
    }
}
