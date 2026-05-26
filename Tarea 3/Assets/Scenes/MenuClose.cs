using UnityEngine;

public class MenuClose : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.SetActive(false);
        }
    }
}