package com.hfad.cpsapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class DescriptionActivity extends MainActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_description);
    }

    public void startMainActivityOnClick(View view) {
        Intent intent = new Intent(DescriptionActivity.this, MainActivity.class);
        startActivity(intent);
    }
}