using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject popUpSet;// sub menu

    // Start is called before the first frame update
    void Start()
    {
        popUpSet.SetActive(false);
    }

    #region Popup

    public void OnClickSetting()
    {
        // sub menu
        if (popUpSet.activeSelf)
        {
            popUpSet.SetActive(false);
        }
        else
        {
            popUpSet.SetActive(true);
        }
    }

    public void OnClickPlaceRegister()
    {
        // sub menu
        if (popUpSet.activeSelf)
        {
            popUpSet.SetActive(false);
        }
        else
        {
            popUpSet.SetActive(true);
        }
    }

    #endregion
}
