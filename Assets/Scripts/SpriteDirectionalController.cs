using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class SpriteDirectionalController : MonoBehaviour
{
    [SerializeField] float backAngle = 65.0f;
    [SerializeField] float sideAngle = 155.0f;
    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    private void LateUpdate()
    {
        Vector3 _camVector = new Vector3(Camera.main.transform.forward.x, 0.0f, Camera.main.transform.forward.z);
        Debug.DrawRay(Camera.main.transform.position, _camVector * 5.0f, Color.magenta);

        float signedAngle = Vector3.SignedAngle(mainTransform.forward, _camVector, Vector3.up);

        Vector2 animationDirection = new Vector2(0.0f, -1.0f);

        float angle = Mathf.Abs(signedAngle);

        //this is side of animation for sprite
        //if (signedAngle < 0.0f)
        //{
        //    spriteRenderer.flipX = true;
        //}
        //else
        //{
        //    spriteRenderer.flipX = false;
        //}

        if (angle < backAngle)
        {
                //back animation
            animationDirection = new Vector2(0.0f, -1.0f);
        } 
        else if (angle < sideAngle) 
        {
                //side animation (right)
                animationDirection = new Vector2(1.0f, 0.0f);
            //this is side of animation for sprite
            if (signedAngle < 0.0f)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        } 
        else 
            {
                //front animation
                animationDirection = new Vector2(0.0f, 1.0f);
            }

        animator.SetFloat("FX", animationDirection.x);
        animator.SetFloat("FY", animationDirection.y);
    }
}
