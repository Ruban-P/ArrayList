using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib
{
    public class ArrayList
    {
        int[] _array;
        
        //contructor
        public ArrayList(int size = 2)
        {
            _array = new int[size];
        }
       
  
        int _crt=0;
        public int Crt
        {
            get { return _crt; }
        }

        int _capacity;
        public int Capacity
        {
            get { return _array.Length; }          
        }

        bool _isempty=true;
        public bool Isempty
        {
            get
            {
                if (_crt > 0)
                {
                    _isempty = false;
                }
                return _isempty;
            }
           
        }


      
        //get()
        public int get(int index)
        {
            return _array[index];
        }

        //set()
        public void set(int index, int value)
        {
            _array[index] = value;
        }

        //add()
        public void add(int value)
        {
            if (_capacity == _crt + 1)
            {
                resize();
            }
            _array[_crt] = value;
            _crt++;
        }

        //contains()
        public bool contain(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return true;
                }
            }
            return false;

        }

        //delete()
        public void remove(int index)
        {
            for (int i = index; i < _array.Length; i++)
            {
                    _array[i] = _array[i+1];
            }
            _crt--;
        }

        //insert
        public void insert(int index, int valu)
        {
            int temp=0;
            int temp1 = 0;

            if (_capacity == _crt + 1)
            {
                resize();
            }
            for (int i = index; i < _array.Length; i++)
            {
                
                if (i == index)
                {
                   temp=_array[i]; 
                    _array[i] = valu;
                }
                if (i > index)
                {
                    temp1 = _array[i];
                    _array[i] = temp;
                    temp = temp1;
                }
                
            }
            _crt++;
        }

        //resize()
        private void resize()
        { 
        int[] newarray=new int[_array.Length*2];
        for (int i = 0; i < _array.Length; i++)
        {
            newarray[i] = _array[i];
        }
        _array = newarray;
        
        }

        //print()
        public void print(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
