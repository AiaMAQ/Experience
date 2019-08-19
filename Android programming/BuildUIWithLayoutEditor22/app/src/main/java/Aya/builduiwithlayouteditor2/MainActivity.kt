package Aya.builduiwithlayouteditor2

import android.annotation.SuppressLint
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.TextView
import kotlinx.android.synthetic.main.activity_main.*
import org.w3c.dom.Text

class MainActivity : AppCompatActivity() {

    val firstnames = arrayOf("Renato", "Rosangela", "Tim", "Bartol", "Jeannette")
    val lastnames = arrayOf("Ksenia", "Metzli", "Asuncion", "Zemfina", "Giang")
    val jobtitles = arrayOf("District Quality Coordinator","International Intranet Representative","District Intranet Administrator","Dynamic Research Manager","Central Infrastructure Consultant")

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        // show first employee data
        showEmployeeData (0);
    }

    // function displays employees data in UI
    @SuppressLint("SetTextI18n")
    fun showEmployeeData(index: Int) {
        textView.text = firstnames[index]
        textView2.text = lastnames[index]
        textView3.text = jobtitles[index]
        textView4.text = lastnames[index] + " " + firstnames[index] + " is ...." + "is simply dumy text of the printing and typesetting in ...";
        // image
        var id = 0
        if (index == 0) id = R.drawable.employee1
        else if (index == 1) id = R.drawable.employee2
        else if (index == 2) id = R.drawable.employee3
        else if (index == 3) id = R.drawable.employee4
        else if (index == 4) {
            id = R.drawable.employee5
        }
        imageView.setImageResource(id)
    }
    fun numberClicked(view: View?) {
        val text = (view as TextView).text.toString()
        val int = text.toInt() - 1 // array is starting from zero position
        showEmployeeData(int)
    }




}
