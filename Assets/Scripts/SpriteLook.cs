using UnityEngine;

public class SpriteLook : MonoBehaviour
{
    [SerializeField] bool freezeXZAxis = true;
    // Update is called once per frame
    void Update()
    {
        if (freezeXZAxis)
        {
        transform.rotation = Quaternion.Euler(0.0f, Camera.main.transform.rotation.eulerAngles.y, 0.0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
