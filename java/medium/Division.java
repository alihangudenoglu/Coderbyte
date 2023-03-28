package java.medium;

public class Division {
    public static int MathChallenge(int num1, int num2) {
        int min=num1<num2?num1:num2;
        int result=1;
        for(int i=1;i<=min;i++){
          if(num1%i==0 && num2%i==0){
            result=i;
          }
        }
        return result;
      }
}
