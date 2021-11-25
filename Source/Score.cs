using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    void FixedUpdate()
    {
        score.text = (int.Parse(score.text) + 1).ToString();
    }
}
