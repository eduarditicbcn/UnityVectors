using UnityEngine;

public class GoToPlace : MonoBehaviour
{
    public Transform TargetPos;
    public float Velocity = 4f;
    void Update()
    {
        //Primer calculem la direcció
        //la direcció es el lloc al que volem anar - la nostra posició actual
        Vector3 dir = TargetPos.position - transform.position;
        //actualitzem la posició del objecte afectat
        transform.position = transform.position + dir * Velocity *Time.deltaTime;
        //time.deltateime es el temps entre fotogrames, multiplicar per aquest  factor ens permet que doni igual el framerate, sempre trigui el mateix
    }
}
