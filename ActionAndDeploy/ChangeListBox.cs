using System.Windows.Forms;

namespace ActionAndDeploy
{
    public class ChangeListBox<T> : IChange<T>
    {
        public ListBox ListBox;
        public ChangeListBox(ListBox Addition)
        {
            ListBox = Addition;
        }

        public void Addition(T AddtionItem)
        {
            ListBox.Items.Add(AddtionItem.ToString());
        }

        public void Remove()
        {
            ListBox.Items.RemoveAt(ListBox.Items.Count - 1);
        }
    }
}
