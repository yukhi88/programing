import java.awt.*;
import java.awt.event.*;
import java.util.Random;

/**
*描画先コンポーネントクラス(Canvasを継承)<p>
*メインループもここ
*/
public class MyCanvas extends Canvas implements Runnable{
	ObjectPool objectpool;
	Image imgBuf;
	Graphics gBuf;
	KeyInput keyinput;
	
	int counter;

	/**
	 * コンストラクタ
	 */
	MyCanvas()
	{
		//キーリスナー実装
		keyinput=new KeyInput();
		addKeyListener(keyinput);
		setFocusable(true);
	}

	/**
	 * 初期化処理<p>
	 * アプリケーションの開始時、またはリスタート時に呼ばれ、<br>
	 * ゲーム内で使われる変数の初期化を行う。
	 */
	public void init()
	{
		objectpool = new ObjectPool();
	}
	
	/**
	 * 外部からスレッドを初期化する。
	 */
	public void initThread()
	{
		Thread thread = new Thread(this);
		thread.start();
	}
	
	/**
	 * 描画処理<p>
	 * repaint()の際に呼ばれて、
	 * オフスクリーンバッファから画像をコピーし表示する。
	 * @param g 描画先グラフィックハンドル
	 */
	public void paint(Graphics g)
	{
		g.drawImage(imgBuf, 0, 0, this);
	}

	/**
	 * 画面をいちいちクリアしないようにするため、
	 * updateメソッドをオーバーライドする。
	 * @param g 更新先グラフィックハンドル
	 */
	public void update(Graphics g)
	{
		paint(g);
	}

	/**
	 * ゲーム画面のメイン処理
	 */
	void gameMain()
	{
		//ゲームオブジェクトの一括描画処理
		objectpool.drawAll(gBuf);
		
		objectpool.movePlayer(keyinput.getXDirection(),keyinput.getYDirection());
		if(keyinput.checkShotKey() && counter %3==0) {
			objectpool.shotPlayer();
		}
		if(counter%100==0) {
			objectpool.newEnemy();
		}
		objectpool.newEnemyBullet();
		objectpool.getColision();
		
		if(!objectpool.isGameover())
			init();
	}
	
	
	/**
	 * メインループ
	 */
	public void run()
	{
		//オフスクリーンバッファ作成
		imgBuf = createImage(500, 500);
		gBuf = imgBuf.getGraphics();
		
		for(counter = 0; ; counter++)
		{
			//バッファをクリア
			gBuf.setColor(Color.white);
			gBuf.fillRect(0, 0, 500, 500);

			gameMain();

			//再描画を要求
			repaint();
			
			try{
				Thread.sleep(20);				//ループのウェイト
			}
			catch(InterruptedException e)
			{}
		}
	}
}
