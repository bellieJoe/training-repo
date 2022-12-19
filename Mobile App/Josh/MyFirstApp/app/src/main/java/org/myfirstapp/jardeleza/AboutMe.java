package org.myfirstapp.jardeleza;


import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;


public class AboutMe extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_about_me);
    }

    public void navigateToMainScreen(View v) {
        Intent i = new Intent(this, MainScreen.class);
        startActivity(i);
    }
}