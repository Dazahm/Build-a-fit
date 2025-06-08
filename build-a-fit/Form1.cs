namespace build_a_fit
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_upload(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Display image before submission
                pictureBox1.Image = new Bitmap(filePath);
                // Prompt user for categorization details
                string color = Microsoft.VisualBasic.Interaction.InputBox("Enter color:", "Clothing color", "Red");
                string style = Microsoft.VisualBasic.Interaction.InputBox("Enter Style:", "Clothing Style", "Casual");
                string type = Microsoft.VisualBasic.Interaction.InputBox("Enter Type:", "Clothing Type", "T-Shirt");
                string season = Microsoft.VisualBasic.Interaction.InputBox("Enter Season:", "Clothing Season", "Fall");
                string occasion = Microsoft.VisualBasic.Interaction.InputBox("Enter Occasion:", "Clothing Occasion", "Wedding");

                // Create a categorized clothing item
                WardrobeItem newItem = WardrobeItem.CreateWardrobeItem(filePath, type,style, occasion, season, color);

                // Store in a list or database (Example: Adding to a list)
                Wardrobe myWardrobe = new Wardrobe(); //Create an instance
                myWardrobe.AddItem(newItem);  //Use the instance to add items

                MessageBox.Show("Image categorized successfully!");
                // Confirmation dialog
                var result = MessageBox.Show("Do you want to proceed with this image?", "Confirm Upload", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Mark image as submitted
                    isImageSubmitted = true;
                    MessageBox.Show("Image uploaded successfully!");
                }
                else
                {
                    isImageSubmitted = false; // Ensure submission is required
                    MessageBox.Show("Please select a valid image before proceeding.");
                }
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_next(object sender, EventArgs e)
        {

            if (isImageSubmitted)
            {
                // Move to the next tab only if the image has been submitted
                if (tabControl1.SelectedIndex < tabControl1.TabPages.Count - 1)
                {
                    tabControl1.SelectedIndex++;
                }
                else
                {
                    MessageBox.Show("You are at the last step!", "Navigation Alert");
                }
            }
            else
            {
                MessageBox.Show("You must submit a valid image before proceeding!", "Action Required");
            }
        }
    }
}