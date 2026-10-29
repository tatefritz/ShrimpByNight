using UnityEngine;

public class WaterCapacity : MonoBehaviour
{
    private float maxWater = 100f;
    private float currentWater;
    private float leak = 5f;
    private float fill = 5f;


    private void Start()
    {
        currentWater = maxWater;
    }
    private void Update()
    {
        LoseWater();
    }
    public float GetCurrentWater
    {
        get { return currentWater; }
    }



    public void LoseWater()
    {
        currentWater -= leak * Time.deltaTime;
        Debug.Log("CurrentWater: " +  currentWater);
    }
    
    public void GainWater()
    {
        currentWater += fill * Time.deltaTime;
    }
}
