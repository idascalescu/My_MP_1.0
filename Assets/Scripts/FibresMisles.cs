
using UnityEngine;

public class FibresMisles : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    public float speed = 69.0f;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {
        if (target == null) 
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distToFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distToFrame) 
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distToFrame, Space.World);
    }

    void HitTarget()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("IMPACT -10");  
        }
    }
}
