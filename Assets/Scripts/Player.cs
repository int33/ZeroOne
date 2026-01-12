using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerBullet PlayerBullet;

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, vertical) * Time.deltaTime);
        
        if(Input.GetMouseButtonDown(0))
        {
            var playerBullet = Instantiate(PlayerBullet);
            playerBullet.transform.position = transform.position;
            playerBullet.Direction = Vector2.right;
            playerBullet.gameObject.SetActive(true);
        }
    }
}
