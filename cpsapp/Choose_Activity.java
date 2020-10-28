package com.hfad.cpsapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Choose_Activity extends MainActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_choose_);
    }

    public void startWorkActivity1OnClick(View view) {
        Intent intent = new Intent(Choose_Activity.this, WorkActivity1.class);
        startActivity(intent);
    }

    public void startWorkActivity2OnClick(View view) {
        Intent intent = new Intent(Choose_Activity.this, WorkActivity2.class);
        startActivity(intent);
    }

    public void startWorkActivity3OnClick(View view) {
        Intent intent = new Intent(Choose_Activity.this, WorkActivity3.class);
        startActivity(intent);
    }

    public void startWorkActivity4OnClick(View view) {
        Intent intent = new Intent(Choose_Activity.this, WorkActivity4.class);
        startActivity(intent);
    }
}