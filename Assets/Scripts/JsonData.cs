using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonData : MonoBehaviour
{
    public static JsonData instance;
    public List<Materi1JsonData> pembahasanJsonData = new List<Materi1JsonData>();

    public void AddData(Materi1JsonData _pembahasanJsonData)
    {
        pembahasanJsonData.Clear();
        pembahasanJsonData.Add(_pembahasanJsonData);
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
