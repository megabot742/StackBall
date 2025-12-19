using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Vector3 camFollow;
    [SerializeField] Ball ball;
    [SerializeField] Transform Win;

    void Awake() 
    {
        ball = FindFirstObjectByType<Ball>();
        //ball = FindObjectOfType<Ball>().transform;
    }
    void Update()
    {
        //check camera
        if(Win == null)
        {
            Win = GameObject.Find("Win(Clone)").GetComponent<Transform>();
        }
        //move camera with ball
        if(transform.position.y > ball.transform.position.y && transform.position.y > Win.position.y + 4f)
            camFollow = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);
        
        transform.position = new Vector3(transform.position.x, camFollow.y, -5);
    }
}
