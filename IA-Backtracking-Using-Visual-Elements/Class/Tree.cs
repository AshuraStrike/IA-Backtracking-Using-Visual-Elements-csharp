using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string visits()
        {
            string visits = "";
            for (int i = 0; i < this.visitList.Count; i++)
            {
                if (this.visitList[i] > 0)
                {
                    visits += this.visitList[i].ToString() + ", ";
                }
            }

            if (visits == "") visits = "Expandido";

            return visits;
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
            Node currentNode = null;

            for(int i = 0; i < moveList.Count; i++)
            {
                if (i == 0)
                {
                    Node newNode = new Node(null, moveList[i].coordX, moveList[i].coordY, moveList[i].childNumber, moveList[i].currentStep);
                    newNode.visited = true;
                    root = newNode;

                    currentNode = newNode;
                }
                else
                {
                    Node father = currentNode;

                    //No se repitan nodos nuevos (Banderear, si o no se repite)
                    Node newNode = search(moveList[i].coordX, moveList[i].coordY);

                    if (newNode != null)
                    {
                        //existe
                        newNode.visitList.Add(moveList[i].currentStep);

                        currentNode = newNode;
                    }
                    else
                    {
                        //no existe
                        newNode = new Node(father, moveList[i].coordX, moveList[i].coordY, moveList[i].childNumber, moveList[i].currentStep);
                        newNode.visited = true;
                        father.childList.Add(newNode);

                        currentNode = newNode;
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

        public void print(ref TreeView treeView)
        {
            for (int i = 0; i < root.childList.Count; i++)
            {
                printTree(root.childList[i], treeView.Nodes[0]);
            }
        }

        private void printTree(Node node,TreeNode parentNode)
        {
            if (node != null)
            {
                //Extract info
                char a = 'A';
                a += (char) node.posX;
                parentNode = parentNode.Nodes.Add(a+","+(node.posY+1)+"\n"+
                    " Numero de hijos: "+node.numberOfChilds+'\n'+
                    " Visitas: "+node.visits());
            }

            for (int i = 0; i < node.childList.Count; i++)
            {
                printTree(node.childList[i], parentNode);
            }
        }
    }
}
