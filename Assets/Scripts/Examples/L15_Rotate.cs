using UnityEngine;

public class L15_Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed;
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
