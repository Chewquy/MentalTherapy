using UnityEngine;

public class IntroPunch : MonoBehaviour
{
     public GameObject hitboxAttack;
    float counter = 0;
    bool hitbox = false;
    public void Update()
    {
        if (hitbox)
        {
            counter += Time.deltaTime;
        }
        if(counter > 1)
        {
            hitboxAttack.SetActive(false);
            hitbox = false;
            counter = 0;
        }
    }
    public void Attack()
    {
        hitboxAttack.SetActive(true);
        hitbox = true;
        Attacks.menuActive = false;
        Mouvement.canMove = true;
    }
}
