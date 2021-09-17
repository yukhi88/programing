import java.util.*;
public class login {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

			//登録されているID
	       String[] data_id= {"ab","cd","ef","gh"};
	       //登録されているパスワード
	       String[] data_pass= {"a12","b34","c56","g78"};
	       
	       //ID入力
	       System.out.print("ID: ");
	       String in_id=sc.next();
	       
	       //パスワード入力
	       System.out.print("pass: ");
	       String in_pass=sc.next();
	       
	       System.out.println();//改行
	       
	       for(int i=0;i<data_id.length;i++) {
	    	   if(data_id[i].equals(in_id)==true&&data_pass[i].equals(in_pass)==true) {
	    		   System.out.println("ログイン成功");
	    		   break;
	    	   }
	    	   if(i+1==data_id.length) {
	    		   System.out.println("ログインに失敗しました");
	    	   }
	       }

	}

}
