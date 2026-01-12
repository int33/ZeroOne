using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Player player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cameraPosition = player.transform.position + Vector3.up * 0.5f;
        cameraPosition.z = -10;//与player的z值一样的话找不到主角

        transform.position = cameraPosition;
    }
}
