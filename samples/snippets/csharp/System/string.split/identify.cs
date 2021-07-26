using System;

namespace Split
{
    class Identify
    {
        private static void SplitWithcharAndInt()
        {
            // <Snippet3>
            string phrase = "The quick  brown fox";

            _ = phrase.Split(default(char[]), 3, stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split((char[])null, 3, stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split(null as char[], 3, stringSplitOptions.RemoveEmptyEntries);
            // </Snippet3>
        }

        private static void SplitWithstringAndInt()
        {
            // <Snippet4>
            string phrase = "The quick  brown fox";

            _ = phrase.Split(default(string[]), 3, stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split((string[])null, 3, stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split(null as string[], 3, stringSplitOptions.RemoveEmptyEntries);
            // </Snippet4>
        }

        private static void SplitWithchar()
        {
            // <Snippet5>
            string phrase = "The quick  brown fox";

            _ = phrase.Split(default(char[]), stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split((char[])null, stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split(null as char[], stringSplitOptions.RemoveEmptyEntries);
            // </Snippet5>
        }

        private static void SplitWithstring()
        {
            // <Snippet6>
            string phrase = "The quick  brown fox";

            _ = phrase.Split(default(string[]), stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split((string[])null, stringSplitOptions.RemoveEmptyEntries);

            _ = phrase.Split(null as string[], stringSplitOptions.RemoveEmptyEntries);
            // </Snippet6>
        }
    }
}
