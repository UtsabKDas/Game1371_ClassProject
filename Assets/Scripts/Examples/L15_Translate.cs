using UnityEngine;

public class L15_Translate : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed;
        transform.Translate(Vector3.forward * step);
    }
}
