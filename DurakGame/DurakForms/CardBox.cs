/**
 * 
 * Name: Purab Barot 
 * ID: 100642651
 * Date: March 15,2019
 * 
 * Ref
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial8;

namespace CardBox
{

    public partial class CardBox: UserControl
    {

        #region  FIELDS AND PROPERTIES

        private PlayingCard myCard;
        /// <summary>
        /// Playing Card: sets/gets theunderlying card object
        /// </summary>
        public PlayingCard Card
        {
            set
            {
                myCard = value;
                UpdateCardImage(); // update the card image
            }
            get { return myCard; }
        }

        /// <summary>
        /// Suit Property: ssts/gets the underlying Card objects Suit
        /// </summary>
        public CardSuit Suit
        {
            set
            {
                Card.Suit = value;
            }
            get { return Card.Suit; }
        }

        /// <summary>
        /// Rank property: sets/ gets the  underlying Card object's Rank
        /// </summary>
        public CardRank Rank
        {
            set
            {
                Card.Rank = value;
            }
            get { return Card.Rank; }
        }

        /// <summary>
        /// FaceUp property: sets/gets the underlying Card objects FaceUp Property
        /// </summary>
        public bool FaceUp
        {
            set
            {
                //if value is different than the underlying card's FaceUp property
                if(myCard.FaceUp != value) // then the card is flipping iver
                {
                    myCard.FaceUp = value; // change the card's FaceUp property

                    UpdateCardImage(); // update the card image(back or front)

                    //if there is an event handler for the CArdFlipped in the client program
                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs()); // call it
                }
            }
            get { return Card.FaceUp; }
        }

        /// <summary>
        /// CardOrientation Property: sets / gets the orientation of the card 
        /// if setting this property changes the state of control, 
        /// swaps the height and width of the control and updates the image.
        /// </summary>
        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                if(myOrientation != value)
                {
                    myOrientation = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage(); // update the card image
                }
            }
            get { return myOrientation; }
        }

        /// <summary>
        /// UpdateCardImage Helper Method: Sets the Picturebox image using the underlying card and the orientation
        /// </summary>
        private void UpdateCardImage()
        {
            //set tje image using the underlying card
            pbMyPictureBox.Image = myCard.GetCardImage();

            //if the orientation is horizontal
            if(myOrientation == Orientation.Horizontal)
            {
                //rotate the image
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        #endregion

        #region  CONSTRUCTORS
        /// <summary>
        /// Constructor: Constructs the control with a new card, oriented vertically.
        /// </summary>
        public CardBox()
        {
            InitializeComponent();   // required method for designer support
            myOrientation = Orientation.Vertical;  // set the orientation to vertical
            Card = new PlayingCard(); // CREATE A NEW UNDERLYING CARD

        }

        /// <summary>
        /// Construtor (PlayingCard, Orientation): Construct the cpopntrol using parameters.
        /// </summary>
        /// <param name="card"></param>
        /// <param name="orientation"></param>
         public CardBox(PlayingCard card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();   //required method for designer support
            myOrientation = orientation;  // set the orientation
            myCard = card; // set the underlying card.
        }

        #endregion

        #region  EVENTS AND EVENT HANDLERS

        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();   // update the card
        }

        /// <summary>
        /// An event the client program can handle when the card flips face up/down
        /// </summary>
        public event EventHandler CardFlipped;

        /// <summary>
        /// An event thec lient program can handle when the user clicks the control
        /// </summary>
        new public event EventHandler Click;

        /// <summary>
        /// An event handler for the user clikcing the picturebox control
        /// </summary>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {

            if (Click != null)  // if there is a handler for clicking the control in the cklient program
                Click(this, e); //call it
        }

        #endregion

        #region OTHER METHDOS

        /// <summary>
        /// ToString: overrides system.object.ToString()
        /// </summary>
        /// <returns> the name of the card as a string</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }
        #endregion

        
    }
}
