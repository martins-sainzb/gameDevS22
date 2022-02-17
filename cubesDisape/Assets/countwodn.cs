using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countwodn : MonoBehaviour
{
    public float count = 16;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<TMPro.TextMeshProUGUI>().text = count.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count -= Time.deltaTime;

            GetComponent<TMPro.TextMeshProUGUI>().text = count.ToString();
        }
        else if (GameData.Score < 800)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "You lose!!!";
        }
        else if (GameData.Score < 900)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "C-";
        }
        else if (GameData.Score < 1000)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "C";
        }
        else if (GameData.Score < 1100)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "C+";
        }
        else if (GameData.Score < 1200)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "B-";
        }
        else if (GameData.Score < 1300)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "B";
        }
        else if (GameData.Score < 1400)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "B+";
        }
        else if (GameData.Score < 1500)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "A-";
        }
        else if (GameData.Score < 1600)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "A";
        }
        else
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "A+!!";
        }
    }
}
