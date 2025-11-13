using UnityEngine;

public class Mouvement : MonoBehaviour
{
    public GameObject dog;
    public float speed = 1;
    public static bool canMove = true;

    void Update()
    {
        if (canMove)

        {
            if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            dog.transform.position = transform.position - new Vector3(0, 1.5f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            dog.transform.position = transform.position + new Vector3(0, 1.5f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            dog.transform.position = transform.position - new Vector3(1.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            dog.transform.position = transform.position + new Vector3(1.5f, 0, 0);
        }
        }
    }
}
