package com.hfad.cpsapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void startActivityOnClick(View view) {
        Intent intent = new Intent(MainActivity.this, Choose_Activity.class);
        startActivity(intent);
    }

    public void startActivityDescriptionOnClick(View view) {
        Intent intent = new Intent(MainActivity.this, DescriptionActivity.class);
        startActivity(intent);
    }
}