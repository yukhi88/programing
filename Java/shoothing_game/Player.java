import java.awt.*;
import java.awt.event.*;

public class Player extends GameObject  {
	
	protected double speed;
	
		//	コンストラクタ
	public Player(double ix,double iy,double ispeed) {
		x=ix;
		y=iy;
		speed=ispeed;
		active=true;
	}

	@Override
	public void move() {
		
		
	}

	@Override
	public void draw(Graphics g) {
		g.setColor(Color.red);
		//三角形の描画（始点と終点を結んで線を描く）
		g.drawLine((int) (x), (int)(y-14) , (int) (x-10), (int) (y+7));
		g.drawLine((int) (x), (int)(y-14) , (int) (x+10), (int) (y+7));
		g.drawLine((int) (x-10), (int)(y+7) , (int) (x+10), (int) (y+7));
	}
	 public void move(int  mx,int my) {
		 x=x+(mx*speed);
		 y=y+(my*speed);
	 }
	 
	 public boolean outCheck() {
		 return true;
	 }
	
}
