import java.awt.*;
import java.awt.event.*;

public class MyBullet extends GameObject {

	public MyBullet(double ix,double iy) {
		x=ix;
		y=iy;
	}

	public void move() {
		y-=15;
	}
	
	public void draw(Graphics g) {
		g.setColor(Color.RED);
		g.drawRect((int) x-3,(int)y-10,6,20);
	}
	
	 public boolean outCheck() {
		 if(y<0) {
			 return true;
		 }
		 return false;
	 }
}
