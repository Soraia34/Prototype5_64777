using Unity.VisualScripting;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 starPos;
    private float repeatWidth;
    void Start()
    {
        starPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        if(transform.position.x < starPos.x - repeatWidth)
        {
            transform.position = starPos;
        }
    }
}
