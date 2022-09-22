using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public partial class MusteriManager : Component
    {
        public MusteriManager()
        {
            InitializeComponent();
        }

        public MusteriManager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
