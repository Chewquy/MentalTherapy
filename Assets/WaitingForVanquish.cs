using UnityEngine;

public class WaitingForVanquish : MonoBehaviour
{
    public GameObject boss;
    public GameObject dog;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SuicideHandler.vanquised[0] && SuicideHandler.vanquised[1] &&SuicideHandler.vanquised[2] && !SuicideHandler.yay)
        {
            boss.SetActive(true);
            dog.SetActive(false);
        }
    }
}
