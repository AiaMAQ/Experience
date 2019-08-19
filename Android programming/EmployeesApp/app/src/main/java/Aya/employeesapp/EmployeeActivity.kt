package Aya.employeesapp

import android.annotation.SuppressLint
import android.content.Intent
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.support.v7.widget.RecyclerView
import android.view.View
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import com.bumptech.glide.Glide
import com.bumptech.glide.Glide.init
import kotlinx.android.synthetic.main.activity_employee.*
import kotlinx.android.synthetic.main.activity_employee.nameTextView
import kotlinx.android.synthetic.main.activity_employee.titleTextView
import kotlinx.android.synthetic.main.employee_item.*
import kotlinx.android.synthetic.main.employee_item.view.*
import org.json.JSONObject
import kotlinx.android.synthetic.main.activity_employee.departmentTextView as departmentTextView1
import kotlinx.android.synthetic.main.activity_employee.emailTextView as emailTextView1
import kotlinx.android.synthetic.main.activity_employee.imageview as imageview1
import kotlinx.android.synthetic.main.employee_item.phoneTextView as phoneTextView1

class EmployeeActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_employee)


        val bundle: Bundle? = intent.extras;
        if (bundle != null) {
            val employeeString = bundle.getString("employee")
            val employee = JSONObject(employeeString)
            val name = employee["firstName"]


            nameTextView.text = employee["firstName"].toString() + "" + employee["lastName"].toString()
            titleTextView.text = employee["title"].toString()
            emailTextView.text = employee["email"].toString()
            phoneTextView.text = employee["phone"].toString()
            departmentTextView.text = employee["department"].toString()
            Glide.with(this).load(employee["image"]).into(imageview)




            Toast.makeText(this, "Name is $name",Toast.LENGTH_LONG).show()
        }



        }
    }


