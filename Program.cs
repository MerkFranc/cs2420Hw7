using System;

// ========== Part 1 ==========
// 1. A balanced tree is a tree that has relatively even subtrees. By even I mean similar heights.
//
// 2.       10
//           \
//           20
//            \
//            30
//             \
//             40
//              \
//              50
//  height: 4
//  finding 50: visit 5 nodes
//  balanced tree height: 2
//
// 3. BF(node) = height(left subtree) - height(right subtree)
//  allowed balance factors: -1, 0, 1
//
// 4. An AVL tree stays balanced while a plain BST can become a chain, making its height O(n).
//
//5.
// Node 10: height 0, BF 0
// Node 20: height 1, BF +1
// Node 30: height 2, BF +1
// Node 40: height 0, BF 0
// Node 50: height 3, BF 0
// Node 70: height 2, BF -2
// Node 80: height 1, BF -1
// Node 90: height 0, BF 0
// It is not an AVL tree. Node 70 has a BF of -2.
//
// ========== Part 2 ==========
// 6.
//      Insert 33:  Path: 33(0)
//      Insert 18:  Path: 33(1), 18(0). No rotation.
//      Insert 7:   Path: 33(2), 18(1), 17(0). LL at 33; right-rotate at 33
//       18
//      / \
//     7  33
//     Insert 25:   Path: 18(-1), 33(1), 25(0). No rotation.
//     Insert 29:   Path: 18(-2), 33(2), 25(-1), 29(0). LR at 33; left-rotate at 25, then right-rotate at 33
//               18
//              / \
//             7  29
//                / \
//              25  33
//
// 7.
//      Insert 14: Path: 14(0)
//      Insert 26: Path: 14(-1), 26(0). No rotation
//      Insert 38: Path: 14(-2), 26(-1), 38(0). RR at 14; left-rotate at 14
//              26
//              / \
//            14  38
//      Insert 44: Path: 26(-1), 38(-1), 44(0). No rotation
//      Insert 41: Path: 26(-2), 38(-2), 44(1), 41(0). RL at 38; right-rotate at 44, then left-rotate at 38
//              26
//              / \
//             14  41
//                 / \
//               38  44
//
// 8.
//          71
//          / \
//        42   90
//        / \
//       39 48
//
// 9.
//      Insert 52: Path: 52(0). No rotation
//      Insert 37: Path: 52(1), 37(0). No rotation
//      Insert 68: Path: 52(1), 68(0). No rotation
//      Insert 29: Path: 52(1), 37(0), 29(0). No rotation
//      Insert 44: Path: 52(1), 37(0), 44(0). No rotation
//      Insert 41: Path: 52(2), 37(-1), 44(1), 41(0). LR at 52; left-rotate at 37, then right-rotate at 52
//                44
//              /   \
//            37    52
//            /\     \
//          29 41    68
//      Insert 75: Path: 44(-1), 52(-2), 68(-1), 75(0). RR at 52. left-rotate at 52
//
//                44
//              /   \
//            37    68
//            / \   / \
//           29 41 52 75
//      Insert 80: Path: 44(-1), 68(-1), 75(-1), 80(0). No rotation
//      Insert 61: Path: 44(-1), 68(0), 52(-1), 61(0). No rotation
//      Insert 78: Path: 44(-2), 68(-1), 75(-2), 80(1), 78(0). RL at 75; right-rotate at 80, then left-rotate at 75
//
//                  44
//               /     \
//              37     68
//             / \   /   \
//            29 41 52   78
//                   \   / \
//                   61 75 80
//
// ========== Part 3 ======
public class AvlNode
{
    public int Value;
    public AvlNode Left;
    public AvlNode Right;
    public int Height; // a new node starts with Height = 1
}

class Program
{
    static int GetHeight(AvlNode node) { }

    static int GetBalance(AvlNode node) { }

    static void UpdateHeight(AvlNode node) { }

    static AvlNode RotateRight(AvlNode node) { }

    static AvlNode RotateLeft(AvlNode node) { }

    static AvlNode Insert(AvlNode node, int value) { }

    void PrintInOrder(AvlNode node) { }

    bool IsBalanced(AvlNode root) { }

    static void Main(string[] args) { }
}
