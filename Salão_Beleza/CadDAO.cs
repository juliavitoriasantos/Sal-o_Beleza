using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salão_Beleza
{
    public partial class CadDAO : Component
    {
        public CadDAO()
        {
            InitializeComponent();
        }

        public CadDAO(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
