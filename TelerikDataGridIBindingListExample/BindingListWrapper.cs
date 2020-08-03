using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikDataGridIBindingListExample
{
    public class BindingListWrapper<V> : IDataSourceRequirements<V> where V : new()
    {
        private BindingList<V> Inner = new BindingList<V>();
        private IBindingList InnerExplicit => (IBindingList)this.Inner;

        public BindingListWrapper()
        {
            this.Inner = new BindingList<V>();
            this.Inner.ListChanged += Inner_ListChanged;
        }

        private void Inner_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (sender == this.Inner)
                this.ListChanged?.Invoke(this, e);
            else
                this.ListChanged?.Invoke(sender, e);
        }

        public V this[int index] { get => this.Inner[index]; set => this.Inner[index] = value; }

        object IList.this[int index] { get => this.InnerExplicit[index]; set => this.InnerExplicit[index] = (V)value; }

        bool IBindingList.AllowNew => this.InnerExplicit.AllowNew;

        bool IBindingList.AllowEdit => this.InnerExplicit.AllowEdit;

        bool IBindingList.AllowRemove => this.InnerExplicit.AllowRemove;

        bool IBindingList.SupportsChangeNotification => this.InnerExplicit.SupportsChangeNotification;

        bool IBindingList.SupportsSearching => this.InnerExplicit.SupportsSearching;

        bool IBindingList.SupportsSorting => this.InnerExplicit.SupportsSorting;

        bool IBindingList.IsSorted => this.InnerExplicit.IsSorted;

        PropertyDescriptor IBindingList.SortProperty => this.InnerExplicit.SortProperty;

        ListSortDirection IBindingList.SortDirection => this.InnerExplicit.SortDirection;

        bool IList.IsReadOnly => this.InnerExplicit.IsReadOnly;

        bool IList.IsFixedSize => this.InnerExplicit.IsFixedSize;

        int ICollection.Count => this.Inner.Count;

        object ICollection.SyncRoot => this.InnerExplicit.SyncRoot;

        bool ICollection.IsSynchronized => this.InnerExplicit.IsSynchronized;

        public event ListChangedEventHandler ListChanged;

        int IList.Add(object value)
        {
            return this.InnerExplicit.Add(value);
        }

        void IBindingList.AddIndex(PropertyDescriptor property)
        {
            this.InnerExplicit.AddIndex(property);
        }

        object IBindingList.AddNew()
        {
            return this.Inner.AddNew();
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            this.InnerExplicit.ApplySort(property, direction);
        }

        void IList.Clear()
        {
            this.Inner.Clear();
        }

        bool IList.Contains(object value)
        {
            return this.InnerExplicit.Contains(value);
        }

        void ICollection.CopyTo(Array array, int index)
        {
            this.InnerExplicit.CopyTo(array, index);
        }

        int IBindingList.Find(PropertyDescriptor property, object key)
        {
            return this.InnerExplicit.Find(property, key);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Inner.GetEnumerator();
        }

        int IList.IndexOf(object value)
        {
            return this.InnerExplicit.IndexOf(value);
        }

        void IList.Insert(int index, object value)
        {
            this.InnerExplicit.Insert(index, value);
        }

        void IList.Remove(object value)
        {
            this.InnerExplicit.Remove(value);
        }

        public void RemoveAt(int index)
        {
            this.Inner.RemoveAt(index);
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property)
        {
            this.InnerExplicit.RemoveIndex(property);
        }

        void IBindingList.RemoveSort()
        {
            this.InnerExplicit.RemoveSort();
        }
    }
}
