using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyvalet.ViewModels
{
    public abstract class KeyvaletViewModel
    {
        public KeyvaletViewModel(Uri uri)
        {
            this.Uri = uri;
        }

        public Uri Uri { get; }
    }
}
