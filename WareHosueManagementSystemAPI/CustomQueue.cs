using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHosueManagementSystemAPI
{
    class CustomQueue<T>
    {
        Queue<T> _queue = null;

        public CustomQueue()
        {
            _queue = new Queue<T>();
        }

        public int QueueLength
        {
            get
            {
                return _queue.Count;
            }
        }

        public void AddItem(T item)
        {

        }

        public T GetItem()
        {

        }

        public virtual void OnQueueChanged(QueueEventArgs e)
        {
             
        }
            
        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }
    }

    public class QueueEventArgs : EventArgs
    {
        public string message { get; set; }
    } 
}
 