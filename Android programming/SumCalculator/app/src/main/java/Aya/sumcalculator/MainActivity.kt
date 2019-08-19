package Aya.sumcalculator

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val edt1 = findViewById(R.id.ed1) as EditText
        val edt2 = findViewById(R.id.ed2) as EditText
        val result = findViewById(R.id.tv_result) as TextView
        val btnadd = findViewById(R.id.btn_add) as Button

        btnadd.setOnClickListener {
            val a: String = edt1.text.toString()
            val b: String = edt2.text.toString()

            if (edt1.text.isEmpty() && edt2.text.isEmpty()) {
                Toast.makeText(applicationContext, "Enter the Value", Toast.LENGTH_SHORT).show()
            } else {
                val c = a.toInt()
                val d = b.toInt()
                val e = c + d
                result.setText(e.toString())
            }
        }
    }
}
