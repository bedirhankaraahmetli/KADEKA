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
        int ID;
        State state;
        Order order;
        public TableAC(int id)
        {
            ID = id;
            state = State.available;
        }
        public int getId() { return ID; }
        public void setId(int id) { this.ID = id; }
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
