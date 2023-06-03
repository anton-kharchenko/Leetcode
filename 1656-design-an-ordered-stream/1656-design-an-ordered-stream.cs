public class OrderedStream {
        public string[] stream;
        public int ptr;

        public OrderedStream(int n)
        {
            stream = new String[n];
            ptr = 0;
        }

        public IList<string> Insert(int idKey, string value)
        {

            stream[idKey-1] = value;

            List<string> chunk = new List<string>() { };

            while (ptr < stream.Count() && stream[ptr] != null)
            {
                chunk.Add(stream[ptr]);
                ptr++;
            }
            
            return chunk;

        }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */