using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    [SerializeField]
    private Ball ball;

    [SerializeField]
    private Text PlayerScoreTxt;

    [SerializeField]
    private Text ComputerScoreTxt;
    public void PlayerScored() {
        _playerScore++;
        PlayerScoreTxt.text = _playerScore.ToString();
        ball.ResetBallPoz();
    }
    public void ComputerScored() {
        _computerScore++;
        ComputerScoreTxt.text = _computerScore.ToString();
        ball.ResetBallPoz();
    }

}
