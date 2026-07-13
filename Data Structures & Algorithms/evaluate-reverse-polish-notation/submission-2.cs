public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> temp = new Stack<int>();
        int i = 0;
        while(i<tokens.Length){
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/"){
                int var2 = temp.Pop();
                int var1 = temp.Pop();
                int ans = 1;
                switch(tokens[i]){
                    case "+": ans = var1+var2;
                    break;
                    case "-": ans = var1-var2;
                    break;
                    case "*": ans = var1*var2;
                    break;
                    case "/": ans = var1/var2;
                    break;
                }
                temp.Push(ans);

            }
            else{
                temp.Push(int.Parse(tokens[i]));
            }
            i++;
        }
        return temp.Peek();
    }
}
