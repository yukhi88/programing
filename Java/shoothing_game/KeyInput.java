import java.awt.*;
import java.awt.event.*;

public class KeyInput extends KeyAdapter {

	private boolean keyup;
	private boolean keydown;
	private boolean keyleft;
	private boolean keyright;
	private boolean keyspace;
	
	public KeyInput() {
		
		keyup=keydown=keyleft=keyright=false;
	}
	public void keyPressed(KeyEvent e) {
		if(e.getKeyCode()==KeyEvent.VK_UP||e.getKeyCode()==KeyEvent.VK_W) {
			keyup=true;
		}
		if(e.getKeyCode()==KeyEvent.VK_DOWN||e.getKeyCode()==KeyEvent.VK_S) {
			keydown=true;
		}
		if(e.getKeyCode()==KeyEvent.VK_LEFT||e.getKeyCode()==KeyEvent.VK_A) {
			keyleft=true;
		}
		if(e.getKeyCode()==KeyEvent.VK_RIGHT||e.getKeyCode()==KeyEvent.VK_D) {
			keyright=true;
		}
		if(e.getKeyCode()==KeyEvent.VK_SPACE||e.getKeyCode()==KeyEvent.VK_ENTER) {
			keyspace=true;
		}
	}
	
	public void keyReleased (KeyEvent e) {
		if(e.getKeyCode()==KeyEvent.VK_UP||e.getKeyCode()==KeyEvent.VK_W) {
			keyup=false;
		}
		if(e.getKeyCode()==KeyEvent.VK_DOWN||e.getKeyCode()==KeyEvent.VK_S) {
			keydown=false;
		}
		if(e.getKeyCode()==KeyEvent.VK_LEFT||e.getKeyCode()==KeyEvent.VK_A) {
			keyleft=false;
		}
		if(e.getKeyCode()==KeyEvent.VK_RIGHT||e.getKeyCode()==KeyEvent.VK_D) {
			keyright=false;
		}
		if(e.getKeyCode()==KeyEvent.VK_SPACE||e.getKeyCode()==KeyEvent.VK_ENTER) {
			keyspace=false;
		}
	}
	
	public int getXDirection() {
		if(keyleft) {
			return -1;
		}
		if(keyright) {
			return 1;
		}
		return 0;
	}
	public int getYDirection() {
		if(keyup) {
			return -1;
		}
		if(keydown) {
			return 1;
		}
		return 0;
	}
	
	public boolean checkShotKey(){
		return keyspace;
	}
}
