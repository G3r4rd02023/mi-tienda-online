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