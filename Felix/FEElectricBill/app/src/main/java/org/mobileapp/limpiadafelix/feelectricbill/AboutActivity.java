package org.mobileapp.limpiadafelix.feelectricbill;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class AboutActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_about);
    }
    public void navigateToMainScreen(View v){
        Intent i = new Intent(this, MainActivity.class);
        startActivity(i);
    }
}