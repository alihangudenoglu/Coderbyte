package java.easy;

public class ThreeNumbers {
    public static boolean StringChallenge(String str) {
        int wordLength=str.split(" ").length;
        int count=0;
        String nmrStr="";
        for(int i=0;i<str.length();i++){
          if(Character.isDigit(str.charAt(i))){
            count++;
            nmrStr+=str.charAt(i);
          }
          else{
            count=0;
          }
          if(count>2){
            return false;
          }
        }
        if(nmrStr.length()%3==0){
          for(int i=0;i<wordLength;i++){
            if(nmrStr.charAt(i*3)!=nmrStr.charAt(i*3+1) && nmrStr.charAt(i*3)!=nmrStr.charAt(i*3+2) && nmrStr.charAt(i*3+1)!=nmrStr.charAt(i*3+2)){
    
            }
            else{
              return false;
            }
          }
        }
        else{
          return false;
        }
        return true;
      }
}
