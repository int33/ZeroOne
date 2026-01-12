using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public static GameUI Default;

    public GameObject GamePass;
    public GameObject GameOver;
    
    private void Awake()
    {
        Default = this;
    }
    
    private void OnDestroy()
    {
        Default = null;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GamePass.transform.Find("BtnRestart").GetComponent<Button>()
        .onClick.AddListener(()=>{
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1;
        }); 

        GameOver.transform.Find("BtnRestart").GetComponent<Button>()
        .onClick.AddListener(()=>{
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1;
        }); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
