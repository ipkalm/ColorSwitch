using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("BGM");
        if(objects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
