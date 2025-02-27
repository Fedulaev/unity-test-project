using UnityEngine;

public class ChangePlatform : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    public void SwitchToPc()
    {
        ChangeState(false);
    }
    public void SwitchToMobile()
    {
        ChangeState(true);
    }
    private void ChangeState(bool _scriptState)
    {
        if (_player.GetComponent<JoystickMovement>() != null
            && _player.GetComponent<GyroscopeMovement>() != null)
        {
            _player.GetComponent<JoystickMovement>().enabled = _scriptState;
            _player.GetComponent<GyroscopeMovement>().enabled = _scriptState;
        }
        else
            Debug.Log("Script is missing");
    }
}
