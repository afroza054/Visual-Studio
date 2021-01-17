using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.MUSEUM
{
    public class ViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        List<Object_Exhibition> object_Exhibitions;
        int i = 0;
        bool isEditing = false;
        bool isAdding = false;
        public ViewModel()
        {
            object_Exhibitions = new List<Object_Exhibition>
            {
                new Object_Exhibition{Object_Id=1, Object_Name="Terracotta Head",Type_of_Object="Historic", Period_of_Object="1575 Year"},
                new Object_Exhibition{Object_Id=2, Object_Name="Cloths of King & Queen",Type_of_Object="Culture", Period_of_Object="1200-1900 Year"},
                new Object_Exhibition{Object_Id=3, Object_Name="Famine Sketch",Type_of_Object="Artistic", Period_of_Object="1965 Year"},
                new Object_Exhibition{Object_Id=4, Object_Name="Sculpture of Husni Dalan",Type_of_Object="Archaeology", Period_of_Object="1700 Year"},
               new Object_Exhibition{Object_Id=5, Object_Name="Chair of Sheikh Mujiber Rahman",Type_of_Object="Libartion War", Period_of_Object="1971 Year"}
            };
            i = 0;
        }
        public async Task<List<Object_Exhibition>> GetObject_ExhibitionsAsync()
        {
            return await Task.FromResult<List<Object_Exhibition>>(this.object_Exhibitions);
        }
        public Object_Exhibition Current
        {
            get { return object_Exhibitions[i]; }
        }
        public bool IsAddingOrEditing
        {
            get=> isEditing || isAdding;
        }

        public bool IsBrowsing
        {
            get => !isAdding && !isEditing;
        }
        public void AddNew()
        {
            this.object_Exhibitions.Add(new Object_Exhibition());
            this.i = this.object_Exhibitions.Count - 1;
            this.isAdding = true;
            this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsAddingOrEditing)));
            this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(Current)));
        }
        public void BeginEdit()
        {
            this.isEditing = true;
            this.PropertyChanged(this, new  PropertyChangedEventArgs(nameof(IsAddingOrEditing)));
            this.PropertyChanged(this, new PropertyChangedEventArgs (nameof(IsBrowsing)));
        }
        public void Save()
        {
            this.isAdding = false;
            this.isEditing = false;
            this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsAddingOrEditing)));
            this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsBrowsing)));
        }
        public void Cancel()
        {
            if(this.isAdding)
            {
                this.object_Exhibitions.RemoveAt(this.object_Exhibitions.Count - 1);
                this.i = 0;
                this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(Current)));
            }
            this.isEditing = false;
            this.isAdding = false;
            this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsAddingOrEditing)));
            this.PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsBrowsing)));
        }

        public void Next()
        {
            if (i < object_Exhibitions.Count - 1) i++;
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs("Current"));
        }
        public void Previous()
        {
            if (i > 1) i--;
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs("Current"));
        }
        public void First()
        {
            i = 0;
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs("Current"));
        }
        public void Last()
        {
            i = object_Exhibitions.Count - 1;
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs("Current"));
        } 
    }
}


