using System;
using Kylinariia.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Kylinariia.Domain.Service
{
    public class CommentsService : ICollection<Comments>
    {
        ICollection<Comments> comments = new List<Comments>();
        public int Count
        {
            get
            {
                return comments.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return comments.IsReadOnly;
            }
        }

        public void Add(Comments item)
        {
            comments.Add(item);
        }

        public void Clear()
        {
            comments.Clear();
        }

        public bool Contains(Comments item)
        {
            return comments.Contains(item);
        }

        public void CopyTo(Comments[] array, int arrayIndex)
        {
            comments.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Comments> GetEnumerator()
        {
            return comments.GetEnumerator();
        }

        public bool Remove(Comments item)
        {
            return comments.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return comments.GetEnumerator();
        }
    }
}
