package java.hard;
public class ArrayRotation {
    public static String ArrayChallenge(int[] arr) {
        int count=arr.length;
        String result="";    
        for(int i=arr[0];i<count;i++){
          result+=arr[i];
          if(i==arr.length-1){
            i=-1;
            count=arr[0];
          }
        }
        return result;    
      }
}
