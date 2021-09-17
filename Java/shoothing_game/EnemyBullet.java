import java.awt.*;
import java.awt.event.*;

public class EnemyBullet extends GameObject{
	
	public EnemyBullet(double ix,double iy) {
		x=ix;
		y=iy;
	}

	public void move() {
		y+=5;
	}
	
	public void draw(Graphics g) {
		g.setColor(Color.BLUE);
		g.drawRect((int) x-3,(int)y-3,6,6);
	}
	
	 public boolean outCheck() {
		 if(y>=500) {
			 return true;
		 }
		 return false;
	 }
}

