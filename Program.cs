using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Test3_2026_Ans
{
    class Program
    {
        public static Node<int> CreateChain()
        {
            Node<int> chain = new Node<int>(-999);
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());// קליטת מספר
            Node<int> pos = chain;
            while (num != -999)
            {
                pos.SetNext(new Node<int>(num));
                pos = pos.GetNext();
                Console.WriteLine("enter another a number");
                num = int.Parse(Console.ReadLine());// קליטת מספר
            }
            chain = chain.GetNext();
            return chain;
        }
        //// טענת כניסה: מערך של ערכים גנרי
        // טענת יציאה: הפעולה יוצרת ומחזירה שרשרת חוליות גנרית בהתאם לטיפוס המערך 
        public static Node<int> GetList(int[] arr)
        {
            // בניית השרשרת
            Node<int> lst = new Node<int>(arr[0]);
            Node<int> pos = lst;
            for (int i = 1; i < arr.Length; i++)
            {
                pos.SetNext(new Node<int>(arr[i]));
                pos = pos.GetNext();
            }
            return lst;
        }


        // Sum of all Nodes
        public static int SumValuesNodes(Node<int> lst)
        {
            int sum = 0;
            while (lst != null)
            {
                sum += lst.GetValue();
                lst = lst.GetNext();
            }
            return sum;
        }
        // Count of all Nodes
        public static int CountNodes(Node<int> lst)
        {
            int count = 0;
            while (lst != null)
            {
                count++;
                lst = lst.GetNext();
            }
            return count;
        }
        // בסדר הפוך
        public static Node<int> GetListBack(int[] arr)
        {
            // בניית השרשרת
            Node<int> lst = new Node<int>(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                lst = new Node<int>(arr[i], lst);
            }

            return lst;
        }
        // טענת כניסה:הפעולה קולטת מספרים שלמים עד ל -999
        // טענת יציאה:הפעולה תחזיר שרשרת חוליות בסדר הפוך לסדר קליטתם
        public static Node<int> CreateOpositeList()
        {
            Node<int> chain = null;
            Console.WriteLine("enter a number - to stop -999");
            int num = int.Parse(Console.ReadLine());
            while (num != -999)
            {
                chain = new Node<int>(num, chain);
                Console.WriteLine("enter another number - to stop -999");
                num = int.Parse(Console.ReadLine());
            }
            return chain;
        }
        // הפעולה מקבלת כפרמטר שרשרת חוליות ממוינת בסדר עולה ומספר שלם
        // הפעולה מכניסה את המספר במקום המתאים בשרשרת
        public static Node<int> InsertToUpChain(Node<int> lst, int num)
        {
            Node<int> pos = lst; // שומרים את ההצבעה לראש השרשרת מבלי לפגוע בה
                                 // כשהמספר קטן מערך החולייה הראשונה:
                                 // מקרה מיוחד
            if (num < lst.GetValue())
                lst = new Node<int>(num, lst); // דוחפים את החולייה החדשה לראש השרשרת
            else  // מקרה רגיל - מחפשים מיקום בתוך השרשרת
            {
                // כל עוד יש לנו חולייה הבאה וכן הערך של החולייה הבאה עדיין קטן מהמספר
                while (pos.GetNext() != null && pos.GetNext().GetValue() < num)
                {
                    pos = pos.GetNext(); // מתקדמים צעד קדימה בשרשרת
                }
                // יצאנו מהלולאה, אז אנחנו במקום המתאים להוסיף את החולייה החדשה במיקום הזה
                // גם אם הגענו לסוף השרשרת-החולייה האחרונה, אז ברור שצריך להוסיף את החולייה בסוף הזה
                //set the next to a new node with his next as the next of pos!!
                pos.SetNext(new Node<int>(num, pos.GetNext()));

            }
            return lst;  // return the original list after the update!
        }
        // הפעולה מקבלת כפרמטר שרשרת חוליות ממוינת בסדר יורד ומספר שלם
        // הפעולה מכניסה את המספר במקום המתאים בשרשרת
        public static Node<int> InsertToDownChain(Node<int> lst, int num)
        {
            // כיתבו את גוף הפעולה
            return lst;
        }
        // פונקציה ליצירת רשימה מקושרת (linked List) בסדר קלט
        // טענות כניסה: אין
        // טענות יציאה: מחזירה את ראש הרשימה שנבנתה
        public static Node<int> MakeNodes()
        {
            Console.WriteLine("Please insert your first Number:");
            int num = int.Parse(Console.ReadLine());
            Node<int> Chain = new Node<int>(num);  // יצירת הנוד הראשון
            Node<int> current = Chain;
            Console.WriteLine("Insert -404 to stop, insert your Number:");
            num = int.Parse(Console.ReadLine());
            while (num != -404)// יוצאים מהלולאה אם הוזן -404
            {
                current.SetNext(new Node<int>(num)); // מחברים את הנוד הבא
                current = current.GetNext(); // מעדכנים את current לנוד החדש
                                             // קולטים עוד מספר
                Console.WriteLine("Insert -404 to stop, insert your Number:");
                num = int.Parse(Console.ReadLine());
            }
            return Chain;
        }
        // פעולה שמחפשת ערך כלשהו בשרשרת חוליות
        public static bool InList(Node<int> lst, int n)
        {
            //??????? 
            //
            //גוף הפעולה
            //
            return true;
        }
        // פעולה שבודקת האם השרשרת מאוזנת - שאלה 1
        public static bool IsBalanced(Node<int> lst)
        {
            if (lst == null)
                return false;
            int count = 0;
            Node<int> p = lst;
            while (p != null)
            {
                count++;
                p = p.GetNext();
            }
            if (count % 2 == 0)
            {
                return false;
            }

            int middleIndex = count / 2;
            Node<int> middle = lst;
            for (int i = 0; i < middleIndex; i++)
            {
                middle = middle.GetNext();
            }
            Node<int> left = lst;
            while (left != middle)
            {
                int val = left.GetValue();
                Node<int> right = middle.GetNext();
                bool found = false;
                while (right != null)
                {
                    if (right.GetValue() == val)
                    {
                        found = true;
                        break;
                    }
                    right = right.GetNext();
                }
                if (!found)
                {
                    return false;
                }
                left = left.GetNext();
            }
            return true;
        }

        public static Node<CountNum> NumberOfOccurrences(Node<int> lst)
        {
            Node<CountNum> result = null;
            Node<CountNum> last = null;
            Node<int> p = lst;
            while (p != null)
            {
                int current = p.GetValue();
                Node<CountNum> check = result;
                bool exists = false;
                while (check != null)
                {
                    if (check.GetValue().GetNum() == current)
                    {
                        exists = true;
                        break;
                    }
                    check = check.GetNext();
                }
                if (!exists)
                {
                    int counter = 0;
                    Node<int> q = lst;
                    while (q != null)
                    {
                        if (q.GetValue() == current)
                        {
                            counter++;
                        }
                        q = q.GetNext();
                    }
                    CountNum cn = new CountNum(current, counter);
                    Node<CountNum> newNode = new Node<CountNum>(cn);
                    if (result == null)
                    {
                        result = newNode;
                        last = newNode;
                    }
                    else
                    {
                        last.SetNext(newNode);
                        last = newNode;
                    }
                }
                p = p.GetNext();
            }
            return result;
        }

        static void Main(string[] args)
        {
            Node<int> lst1 = new Node<int>(9, new Node<int>(7, new Node<int>(5, new Node<int>(2, new Node<int>(6, new Node<int>(9, new Node<int>(2, new Node<int>(7, new Node<int>(5)))))))));
            Console.WriteLine("List 1: ");
            Console.WriteLine(lst1);

            bool balanced1 = IsBalanced(lst1);
            Console.WriteLine("IsBalanced: "+balanced1);
            Console.WriteLine();

            Node<int> lst3 = new Node<int>(9, new Node<int>(7, new Node<int>(9, new Node<int>(7, new Node<int>(5, new Node<int>(9, new Node<int>(3, new Node<int>(7, new Node<int>(5)))))))));
            Console.WriteLine("original list: ");
            Console.WriteLine(lst3);
            Node<CountNum>result = NumberOfOccurrences(lst3);
            Console.WriteLine("NumberOfOccurrences result: ");
           Node<CountNum>p =result;
            while(p != null)
            {
                Console.WriteLine(p.GetValue());
                p=p.GetNext();
            }
            Console.ReadKey();
        }
    }
}
