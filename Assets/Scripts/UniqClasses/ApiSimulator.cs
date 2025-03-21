using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ApiSimulator : MonoBehaviour
{
    public void Start()
    {
        FetchData();
    }
    public async void FetchData()
    {
        await Task.Delay(500); 
        Debug.Log("Data fetched from API simulator");
    }
}
