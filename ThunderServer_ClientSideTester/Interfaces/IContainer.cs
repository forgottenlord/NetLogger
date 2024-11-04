using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderServer_ClientSideTester.Interfaces
{
    public interface IContainer<T>
    {
        public void SetContent(T content);
    }
}
