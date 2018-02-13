using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Linda L. Schandorph Larsen + GitHub schandorph2454

namespace MockEksamenFromFirstYear
{
    public class Car
    {
        public enum color { Black, White, Gray, Red, Green, Blue }

        private Car.color _color;
        private int _doors;
        private string _model;
        private string _registrationNo;

        public Car(color farve,  int doors, string model, string registrationNo)
        {

            if ((doors < 2) || (doors > 5))
            {
                throw new ArgumentException("Dørene skal være en værdi mellem 2 og 5");
            }

            if(model.Equals(null))
            {
                throw new ArgumentException("Modellen skal ikke være null");
            }

            if((registrationNo.Length < 7) || (registrationNo.Length > 7))
            {
                throw new ArgumentException("RegistrationNr skal have nøjagtige 7 tegn");
            }

            _color = farve;
            _doors = doors;
            _model = model;
            _registrationNo = registrationNo;
        }

        public color farve
        {
            get { return _color; }
            set { _color = value; }
        }

        public int doors
        {
            get { return _doors; }
            set { _doors = value; }
        }

        public string model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string registrationNo
        {
            get { return _registrationNo; }
            set { _registrationNo = value; }
        }                 
    }
}
