using UnityEngine;

public class DeletePrefs : MonoBehaviour
{
    [ContextMenu("Delete Prefs")]
    void DoDeletePrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}