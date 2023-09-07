using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bharatplantdesktop.Utils
{
    public partial class SuggestionListUserControl : UserControl
    {
        public SuggestionListUserControl()
        {
            InitializeComponent();
        }
        public void PopulateSuggestions(List<string> suggestions)
        {
            // Clear the existing suggestions
            listBoxSuggestions.Items.Clear();

            // Add new suggestions to the ListBox
            listBoxSuggestions.Items.AddRange(suggestions.ToArray());

            // Show or hide the UserControl based on whether there are suggestions
            this.Visible = suggestions.Count > 0;

            // Set the height of the UserControl based on the number of suggestions (optional)
            int suggestedItemsCount = suggestions.Count;
            int maxVisibleItems = 40; // You can adjust this based on your design
            int itemHeight = listBoxSuggestions.ItemHeight;
            int maxHeight = maxVisibleItems * itemHeight;
            int suggestedHeight = Math.Min(suggestedItemsCount, maxVisibleItems) * itemHeight;
            this.Height = suggestedHeight;
        }

        public string SelectedSuggestion
        {
            get
            {
                // Return the selected suggestion from the ListBox
                if (listBoxSuggestions.SelectedIndex >= 0)
                {
                    return listBoxSuggestions.SelectedItem.ToString();
                }
                return null;
            }
        }
    }
}
