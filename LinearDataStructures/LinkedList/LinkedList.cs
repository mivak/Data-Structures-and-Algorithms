namespace LinkedList
{
    public class LinkedList<T>
    {
        private ListItem<T> firstElement;


        public LinkedList()
        {
            this.FirstElement = null;
        }

        public int Count
        {
            get
            {
                int count = CalculateCount();
                return count;
            }

            private set
            {
            }
        }

        public ListItem<T> FirstElement
        {
            get
            {
                return this.firstElement;
            }

            set
            {
                this.firstElement = value;
            }
        }

        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newListItem = new ListItem<T>(value);
                newListItem.NextItem = this.FirstElement;
                this.FirstElement = newListItem;
            }
        }

        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> next = this.FirstElement;
                while (next.NextItem != null)
                {
                    next = next.NextItem;
                }

                next.NextItem = new ListItem<T>(value);
            }
        }

        public void AddAfter(ListItem<T> item, T value)
        {
            ListItem<T> next = this.FirstElement;

            while (next != item && next.NextItem != null)
            {
                next = next.NextItem;
            }

            ListItem<T> newItem = new ListItem<T>(value);
            newItem.NextItem = next.NextItem;
            next.NextItem = newItem;
        }

        public void AddBefore(ListItem<T> item, T value)
        {
            if (item == this.FirstElement)
            {
                ListItem<T> newList = new ListItem<T>(value);
                newList.NextItem = this.FirstElement;
                this.FirstElement = newList;
            }
            else
            {
                ListItem<T> next = this.FirstElement;
                while (next.NextItem != null && next.NextItem != null)
                {
                    next = next.NextItem;
                }

                ListItem<T> newList = new ListItem<T>(value);
                newList.NextItem = next.NextItem;
                next.NextItem = newList;
            }
        }

        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
        }

        public void RemoveLast()
        {
            ListItem<T> next = this.FirstElement;
            while (next.NextItem != null)
            {
                next = next.NextItem;
            }

            ListItem<T> last = this.FirstElement;
            while (last.NextItem != next)
            {
                last = last.NextItem;
            }

            last.NextItem = null;
        }

        private int CalculateCount()
        {
            int count = 1;
            ListItem<T> next = this.FirstElement;

            while (next.NextItem != null)
            {
                next = next.NextItem;
                count += 1;
            }

            return count;
        }
    }
}