using UnityEngine;

public class freezeAxisXZ : MonoBehaviour
{
    [SerializeField] bool Axis = true;
    private void LateUpdate()
    {
        if (Axis)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
