using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class JsonDownloader : MonoBehaviour
{
    public JsonData jsonData;
    private string jsonDataFileName = "PembahasanData";

    public IEnumerator LoadJsonData(string _fileName)
    {
        string path = Application.streamingAssetsPath;
        string fullPath = PathCorrection(path, _fileName);
        Debug.Log("FullPath: " + fullPath);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error!");
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        Debug.Log(downloadedText);

        Materi1JsonData pembahasanData = TryParseJsonData(downloadedText);
        this.jsonData.AddData(pembahasanData);
    }

    private string PathCorrection(string _fullPath, string _fileName)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _fullPath = System.IO.Path.Combine(_fullPath, _fileName + ".json");
            Debug.Log("Run in Android");
        }
        else
        {
            Debug.Log("Run in Editor");
            _fullPath = System.IO.Path.Combine("file:///" + _fullPath, _fileName + ".json");
        }

        return _fullPath;
    }

    private Materi1JsonData TryParseJsonData(string downloadedText)
    {
        Materi1JsonData data = JsonUtility.FromJson<Materi1JsonData>(downloadedText);
        return data;
    }

    private IEnumerator LoadDataAtStart()
    {
        yield return StartCoroutine(LoadJsonData(jsonDataFileName));
    }

    private IEnumerator Loader()
    {
        yield return StartCoroutine(LoadDataAtStart());
        yield return StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.MENU));
    }

    private void Start()
    {
        StartCoroutine(Loader());
    }
}

[System.Serializable]
public class Materi1JsonData
{
    public string[] PEMBAHASAN1_1;
    public string[] PEMBAHASAN1_2;
    public string[] PEMBAHASAN1_3;
    public string[] PEMBAHASAN1_4;
    public string[] JAWABAN_1_1;
    public string[] JAWABAN_1_2;
    public string[] JAWABAN_1_3;
    public string[] JAWABAN_1_4;
    public string[] PEMBAHASAN2_2;
    public string[] PEMBAHASAN2_3;
    public string[] JAWABAN_2_2;
    public string[] JAWABAN_2_3;
    public string[] PEMBAHASAN3_2;
    public string[] PEMBAHASAN3_3;
    public string[] JAWABAN_3_2;
    public string[] JAWABAN_3_3;
    public string[] PEMBAHASAN4_2;
    public string[] PEMBAHASAN4_3;
    public string[] JAWABAN_4_2;
    public string[] JAWABAN_4_3;
    public string[] ASOSIASI_1_PEMBAHASAN;
    public string[] ASOSIASI_2_PEMBAHASAN;
    public string[] ASOSIASI_3_PEMBAHASAN;
    public string[] ASOSIASI_4_PEMBAHASAN;
    public string[] ASOSIASI_1;
    public string[] ASOSIASI_2;
    public string[] ASOSIASI_3;
    public string[] ASOSIASI_4;

}