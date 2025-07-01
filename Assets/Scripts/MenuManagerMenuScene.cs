using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MenuManagerMenuScene : MonoBehaviour
{

    public GameObject dataBoard;

    public TextMeshProUGUI totalShotText;
    public TextMeshProUGUI totalEnemyKilledText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayButton()
    {
        SceneManager.LoadScene(0);
    }

    public void DataBoardButton()
    {
        DataManager.Instance.LoadData();

        dataBoard.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Total Bullet Shot: "+ DataManager.Instance.totalShotBullet.ToString();
        dataBoard.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Total Enemy Killed: "+ DataManager.Instance.totalEnemyKilled.ToString();
        dataBoard.SetActive(true); 
    }


    public void XButton()
    {
        dataBoard.SetActive(false);
    }

}
