using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exhibition : Event
{
    private int _noOfStall;

    public Exhibition(string _name, string _type, int _noOfStall) : base(_name, _type)
    {
        this._noOfStall = _noOfStall;
    }

    public int NoOfStall
    {
        get{
            return this._noOfStall;
        }
        set{
            this._noOfStall = value;
        }
    }
}