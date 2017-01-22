using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListView_ImageText
{
    internal class CustomAdapter : ArrayAdapter
    {

        private Context c;
        private List<Player> players;
        private int resource;
        private LayoutInflater inflater;

        public CustomAdapter(Context context, int resource, List<Player> objects) : base(context, resource, objects)
        {
            this.c = context;
            this.resource = resource;
            this.players = objects;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (inflater == null)
            {
                inflater = (LayoutInflater) c.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = inflater.Inflate(resource, parent, false);

            }

            //BIND DATA
            MyHolder holder=new MyHolder(convertView);
            holder.NameTxt.Text = players[position].Name;
            holder.Img.SetImageResource(players[position].Image);

            convertView.SetBackgroundColor(Color.LightGreen);


            return convertView;
        }
    }
}