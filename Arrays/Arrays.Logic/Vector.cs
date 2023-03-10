namespace Arrays.Logic
{
    public class Vector
    {
        private int _top;//tamano logico
        private int[] _array;

        public Vector(int n)
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;
        public int N { get; }//tamano fisico

        public void Add(int number) 
        { 
            if(IsFull)
            {
                throw new Exception("El arreglo esta lleno");
            }
            _array[_top] = number;
            _top++;           
        }

        public void Insert(int number, int position)
        {
            if(IsFull) 
            {
                throw new Exception("El arreglo esta lleno");
            }

            if(position < 0)
            {
                position = 0;
            }

            if(position > _top)
            {
                position = _top;
            }

            for (int i = _top; i > position; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[position] = number;
            _top++;

        }

        public void Remove(int position)
        {
            if(IsEmpty) 
            {
                throw new Exception("El arreglo esta vacio");
            }
            
            if (position < 0)
            {
                position = 0;
            }

            if (position > _top)
            {
                position = _top;
            }

            for (int i = position; i < _top - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            _top--;
        }

        public Vector GetOdds() 
        {
            int oddsCount = 0;
            for (int i = 0; i < _top; i++)
            {
                if (_array[i]%2 == 0)
                {
                    oddsCount++;
                }
            }
            var oddsArray = new Vector(oddsCount);
            for (int i = 0; i < _top; i++)
            {
                if (_array[i]%2 == 0)
                {
                    oddsArray.Add(_array[i]);
                }
            }
            return oddsArray;
        }

        public void Fill(int min, int max )
        {
            Random random = new();
            for ( int i = 0; i < N; i++ ) 
            {
                _array[i] = random.Next(min, max); 
            }
            _top = N;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Arreglo vacio";
            }

            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
                count++;
                if(count > 9)
                {
                    count = 0;
                    output += "\n";
                }
            }
            return output;
        }

        public void Sort()
        {
            Sort(false);
        }

        public void Sort(bool desc)
        {
            for (int i = 0; i < _top - 1; i++)
            {
                for (int j = i + 1; j < _top; j++)
                {
                    if(desc)
                    {
                        if (_array[i] > _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    else
                    {
                        if (_array[i] < _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    
                }
            }
        }

        private void Change(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;            
        }
    }
}