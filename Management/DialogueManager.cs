using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPFE.Management
{
    public class DialogueManager
    {
        private static DialogueManager? _instance = null;
        private static readonly object Padlock = new object();
        public static DialogueManager Instance
        {
            get
            {
                lock (Padlock)
                {
                    _instance ??= new DialogueManager();
                }
                return _instance;
            }
        }


    }
}
