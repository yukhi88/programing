import java.awt.*;
import java.awt.event.*;

public class Enemy extends GameObject{

	private int katasa;
	int type;
	int counter;
	
	public Enemy(double ix) {
		x=ix;
		y=0;
		katasa=10;
		type=(int)(Math.random()*2);
		counter=0;
	}
	
	public void move() {
		counter++;
		if(type==0) {
		y++;
		
		x+=Math.sin(y/20);
		}
		else {
			double p=60;
			double q=200;
			
					y=(-q/Math.pow(p, 2)*Math.pow((counter-p),2)+q);
		}
	}
	
	public void draw (Graphics g) {
		if(type==0) {
			g.setColor(Color.BLUE);
		}
		else if(type==1) {
			g.setColor(Color.BLACK);
		}
		g.drawRect((int)x-16, (int)y-16,32,32);
	}
	 public boolean outCheck() {
		 if(type==0) {//下にはみ出た処理
			 if(y>500) {
				 return true;
			 }
			 return false;
		 }
		 else {//上にはみ出た処理
			 if(y<0) {
				 return true;
			 }
			 return false;
		 }
		
	 }
	 public boolean hit() {
		 katasa--;
		 if(katasa<=0) {
			 return true;
		 }
		 else {
			 return false;
		 }
	 }
}
