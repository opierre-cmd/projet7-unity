using UnityEngine;

public class Collectible : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);  
    }
}

public class Float : MonoBehaviour
{
    public float speed = 1.5f;
    public float height = 0.5f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }


}