using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform transformPosition;
    public float fireRate = 1.0f;

    private float _nextFireTime = 0.0f;

    private Vector3 _shootPositionl;
    private Vector3 _hitPosition;

    private void Awake()
    {
        if (transformPosition == null)
        {
            transformPosition = GetComponent<Transform>();
        }
    }

     void Update()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            shoot();
            //Debug.Log("Fire");
        }
    }

    private void shoot()
    {
        if (Time.timeSinceLevelLoad < _nextFireTime)
        {
            return;
        }
        if (Physics.Raycast(transformPosition.position, transformPosition.forward, out RaycastHit hitInfo))
        {
             Debug.Log(hitInfo.collider);
            _shootPositionl = transformPosition.position;
            //_hitPosition = hitInfo.collider.transform.position;
            _hitPosition = hitInfo.point;
        }

        _nextFireTime = Time.timeSinceLevelLoad + 1.0f / fireRate;
    }

    private void OnDrawGizmosSelected()
    {
        if (transformPosition == null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transformPosition.position, transformPosition.forward);

        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(_hitPosition, _shootPositionl);
    }

}
