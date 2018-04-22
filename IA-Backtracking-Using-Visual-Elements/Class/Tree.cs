using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Backtracking_Using_Visual_Elements.Class
{
    class Node
    {
        int fatherPositionX;
        int fatherPositionY;
        int positionX;
        int positionY;
        int numberOfChilds;
        int visitOrder;
        bool isOpen;
        string other;
        bool isVisited;

        Node leaf1;
        Node leaf2;
        Node leaf3;
        Node leaf4;



        public Node(int fatherPositionX, int fatherPositionY, int positionX, int positionY, int numberOfChilds,
                    int visitOrder, bool isOpen, string other)
        {
            this.fatherPositionX = fatherPositionX;
            this.fatherPositionY = fatherPositionY;
            this.positionX = positionX;
            this.positionY = positionY;
            this.numberOfChilds = numberOfChilds;
            this.visitOrder = visitOrder;
            this.isOpen = isOpen;
            this.IsVisited = false;
            this.other = other;

            leaf1 = null;
            leaf2 = null;
            leaf3 = null;
            leaf4 = null;
        }

        // Getters y Setters
        public int FatherPositionX { get { return fatherPositionX; } set { fatherPositionX = value; } }
        public int FatherPositionY { get { return fatherPositionY; } set { fatherPositionY = value; } }
        public int PositionX { get { return positionX; } set { positionX = value; } }
        public int PositionY { get { return positionY; } set { positionY = value; } }
        public int NumberOfChilds { get { return numberOfChilds; } set { numberOfChilds = value; } }
        public int VisitOrder { get { return visitOrder; } set { visitOrder = value; } }
        public bool IsOpen { get { return isOpen; } set { isOpen = value; } }
        public bool IsVisited { get { return isVisited; } set { isVisited = value; } }
        public Node Leaf1 { get { return leaf1; } set { leaf1 = value; } }
        public Node Leaf2 { get { return leaf2; } set { leaf2 = value; } }
        public Node Leaf3 { get { return leaf3; } set { leaf3 = value; } }
        public Node Leaf4 { get { return leaf4; } set { leaf4 = value; } }


        public string Other { get { return other;  } set { other = value; } }
    }



    /* CLASE ARBOL */



    class Tree
    {
        Node root;
        Node lastAdded;

        public Tree()
        {
            root = null;
        }

        public Tree(Node root)
        {
            this.root = root;
            root.Other = "Punto inicial";
            lastAdded = root;
        }

        public void add(Node newNode)
        {
            // if the tree is empty add the new node to root
            if (root == null)
            {
                root = newNode;
                root.Leaf1 = null;
                root.Leaf2 = null;
                root.Leaf3 = null;
                root.Leaf4 = null;
                lastAdded = root;
            }
            else
            {
                if(lastAdded.Leaf1 == null)
                {
                    lastAdded.Leaf1 = newNode;
                    return;
                }
                else if(lastAdded.Leaf2 == null)
                {
                    lastAdded.Leaf2 = newNode;
                    return;
                }
                else if(lastAdded.Leaf3 == null)
                {
                    lastAdded.Leaf3 = newNode;
                    return;
                }
                else if(lastAdded.Leaf4 == null)
                {
                    lastAdded.Leaf4 = newNode;
                    return;
                }
            }

            /* Using the las added node to keep adding 
            bool added = false;

            do
            {
                // Traverse tree
                if(newNode.VisitOrder < lastAdded.VisitOrder)
                {
                    // Go left
                    if(lastAdded.Left == null)
                    {
                        // Add item
                        lastAdded.Left = newNode;
                        added = true;
                    }
                    else
                    {
                        lastAdded = lastAdded.Left;
                    }
                }
                // Traverse tree
                if(newNode.VisitOrder >= lastAdded.VisitOrder)
                {
                    if(lastAdded.Right == null)
                    {
                        lastAdded.Right = newNode;
                        added = true;
                    }
                    else
                    {
                        // Go right
                        lastAdded = lastAdded.Right;
                    }
                }
            }
            while (!added);
            */
        }

        public void printTree()
        {
            if(root == null)
            {
                Console.WriteLine("El arbol esta vacio");
                return;
            }

            if(root.Leaf1 != null)
            {
                Console.WriteLine("LEAF 1" + "\n" + "Padre: " + root.FatherPositionX + "," + root.FatherPositionY + "\n" + "Posicion: "
                + root.PositionX + "," + root.PositionY + "\n" + "Numero de hijos: " + root.NumberOfChilds
                + "\n" + "Orden de visita: " + root.VisitOrder + "\n" + "Abierto: " + root.IsOpen + "\n" + "Otro: " + root.Other);
            }

            if(root.Leaf2 != null)
            {
                Console.WriteLine("LEAF 2" + "\n" + "Padre: " + root.FatherPositionX + "," + root.FatherPositionY + "\n" + "Posicion: "
                + root.PositionX + "," + root.PositionY + "\n" + "Numero de hijos: " + root.NumberOfChilds
                + "\n" + "Orden de visita: " + root.VisitOrder + "\n" + "Abierto: " + root.IsOpen + "\n" + "Otro: " + root.Other);
            }

            if (root.Leaf3 != null)
            {
                Console.WriteLine("LEAF 3" + "\n" + "Padre: " + root.FatherPositionX + "," + root.FatherPositionY + "\n" + "Posicion: "
                + root.PositionX + "," + root.PositionY + "\n" + "Numero de hijos: " + root.NumberOfChilds
                + "\n" + "Orden de visita: " + root.VisitOrder + "\n" + "Abierto: " + root.IsOpen + "\n" + "Otro: " + root.Other);
            }

            if (root.Leaf4 != null)
            {
                Console.WriteLine("LEAF 4" + "\n" + "Padre: " + root.FatherPositionX + "," + root.FatherPositionY + "\n" + "Posicion: "
                + root.PositionX + "," + root.PositionY + "\n" + "Numero de hijos: " + root.NumberOfChilds
                + "\n" + "Orden de visita: " + root.VisitOrder + "\n" + "Abierto: " + root.IsOpen + "\n" + "Otro: " + root.Other);
            }

        }

        public bool visitedBranches(Node current, int typeOfBranch)
        {
            bool visited = false;

            switch(typeOfBranch)
            {
                case 1:
                    visited = current.Leaf1.IsVisited;
                    break;

                case 2:
                    visited = current.Leaf2.IsVisited;
                    break;

                case 3:
                    visited = current.Leaf3.IsVisited;
                    break;

                case 4:
                    visited = current.Leaf4.IsVisited;
                    break;

                case 5:
                    visited = (current.Leaf1.IsVisited && current.Leaf2.IsVisited && current.Leaf3.IsVisited
                        && current.Leaf4.IsVisited) ? true : false;
                    break;
            }

            return visited;
        }

    }
}
