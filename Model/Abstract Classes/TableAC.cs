using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    abstract class TableAC
    {
        private int id;
        private State state;
        private Order order;
        public int getId() { return id; }
        public void setId(int id) { this.id = id; }
        public State getState() { return state; }
        public void setState(State state) { this.state = state; }
        public Order getOrder() { return order; }
        public void setOrder(Order order) { this.order = order; }
    }

    enum State
    {
        available,
        occupied,
        reserved
    }
}
