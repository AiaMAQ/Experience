package com.example.launchmap

import android.content.Intent
import android.net.Uri
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.android.synthetic.main.activity_main.view.*
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import android.content.pm.PackageManager
import android.content.pm.ResolveInfo

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        val btn = button.button

        btn.setOnClickListener {
            val lat = latEditText.text.toString().toDouble()
            val lng = lngEditText.text.toString().toDouble()

            val location = Uri.parse("geo:$lat,$lng")
            val mapIntent = Intent (Intent.ACTION_VIEW, location)

            val activities: List<ResolveInfo> = packageManager.queryIntentActivities(mapIntent, 0)
            val isIntentSafe: Boolean = activities.isNotEmpty()

            if (isIntentSafe) {
                startActivity(mapIntent)
            } else {
                Toast.makeText(this, "There is no activity to handle map intent!", Toast.LENGTH_LONG).show();
            }
        }
    }
}
