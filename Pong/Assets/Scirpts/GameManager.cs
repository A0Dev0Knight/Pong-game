using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    [SerializeField]
    private Ball ball;
    public void PlayerScored() {
        _playerScore++;
        ball.ResetBallPoz();
        Debug.Log(_playerScore);
    }
    public void ComputerScored() {
        _computerScore++;
        ball.ResetBallPoz();
        Debug.Log(_computerScore);
    }

}
