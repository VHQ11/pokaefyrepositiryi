using System.Collections.Generic;
using System.Linq;

namespace STENN_Task_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void SelectNames(Tree tree, ICollection<string> names)
        {
            names.Add(tree.Name);

            if (tree.Children == null || !tree.Children.Any())
            {
                return;
            }

            foreach (var item in tree.Children)
            {
                SelectNames(item, names);
            }
        }
    }
}
