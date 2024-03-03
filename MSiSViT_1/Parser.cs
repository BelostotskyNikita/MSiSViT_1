using System.Text.RegularExpressions;

namespace MSiSViT_1
{
    public class Parser
    {
        public static List<Tuple<string, int>> OperandParse(string input)
        {
            var operandCounts = new Dictionary<string, int>();
            var matches = Regex.Matches(input, @"[$]\w+(->)?(\w+)?");
            foreach (Match match in matches)
            {
                if (operandCounts.ContainsKey(match.Value))
                    operandCounts[match.Value]++;
                else
                    operandCounts.Add(match.Value, 1);
            }
            var result = new List<Tuple<string, int>>();
            foreach (var pair in operandCounts)
                result.Add(new Tuple<string, int>(pair.Key, pair.Value));
            return result;
        }

        private static List<Tuple<string, int>> CountOperators(string code)
        {
            string[] operators = { "+", "-", "*", "/", "%", ">", "<", "==", "!=", "&&", "||", "**", "<>", "<=", ">=", "!", "++", "--", "+=", "->", "//", ".", "(" };
            Dictionary<string, int> operatorCounts = new Dictionary<string, int>();
            foreach (string line in code.Split('\n'))
                foreach (string op in operators)
                {
                    int count = CountOccurrences(line, op);
                    if (count > 0)
                    {
                        if (operatorCounts.ContainsKey(op))
                            operatorCounts[op] += count;
                        else
                            operatorCounts[op] = count;
                    }
                }
            List<Tuple<string, int>> result = operatorCounts
                .Select(kv => Tuple.Create(kv.Key, kv.Value))
                .ToList();

            return result;
        }

        private static int BracketParse(string phpcode)
        {
            string pattern = @"((?<!(\w+)(\s+)?)(\())";
            Regex regex = new Regex(pattern);
            return regex.Matches(phpcode).Count;
        }

        private static int CountOccurrences(string text, string substr)
        {
            int count = 0;
            int index = text.IndexOf(substr, StringComparison.Ordinal);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(substr, index + 1, StringComparison.Ordinal);
            }
            return count;
        }

        private static List<Tuple<string, int>> CountPhpOperators(string phpCode)
        {
            var operatorCount = new List<Tuple<string, int>>();
            string pattern = @"\b(?:if|else|while|for|foreach|switch|case|break|continue|return|and|or|xor)\b";
            MatchCollection matches = Regex.Matches(phpCode, pattern);
            foreach (Match match in matches)
            {
                string operatorName = match.Value;
                var existingTuple = operatorCount.Find(t => t.Item1 == operatorName);
                if (existingTuple != null)
                {
                    var index = operatorCount.IndexOf(existingTuple);
                    operatorCount[index] = new Tuple<string, int>(operatorName, existingTuple.Item2 + 1);
                }
                else operatorCount.Add(new Tuple<string, int>(operatorName, 1));

            }
            return operatorCount;
        }

        private static List<Tuple<string, int>> cor(List<Tuple<string, int>> list)
        {
            int i1 = list.FindIndex(tuple => tuple.Item1 == "++");
            int i2 = list.FindIndex(tuple => tuple.Item1 == "+");
            if (i1 != -1) list[i2] = new Tuple<string, int>("+", list[i2].Item2 - list[i1].Item2 * 2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "+=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "+");
            if (i1 != -1) list[i2] = new Tuple<string, int>("+", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == ">=");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "<");
            if (i1 != -1) list[i2] = new Tuple<string, int>("<", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<>");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<>");
            i2 = list.FindIndex(tuple => tuple.Item1 == "<");
            if (i1 != -1) list[i2] = new Tuple<string, int>("<", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "-=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "-");
            if (i1 != -1) list[i2] = new Tuple<string, int>("-", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "*=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "*");
            if (i1 != -1) list[i2] = new Tuple<string, int>("*", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "/=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "/");
            if (i1 != -1) list[i2] = new Tuple<string, int>("/", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "**");
            i2 = list.FindIndex(tuple => tuple.Item1 == "*");
            if (i1 != -1) list[i2] = new Tuple<string, int>("*", list[i2].Item2 - list[i1].Item2 * 2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "--");
            i2 = list.FindIndex(tuple => tuple.Item1 == "-");
            if (i1 != -1) list[i2] = new Tuple<string, int>("-", list[i2].Item2 - list[i1].Item2 * 2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "->");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "->");
            i2 = list.FindIndex(tuple => tuple.Item1 == "-");
            if (i1 != -1) list[i2] = new Tuple<string, int>("-", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "//");
            i2 = list.FindIndex(tuple => tuple.Item1 == "/");
            if (i1 != -1) list[i2] = new Tuple<string, int>("/", list[i2].Item2 - list[i1].Item2 * 2);
            return list;
        }
        private static List<Tuple<string, int>> FunctionParse(string input)
        {
            var funcCounts = new Dictionary<string, int>();
            var matches = Regex.Matches(input, @"\b(?<!(function\s+)|(->))(\w+\()");


            foreach (Match match in matches)
            {
                if (funcCounts.ContainsKey(match.Value + ")"))
                {
                    funcCounts[match.Value]++;
                }
                else
                {
                    funcCounts.Add(match.Value + ")", 1);
                }
            }

            //echo

            if (input.Contains("echo"))
            {
                funcCounts.Add("echo", Regex.Matches(input, @"echo").Count());
            }

            var result = new List<Tuple<string, int>>();
            foreach (var pair in funcCounts)
            {
                result.Add(new Tuple<string, int>(pair.Key, pair.Value));
            }

            return result;
        }
        public static List<Tuple<string, int>> OperatorParse(string code)
        {
            List<Tuple<string, int>> res1 = cor(CountOperators(code));
            res1.Add(new Tuple<string, int>("()", BracketParse(code)));
            var res2 = CountPhpOperators(code);
            var res3 = FunctionParse(code);
            foreach (var item in res2)
                res1.Add(item);
            foreach (var item in res3)
                res1.Add(item);
            return res1;
        }

        
    }
}
