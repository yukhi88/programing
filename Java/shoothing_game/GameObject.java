import java.awt.*;
import java.awt.event.*;


public abstract class GameObject {
	
	public boolean active;
	public double x;
	public double y;
	
	//移動処理
	abstract public void move() ;
	
	//描画処理
	abstract public void draw(Graphics g) ;
	
	abstract boolean outCheck();
}
