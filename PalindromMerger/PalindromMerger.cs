namespace PalindromMergerPC;

public class PalindromMerger
{
    public string Merge(string Palindrom1, string Palindrom2){
        if(Palindrom1.Length%2!=0 && Palindrom2.Length%2!=0){
            return string.Empty;
        }
        string smaller = Palindrom1.Length < Palindrom2.Length ? Palindrom1 : Palindrom2;
        string bigger = Palindrom1.Length >= Palindrom2.Length ? Palindrom1 : Palindrom2;

        return MergeSmallerIntoBigger(smaller, bigger);
    }

    private string MergeSmallerIntoBigger(string smaller, string bigger){
        string [] result = new string [smaller.Length + bigger.Length];
        int iterationCounter = (bigger.Length)/2;
        if(bigger.Length%2!=0){
            iterationCounter++;
        }
        int lowerWordIndex = 0;
        int upperWordIndex = bigger.Length-1;
        int lowerResultIndex =0;
        int upperResultIndex = result.Length-1;
        for(int i=0; i<iterationCounter;i++){
            if(upperWordIndex==lowerWordIndex){
                int tempResultIndex = (lowerResultIndex + upperResultIndex)/2;
                result[tempResultIndex] = bigger[lowerWordIndex].ToString();
            }
            else{
            result[lowerResultIndex] = bigger[lowerWordIndex].ToString();
            result[upperResultIndex] = bigger[upperWordIndex].ToString();
            }
            lowerResultIndex+=2;
            upperResultIndex-=2;
            lowerWordIndex++;
            upperWordIndex--;
        }
        int smallWordIndexCounter =0;
        for(int i=0; i<result.Length;i++){
            if(result[i]==null){
                result[i] = smaller[smallWordIndexCounter].ToString();
                smallWordIndexCounter++;
            }
        }
        return CreateResultString(result);
    }
    private string CreateResultString(string [] inputResult){
        string result = "";
        foreach(string inputResultItem in inputResult){
            result+=inputResultItem;
        }
        return result;
    }
}
