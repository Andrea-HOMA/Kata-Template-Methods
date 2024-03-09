using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    [SerializeField] private GameObject _firefighter;
    [SerializeField] private GameObject _doctor;
    [SerializeField] private GameObject _teacher;
    [SerializeField] private GameObject _shopAssistant;
    [SerializeField] private Transform _spawnPosition;
    
    public void OnClick()
    {
        var random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                Instantiate(_firefighter, _spawnPosition.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(_doctor, _spawnPosition.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(_teacher, _spawnPosition.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(_shopAssistant, _spawnPosition.position, Quaternion.identity);
                break;
        }
    }
}
