using UnityEngine;

public class EndToTheGame : MonoBehaviour
{
    [SerializeField] private ButtonEvents buttonEvents;
    private int _numberOfTrueCubes;
    private int _numberOfCubes;

    private GameObject[] _greenPositions;
    private GameObject[] _redPositions;
    private GameObject[] _yellowPositions;
    private void Start()
    {
        _greenPositions = GameObject.FindGameObjectsWithTag("Green Cubes");
        _redPositions = GameObject.FindGameObjectsWithTag("Red Cubes");
        _yellowPositions = GameObject.FindGameObjectsWithTag("Yellow Cubes");
        _numberOfCubes = AssignTheNumberOfCubes();
        
        ColorMatchingCheck();
    }

    private void TestForVictory()
    {
        if (_numberOfTrueCubes == _numberOfCubes)
        {
            buttonEvents.GameOver();
        }
    }

    public void ColorMatchingCheck()
    {
        int count = 0;
        _numberOfTrueCubes = 0;
        for (int i = 0; i < _greenPositions.Length; i++)
        {
            count += _greenPositions[i].GetComponent<CheckingPositionCube>().correctPosition;
        }
        _numberOfTrueCubes += count;
        count = 0;
        for (int i = 0; i < _redPositions.Length; i++)
        {
            count += _redPositions[i].GetComponent<CheckingPositionCube>().correctPosition;
        }
        _numberOfTrueCubes += count;
        count = 0;
        for (int i = 0; i < _yellowPositions.Length; i++)
        {
            count += _yellowPositions[i].GetComponent<CheckingPositionCube>().correctPosition;
        }
        _numberOfTrueCubes += count;
        
        TestForVictory();
    }
    
    private int AssignTheNumberOfCubes()
    {
        int count = 0;
        count += GameObject.FindGameObjectsWithTag("Green Cubes").Length;
        count += GameObject.FindGameObjectsWithTag("Red Cubes").Length;
        count += GameObject.FindGameObjectsWithTag("Yellow Cubes").Length;
        return count;
    }
}
