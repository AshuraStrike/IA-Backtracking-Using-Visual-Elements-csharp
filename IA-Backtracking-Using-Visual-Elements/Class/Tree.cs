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
        public bool visited;

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
        }

        public bool isOpen()
        {
            bool founded = false;

            if (childList.Count < numberOfChilds)
            {
                founded = true;
            }
            else
            {
                for (int i = 0; i < childList.Count; i++)
                {
                    if (childList[i].visited == false)
                    {
                        founded = true;
                        break;
                    }
                }
            }

            return founded;
        }
    }

    public class Tree
    {
        public Node root;
        public List<Class.Move> moveList = new List<Move>();

        public Tree(List<Class.Move> moveList)
        {
            this.moveList = moveList;
        }


        public void generateTree()
        {
            for(int i = 0; i < moveList.Count; i++)
            {
                if (i == 0)
                {
                    Node newNode = new Node(null, moveList[i].coordX, moveList[i].coordY, moveList[i].childNumber, moveList[i].currentStep);
                    newNode.visited = true;
                    root = newNode;
                }
                else
                {
                    Node father = search(moveList[i-1].coordX, moveList[i-1].coordY);

                    //No se repitan nodos nuevos
                    Node newNode = search(moveList[i].coordX, moveList[i].coordY);

                    if (newNode != null)
                    {
                        //existe
                        newNode.visitList.Add(moveList[i].currentStep);
                    }
                    else
                    {
                        //no existe
                        newNode = new Node(father, moveList[i].coordX, moveList[i].coordY, moveList[i].childNumber, moveList[i].currentStep);
                        newNode.visited = true;
                        father.childList.Add(newNode);
                    }
                    
                }
            }
        }

        public Node search(int x, int y)
        {
            return searchInTree(root, x, y);
        }

        public Node searchInTree(Node currentNode, int x, int y)
        {
            Node father = null;

            if(currentNode.posX == x && currentNode.posY == y)
            {
                return currentNode;
            }
            
            for(int i = 0; i < currentNode.childList.Count; i++)
            {
                father = searchInTree(currentNode.childList[i], x, y);
                if(father != null)
                {
                    return father;
                }
            }

            return null;
        }

        public void printTree(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            
        }
    }
}
