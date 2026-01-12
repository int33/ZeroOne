using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player Player;

    public EnemyBullet EnemyBullet;
    
    public enum States
    {
        FollowPlayer,
        Shoot,
    }

    public States State = States.FollowPlayer;

    //敌人跟随一定时间后再射击
    public float FollowPlayerSeconds = 3.0f;

    public float CurrentSeconds = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;//改为60帧每秒
    }

    // Update is called once per frame
    void Update()
    {
        if(State == States.FollowPlayer)
        {
            if(CurrentSeconds >= FollowPlayerSeconds)
            {
                State = States.Shoot;
                CurrentSeconds = 0f;
            }

            var directionToPlayer = (Player.transform.position - transform.position).normalized;
            
            transform.Translate(directionToPlayer * Time.deltaTime);    

             CurrentSeconds += Time.deltaTime;
        }
        else if(State == States.Shoot)
        {
            CurrentSeconds += Time.deltaTime;
            if(CurrentSeconds>=1.0f)
            {
                State = States.FollowPlayer;
                FollowPlayerSeconds = Random.Range(2,4f);
                CurrentSeconds = 0f;
            }

            if(Time.frameCount % 20 == 0)
            {
                var directionToPlayer = (Player.transform.position - transform.position).normalized;
            
                var enemyBullet = Instantiate(EnemyBullet);
                enemyBullet.transform.position = transform.position;
                enemyBullet.Direction = directionToPlayer;
                enemyBullet.gameObject.SetActive(true);
            
            }
        }
    }
}
