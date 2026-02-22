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
        dir = dir.normalized;//fem que el vector direcció valgui 1 això s'anomena el modul del vector, i ens permet multiplicar per una velocitat després i així fer que es mogui sempre igual.
        //actualitzem la posició del objecte afectat
        transform.position = transform.position + dir * Velocity *Time.deltaTime;
        //time.deltateime es el temps entre fotogrames, multiplicar per aquest  factor ens permet que doni igual el framerate, sempre trigui el mateix
    }
}
