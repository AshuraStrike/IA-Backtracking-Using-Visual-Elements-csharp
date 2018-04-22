using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Backtracking_Using_Visual_Elements.Class
{
    public class Node
    {
        public Node father;
        public int posX;
        public int posY;
        public int numberOfChilds;
        public bool isOpen;

        public List<Node> childList;
        public List<int> visitList;

        public Node(Node father, int posX, int posY, int numberOfChilds, int currentStep)
        {
            visitList = new List<int>();
            visitList.Add(currentStep);

            childList = new List<Node>();

            this.father = father;
            this.posX = posX;
            this.posY = posY;
            this.numberOfChilds = numberOfChilds;

            isOpen = true;
        }
    }

    public class Tree
    {
        Node root;
        List<Class.Move> moveList = new List<Move>();

        public Tree(List<Class.Move> moveList)
        {
            this.moveList = moveList;
        }


        private void generateTree()
        {
            for(int i = 0; i < moveList.Count; i++)
            {
                if (i == 0)
                {
                    Node newNode = new Node(null, moveList[i].coordX, moveList[i].coordY, moveList[i].childNumber, moveList[i].currentStep);
                    root = newNode;
                }
                else
                {
                    Node father = search(moveList[i-1].coordX, moveList[i-1].coordY);
                    Node newNode = new Node(father, moveList[i].coordX, moveList[i].coordY, moveList[i].childNumber, moveList[i].currentStep);

                    father.childList.Add(newNode);
                }
            }
        }

        public Node search(int x, int y)
        {
            return searchInTree(root, x, y);
        }

        public Node searchInTree(Node currentNode, int x, int y)
        {
            Node father;

            if(currentNode.posX == x && currentNode.posY == y)
            {
                return currentNode;
            }
            
            foreach(Node node in currentNode.childList)
            {
                father = searchInTree(node, x, y);
                if(father != null)
                {
                    return father;
                }
            }

            return null;
        }
    }
}
