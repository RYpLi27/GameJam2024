using UnityEngine;

public class SpriteLookPlane : MonoBehaviour
{
    public Transform targetTransform;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        _transform.LookAt(targetTransform);
    }
}
