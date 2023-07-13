using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    private bool _isPaused = false;

    [SerializeField]
    private Ball ball;

    [SerializeField]
    private Text PlayerScoreTxt;

    [SerializeField]
    private Text ComputerScoreTxt;

    [SerializeField]
    Paddle PlayerPaddle;
    
    [SerializeField]
    Paddle ComputerPaddle;

    [SerializeField]
    Text PauseText;

    private void Awake()
    {
        PauseText.enabled = false;
    }

    private void Update()
    {
        Pause();
    }
    public void PlayerScored() {
        _playerScore++;
        PlayerScoreTxt.text = _playerScore.ToString();
        InitGameParameters();
    }
    public void ComputerScored() {
        _computerScore++;
        ComputerScoreTxt.text = _computerScore.ToString();
        InitGameParameters();
    }

    private void InitGameParameters()
    {
        ball.ResetBallPoz();
        ball.AddStartingForce();
        PlayerPaddle.ResetPoz();
        ComputerPaddle.ResetPoz();
    }

    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isPaused == false)
        {
            PauseText.enabled = true;
            Time.timeScale = 0.0f;
            _isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _isPaused == true)
        {
            Time.timeScale = 1.0f;
            PauseText.enabled = false;
            _isPaused = false;
        }

        if (_isPaused == true && Input.GetKeyDown(KeyCode.Q))
        {
            _isPaused = false;
            Time.timeScale = 1.0f;

            if (_playerScore > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", _playerScore);
            }
            SceneManager.LoadScene(0);

        }
    }
}
