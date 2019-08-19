package Aya.roomshoppinglist

import android.arch.persistence.room.Entity
import android.arch.persistence.room.PrimaryKey
import android.os.Parcel
import android.os.Parcelable

@Entity(tableName = "shopping_list_table")
data class ShoppingListItem(
    @PrimaryKey(autoGenerate = true)
    var id: Int,
    var name: String?,
    var count: Int?,
    var price: Double?

)
