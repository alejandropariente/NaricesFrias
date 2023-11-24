using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Narices_Frias.Pages
{
    public partial class CharitableActivitiesCatalogue : System.Web.UI.Page
    {
        CharitableActivitiesImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            impl = new CharitableActivitiesImpl();
            Select();
        }
        void Select()
        {
            List<CharitableActivities> post = impl.Select();
            foreach (CharitableActivities activity in post) 
            {
                cataloguePanel.Controls.Add(CreateCard(activity,impl.GetPhotos(activity.id)));
            }
        }
        Panel CreateCard(CharitableActivities info , List<string>photos)
        {
            Panel panel = new Panel();
            Panel imagesPanel = new Panel();
            panel.CssClass = "post";
            Label title = new Label();
            title.CssClass = "title";
            Label description = new Label();
            Label date = new Label();
            date.CssClass = "date";
            Image[] images = new Image[photos.Count];
            title.Text = info.name;
            description.Text = info.description;
            date.Text = info.date.ToString();
            panel.Controls.Add(title);
            panel.Controls.Add(description);
            panel.Controls.Add(date);
            for (int i = 0; i < photos.Count; i++)
            {
                images[i] = new Image();
                images[i].ImageUrl = photos[i];
                imagesPanel.Controls.Add(images[i]);
            }
            panel.Controls.Add(imagesPanel);
            return panel;
        }
    }
}