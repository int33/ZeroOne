using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public Vector2 Direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name=="Enemy")
        {
            GameUI.Default.GamePass.SetActive(true);
            other.gameObject.SetActive(false); 
            Time.timeScale = 0;
        }
    }
}
