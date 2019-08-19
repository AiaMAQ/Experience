package Aya.appwidgetexercise

import Aya.appwidgetexercise.CoffeeLoggerPersistence
import android.appwidget.AppWidgetManager
import android.content.ComponentName
import android.content.Intent
import android.os.Bundle
import android.support.design.widget.CoordinatorLayout
import android.support.design.widget.Snackbar
import android.support.v7.app.AppCompatActivity
import android.view.View
import android.widget.TextView
import com.google.android.gms.ads.AdRequest
import com.google.android.gms.ads.MobileAds
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    internal val coffeeLoggerPersistence = CoffeeLoggerPersistence(this)
    private var today: Int = 0
    private var gramsValue: TextView? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        MobileAds.initialize(this,getString(R.string.coffeewidget_app_id))
        val adRequest = AdRequest.Builder().build()
        adView.loadAd(adRequest)


        gramsValue = findViewById<TextView?>(R.id.grams)
        refreshTodayLabel()
        if (intent != null && intent.action == Constants.ADD_COFFEE_INTENT) {
            val coffeeIntake = intent.getIntExtra(Constants.GRAMS_EXTRA, 0)
            coffeeLoggerPersistence.saveTitlePref(today + coffeeIntake)
            saveCoffeeIntake(coffeeIntake)
        }
    }

    fun onRistrettoPressed(v: View) {
        coffeeLoggerPersistence.saveTitlePref(today + CoffeeTypes.RISTRETTO.grams)
        saveCoffeeIntake(CoffeeTypes.RISTRETTO.grams)
    }

    fun onEspressoPressed(v: View) {
        coffeeLoggerPersistence.saveTitlePref(today + CoffeeTypes.ESPRESSO.grams)
        saveCoffeeIntake(CoffeeTypes.ESPRESSO.grams)
    }

    fun onLongPressed(v: View) {
        coffeeLoggerPersistence.saveTitlePref(today + CoffeeTypes.LONG.grams)
        saveCoffeeIntake(CoffeeTypes.LONG.grams)
    }

    fun refreshTodayLabel() {
        // Send a broadcast so that the Operating system updates the widget
        val man = AppWidgetManager.getInstance(this)
        val ids = man.getAppWidgetIds(ComponentName(this, CoffeeLoggerWidget::class.java))
        val updateIntent = Intent(AppWidgetManager.ACTION_APPWIDGET_UPDATE)
        updateIntent.putExtra(AppWidgetManager.EXTRA_APPWIDGET_IDS, ids)
        sendBroadcast(updateIntent)

        today = coffeeLoggerPersistence.loadTitlePref()
        gramsValue?.text = today.toString()
    }

    private fun saveCoffeeIntake(intake: Int) {
        val mySnackbar = Snackbar.make(findViewById<CoordinatorLayout>(R.id.main_coordinator),
            R.string.intake_saved, Snackbar.LENGTH_LONG)
        mySnackbar.setAction(R.string.undo_string, MyUndoListener(intake))
        mySnackbar.show()

        refreshTodayLabel()
    }

    inner class MyUndoListener(private val intake: Int) : View.OnClickListener {
        override fun onClick(v: View) {
            coffeeLoggerPersistence.saveTitlePref(today - intake)
            refreshTodayLabel()
        }

    }
}
