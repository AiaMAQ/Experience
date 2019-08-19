package Aya.showgolfcoursesinmap

import  android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.widget.ImageView
import android.widget.TextView
import com.bumptech.glide.Glide
import com.bumptech.glide.request.RequestOptions
import com.google.android.gms.maps.GoogleMap
import com.google.android.gms.maps.model.Marker
import kotlinx.android.synthetic.main.course_item.view.*

class CustomInfoWindowAdapter(private  val mContext: Context): GoogleMap.InfoWindowAdapter {

    private val mWindow: View

    init {
        mWindow = LayoutInflater.from(mContext).inflate(R.layout.custom_info,  null)
    }
    private fun rendoWindowText(marker: Marker, view: View){
        val title = marker.title
        val tvTitle = view.findViewById<View>(R.id.title) as  TextView

        if (title != ""){
            tvTitle.text =title
        }

        val snippet = marker.snippet
        val tvSnippet = view.findViewById<View>(R.id.snippet) as TextView


        if (snippet != ""){
            tvSnippet.text = snippet
        }
    }

    override fun getInfoWindow(marker: Marker): View {
        rendoWindowText(marker, mWindow)
        return mWindow
    }

    override fun getInfoContents(marker: Marker): View {
        rendoWindowText(marker , mWindow)
        return mWindow
    }

}