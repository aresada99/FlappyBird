using UnityEngine;

public class BirdScript : MonoBehaviour
{


    public float velocity = 3f;
    public Rigidbody2D rb2d;
    public GameManager gm;
    public GameObject DeathScreen;

    public bool isDead;

   
    void Start()
    {
        DeathScreen.SetActive(false);
        

    }

   
    void Update()
    {   
        
       if(Input.GetMouseButtonDown(0))
        {

            rb2d.velocity = Vector2.up * velocity;
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Obstacle")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
       

        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {

            gm.updateScore(); 
        }
    }

}
