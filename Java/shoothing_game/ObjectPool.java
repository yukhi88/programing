import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
/**
*ゲームオブジェクトの管理クラス<p>
*プレイヤーや弾、敵などのインスタンスを持ち<p>
*オブジェクト同士の相互作用（衝突処理など）を一括管理する。
*/
public class ObjectPool
{
	Player player;
	ArrayList<MyBullet> mybullet;
	ArrayList<Enemy> enemy;
	ArrayList<EnemyBullet> enemybullet;
	static final int DIST = 16;
	/**
	 * コンストラクタ
	 */
	ObjectPool()
	{
		player = new Player(250,400,5);
		mybullet=new ArrayList<MyBullet>();
		enemy=new ArrayList<Enemy>();
		enemybullet=new ArrayList<EnemyBullet>();
	}
	
	public void objectMove(ArrayList<? extends GameObject> obj ,Graphics g) {
		obj.removeIf(go->go.outCheck());
		for(GameObject go:obj) {
			go.move();
			go.draw(g);
		}
	}

	/**
	 * 描画処理。すべてのゲームオブジェクトを描画する。
	 */
	public void drawAll(Graphics g)
	{
		//自分の弾
		objectMove(mybullet, g);
		//敵
		objectMove(enemy,g);
		//プレイヤー
		player.draw(g);
		//敵の弾
		objectMove(enemybullet,g);
		}
	
	public void movePlayer(int x , int y) {
		player.move(x,y);
	}
	
	public void shotPlayer() {
		if(player.active&&mybullet.size()<5) {
			mybullet.add(new MyBullet(player.x,player.y));
		}
	}
	public void newEnemy() {
		enemy.add(new Enemy(player.x));
	}

	public void newEnemyBullet() {
		for(Enemy en:enemy) {
			if(en.counter%20==0) {
				enemybullet.add(new EnemyBullet(en.x,en.y));
			}
		}
	}
	//gaとgbの2点間の距離を計測する
		public double getDistance(GameObject ga, GameObject gb) {
			double Xdiff = Math.abs(ga.x - gb.x);
			double Ydiff = Math.abs(ga.y - gb.y);
			return Math.sqrt( Math.pow(Xdiff, 2) + Math.pow(Ydiff, 2) );
		}

		//getDistanceメソッドで測った距離から衝突を判定する
		public void getColision() {
			//敵とプレイヤーの当たり判定
			for(Enemy en : enemy) {
				if ( getDistance(en, player) < DIST ) {
					player.active = false;
				}
			}

			//--------------------------------------------
			//敵と弾の当たり判定
			//--------------------------------------------
			for(int i = 0; i < enemy.size(); i++ ) {		//敵ループ
				for(int j = 0; j < mybullet.size(); j++ ) {	//弾ループ
					if( getDistance( enemy.get(i), mybullet.get(j) ) < DIST ) {
						if( enemy.get(i).hit() ) enemy.remove(i); //敵の削除
						mybullet.remove(j); //弾の削除
						break;
					}				
				}
			}

			//--------------------------------------------
			//敵の弾とプレイヤーの当たり判定
			//--------------------------------------------
			for(int i = 0; i < enemybullet.size(); i++ ) {	//弾ループ
				if( getDistance( enemybullet.get(i), player ) < DIST ) {
					player.active = false;
					enemybullet.remove(i);  //弾をリストから削除
					break;
				}				
			}
		
		}
		
		public boolean isGameover() {
			return player.active;
		}

}
