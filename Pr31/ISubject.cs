using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31
{
    public interface ISubject
    {
       // grundet vi befinder os i en Interface, er public inforstået. Dermed behøver man ikke skrive "Public".
       // Og dette er kontrakten
        /*public*/ void Attach(IObserver o);
        /*public*/ void Detach(IObserver o);
        /*public*/ void Notify();
    }
}
