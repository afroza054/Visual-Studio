using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.MUSEUM
{
    public class Object_Exhibition : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        int _objectid;
        public int Object_Id
        {
            get => _objectid; set
            {
                _objectid = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Object_Id"));
            }
        }
        
        string _objectname;
        public string Object_Name
        {
            get => _objectname; set
            {
                _objectname = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Object_Name"));
            }
        }
        string _typeofobject;
        public string Type_of_Object
        {
            get => _typeofobject; set
            {
                _typeofobject = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Typeof_object"));
            }
        }
        string  _periodofObject;
        public string Period_of_Object
        {
            get => _periodofObject; set
            {
                _periodofObject = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Period_of_Object"));
            }
        }
        string _description;
        public string Description
        {
            get => _description; set
            {
                _description = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }

    }
}
