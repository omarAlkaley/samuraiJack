using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] string carName = "Shawqy";
    [SerializeField] string carType = "Toyota";
    [SerializeField] bool isTheCarHappy = true;
    [SerializeField] Color carColor = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        IdentifyTheCar(carName, carType, isTheCarHappy, carColor);
    }
    void SayILoveU()
    {
        Debug.Log("I love you ya agmad game designer");
    }
    void MakeTea()
    {
        Debug.Log("Here, take some tea, please!");
    }
    void IdentifyTheCar( string name, string type,bool isHappy, Color color)
    {
        Debug.Log("My name is: " + name + "\n" + "My type is: " + type + "\n" + "Am I happy? .. " + isHappy + "\n" + "My Color is: " + color);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
