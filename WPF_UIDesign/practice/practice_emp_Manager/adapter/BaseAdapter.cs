using emp_Manager.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_Manager.adapter {
    public class BaseAdapter {

        DaoOracle ora;

        public BaseAdapter() {
            ora = new DaoOracle();

        }

        internal DaoOracle Ora { get => ora; set => ora = value; }
    }
}
