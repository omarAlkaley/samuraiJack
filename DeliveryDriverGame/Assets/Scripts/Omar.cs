using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omar : MonoBehaviour
{
    [SerializeField] string smartness ="Something" ;
    [SerializeField] string happiness;
    [SerializeField] bool excited;
    [SerializeField] float hairsHeadCount;
    private void Start()
    {
        if (smartness == "Smart") GoToWork();
    }
    void GoToWork()
    {
        Debug.Log("Mrs Mariam is washing her her!");
        Debug.Log("Wearing neat clothes");
        Debug.Log("Go out to drive her car");
        Debug.Log("Mrs Mariam is ready to go now!");
    }
}
