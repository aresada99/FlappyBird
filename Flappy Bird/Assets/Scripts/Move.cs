using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;



    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <-1.2)
        {
            Destroy(gameObject);

        }
        
    }




}
