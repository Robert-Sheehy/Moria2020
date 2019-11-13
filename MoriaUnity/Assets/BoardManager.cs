using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int boardRows, boardColumns;
    public int minRoomSize, maxRoomSize;

    public class SubDungeon
    {
        public SubDungeon left, right;
        public Rect rect ;
        public Rect room = new Rect(-1, -1, 0, 0);
        public int debugId;

        private static int debugCounter = 0;

        public SubDungeon(Rect mrect)
        {
            rect = mrect;
            debugId = debugCounter;
            debugCounter++;
        }

        public bool IAmLeaf ()
        {
            return left == null && right == null;
        }

        public bool split(int minRoomSize, int maxRoomSize)
        {
            if(!IAmLeaf())
            {
                return false;
            }
        

        bool splitH;
            if (rect.width / rect.height >= 1.25) {
                splitH = false;
            }
            else if (rect.height / rect.width >= 1.25)
            {
                splitH = true;
            }
            else
            {
                splitH = Random.Range(0.0f, 1.0f) > 0.5;
            }

            if(Mathf.Min(rect.height, rect.width) / 2 < minRoomSize)
            {
                Debug.Log("Sub-dungeon" + debugId + " will be a leaf");
                return false;
            }

            if (splitH)
            {
                int split = Random.Ramge(minRoomSize, (int)(rect.width - minRoomSize));

                left = new SubDungeon(new Rect(rect.x, rect.y, rect.width, split));
                right = new SubDungeon(new Rect(rect.x, rect.y, rect.height, split));

            }
            else
            {
                int split = Random.Range(minRoomSize, (int)(rect.height - minRoomSize));

            }
            }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
