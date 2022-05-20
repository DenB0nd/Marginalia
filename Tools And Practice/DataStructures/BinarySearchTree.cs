namespace Tools_And_Practice.DataStructures;

class BinarySearchTree<T> where T : IComparable<T>
{
    public Node<T>? Root { get; private set; } = null;

    public void Add(T data)
    {
        if (Root == null)
        {
            Root = new Node<T>(data);
            return;
        }

        Node<T>? nextNode = Root;
        Node<T> prevNode = nextNode;
        while (nextNode is not null)
        {
            prevNode = nextNode;
            if (data.CompareTo(nextNode.Data) < 0)
            {
                nextNode = nextNode.Left;
            }
            else if (data.CompareTo(nextNode.Data) > 0)
            {
                nextNode = nextNode.Right;
            }
            else
            {
                return;
            }
        }

        Node<T> newNode = new Node<T>(data);

        if (data.CompareTo(prevNode.Data) < 0)
        {
            prevNode.Left = newNode;
        }
        else
        {
            prevNode.Right = newNode;
        }
    }

    public void Remove(T data)
    {
        Node<T>? node = FindNode(data, out Node<T>? parent);
        if (node is null)
        {
            return;
        }

        Node<T>? successor;
        if (node.Left is null || node.Right is null)
        {
            if (node.Left is null)
            {
                successor = node.Right;
            }
            else
            {
                successor = node.Left;
            }
        }
        else
        {
            successor = node.Right;
            Node<T>? buff = null;
            while (successor.Left is not null)
            {
                buff = successor;
                successor = successor.Left;
            }

            if (buff is not null)
            {
                buff.Left = successor.Right;
                successor.Right = node.Right;
                successor.Left = node.Left;
            }
            else
            {
                successor.Left = node.Left;
            }

        }

        if (parent is not null)
        {
            if (node == parent.Left)
            {
                parent.Left = successor;
            }
            else
            {
                parent.Right = successor;
            }
        }
        else
        {
            Root = successor;
        }
    }

    public void PostOrderTraversal(Action<Node<T>> action) => PostOrderTraversal(action, Root);
    private void PostOrderTraversal(Action<Node<T>> action, Node<T>? node)
    {
        if (node is null)
        {
            return;
        }

        PostOrderTraversal(action, node.Right);
        PostOrderTraversal(action, node.Left);
        action(node);

    }

    public void PreOrderTraversal(Action<Node<T>> action) => PreOrderTraversal(action, Root);
    private void PreOrderTraversal(Action<Node<T>> action, Node<T>? node)
    {
        if (node is null)
        {
            return;
        }

        action(node);
        PreOrderTraversal(action, node.Left);
        PreOrderTraversal(action, node.Right);
    }

    public void InOrderTraversal(Action<Node<T>> action) => InOrderTraversal(action, Root);
    private void InOrderTraversal(Action<Node<T>> action, Node<T>? node)
    {
        if (node is null)
        {
            return;
        }

        InOrderTraversal(action, node.Left);
        action(node);
        InOrderTraversal(action, node.Right);
    }

    public bool Contains(T data)
    {
        return FindNode(data, out _) is not null;
    }

    public void Clear()
    {
        Root = null;
    }

    private Node<T>? FindNode(T data, out Node<T>? parent)
    {
        Node<T>? node = Root;
        parent = null;
        while (node != null)
        {
            int num = data.CompareTo(node.Data);
            if (num > 0)
            {
                parent = node;
                node = node.Right;
            }
            else if (num < 0)
            {
                parent = node;
                node = node.Left;
            }
            else
            {
                break;
            }
        }
        return node;
    }
}

class Node<T> : IComparable<Node<T>> where T : IComparable<T>
{
    public T Data { get; init; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }

    public Node(T data)
    {
        Data = data;
    }

    public int CompareTo(Node<T>? other)
    {
        if (other is null)
        {
            return 1;
        }

        if (Data is null)
        {
            return 0;
        }

        return Data.CompareTo(other.Data);
    }
}