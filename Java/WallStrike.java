
//WallStrike.java

import java.awt.Toolkit;
import java.time.Instant;
import java.util.Random;

import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.application.Application;
import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Alert;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.Menu;
import javafx.scene.control.MenuBar;
import javafx.scene.control.MenuItem;
import javafx.scene.input.KeyCode;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.Border;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.BorderStroke;
import javafx.scene.layout.BorderStrokeStyle;
import javafx.scene.layout.BorderWidths;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;
import javafx.stage.StageStyle;
import javafx.util.Duration;

public class WallStrike extends Application {

	final int WIDTH = 400;
	final int HEIGHT = 300;
	final int RADIUS = 10;
 
	Circle ball = new Circle(WIDTH/ 2.0, 40, RADIUS, Color.BLUE);
	Rectangle racket = new Rectangle(35,5, Color.BLACK);
	
	Rectangle[] block=new Rectangle[10];
 
 double cx = 0; // ボールの座標
 double cy = 0;
double dx=2;
double dy=7;

 Timeline timeline = null;
 int point = 0;
 
 Group root;

	public static void main(String[] args) {
		launch(args);
	}

 public void start(Stage stage) throws Exception {

     stage.setTitle("WallStrike");
     stage.initStyle(StageStyle.UTILITY);
     stage.setOnCloseRequest(event -> cleanup()); // ウィンドウが閉じるとき

     racket.setX((WIDTH - racket.getWidth()) / 2);
     racket.setY(250);

     cx = ball.getCenterX();
     cy = ball.getCenterY();
     
     //ブロックを作成
     for(int i=0;i<block.length;i++) {
     block[i]=new Rectangle(20,10,Color.BLACK);
     block[i].setX(10+(25*i));
     block[i].setY(10);
     }
     

     
     
     point = 0;
     root = new Group();
     final Canvas canvas = new Canvas(WIDTH, HEIGHT);

     canvas.setOnKeyPressed(event -> {
         if (event.getCode() == KeyCode.LEFT && (racket.getX()-10) >= 0)
             racket.setX(racket.getX() - 10);
         else if (event.getCode() == KeyCode.RIGHT && (racket.getX()+10)<=(WIDTH - 50))
             racket.setX(racket.getX() + 10);
     });
     canvas.setFocusTraversable(true);

     
     root.getChildren().addAll(canvas,racket, ball);
     
    for(int i=0;i<block.length;i++) {
    	 root.getChildren().add(block[i]);
    }
     
     stage.setScene(new Scene(root));
     stage.show();

     startGame(stage);
 }

 void startGame(Stage stage)
 {
	 timeline=new Timeline(new KeyFrame (Duration.millis(50),new EventHandler<ActionEvent>() {
		 public void handle(ActionEvent event) {
			 moveBall();
			 boundCheck(stage);
		 }
	 }));
	 timeline.setCycleCount(Timeline.INDEFINITE);
	 timeline.play();

 }


 void moveBall()
 {
	 cx+=dx;
	 cy+=dy;
	 ball.setCenterX(cx);
	 ball.setCenterY(cy);

 }

 void boundCheck(Stage stage)
 {

     if (cx < RADIUS + 2 || cx > WIDTH - RADIUS * 2.0 + 4) { // 左右の境界に衝突
         dx = -dx;
     }
     if (cy < RADIUS + 2) { // 上の境界に衝突
         dy = -dy * 1.05;  // 少し速くする
     }
     
     if(racket.intersects(ball.getBoundsInLocal())) {
    	 dy=-dy;
    	
     }
     //ボールとぶっろくが衝突した処理
     for(int i=0;i<block.length;i++) {
     if(block[i].intersects(ball.getBoundsInLocal())) {
    	 point++;
    	 dy=-dy;
    	//root.getChildren().remove(block[i]);			 //ブロックを画面から削除
    	 block[i].setY(1000);
    	//全部のブロックを消したらゲームクリア
    			if(point==block.length) {
    				gameEnd(stage);
    				cleanup();
    			}
     }
     }
     if (cy > HEIGHT - 2) { // 下の境界に衝突
         gameEnd(stage);
         cleanup();
     }
 }

 void gameEnd(Stage stage)
 {
     timeline.stop();
     timeline = null;
     Alert dlg = new Alert(AlertType.INFORMATION);
     dlg.setTitle("ゲームオーバー");
     dlg.setHeaderText(String.format("ゲームオーバー：得点=%d", point));
     dlg.initOwner(stage);
     dlg.show();
 }

 void cleanup()
 {
     // クリーンアップする
     if (timeline != null)
         timeline = null;
 }
}
