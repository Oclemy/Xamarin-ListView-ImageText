using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Util;

namespace ListView_ImageText
{
    [Activity(Label = "ListView_ImageText", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private CustomAdapter adapter;
        private ListView lv;
        private List<Player> players;
 
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            lv = FindViewById<ListView>(Resource.Id.lv);
            adapter=new CustomAdapter(this,Resource.Layout.model,GetPlayers());

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,players[e.Position].Name,ToastLength.Short).Show(); 
        }

        private List<Player> GetPlayers()
        {
            players = new List<Player>()
            {
               new Player("David De Gea",Resource.Drawable.degea),
                new Player("Juan Mata",Resource.Drawable.mata),
                new Player("Ander Herera",Resource.Drawable.herera),
                new Player("Eden Hazard",Resource.Drawable.hazard),
                new Player("John Terry",Resource.Drawable.terry),
                new Player("Michael Carrick",Resource.Drawable.carrick)

            };

            return players;
        }
    }
}

