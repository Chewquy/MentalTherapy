using UnityEngine;

public class Attacks : MonoBehaviour
{
    public GameObject menue;

    public static bool  menuActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(!menuActive)
            {
                Mouvement.canMove = false;
                menuActive = true;
            }
            else
            {
                Mouvement.canMove = true;
                menuActive = false;
            }
        }

        
                menue.SetActive(menuActive);
        
    }
}
