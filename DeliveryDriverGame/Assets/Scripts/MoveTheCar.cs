using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheCar : MonoBehaviour
{
    [SerializeField]GameObject playerHouse;
    [SerializeField] GameObject[] homes;
    [SerializeField] GameObject awesomeTree;
    [SerializeField] GameObject myCar;
    [SerializeField] GameObject rock;

    // Start is called before the first frame update
    void Start()
    {
        playerHouse.GetComponent<SpriteRenderer>().color = Color.blue;
        foreach (var home in homes)
        {
            home.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerHouse.GetComponent<SpriteRenderer>().color = Color.green;
            awesomeTree.GetComponent<SpriteRenderer>().color = Color.red;
        }
        Vector3 vectorBetweenRockAndCar = rock.transform.position - myCar.transform.position;
        if(vectorBetweenRockAndCar.magnitude>5)
        myCar.transform.position = myCar.transform.position + vectorBetweenRockAndCar.normalized *Time.deltaTime*10;
    }
}
