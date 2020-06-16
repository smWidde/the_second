using System;
using System.Text;
using System.Web.ModelBinding;
namespace the_second
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Hotel hotel;
        protected void Page_Load(object sender, EventArgs e)
        {
            SetHotel();
            if (IsPostBack)
            {
                GuestResponse rsvp = new GuestResponse();
                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponseRepository.GetRepository().AddResponse(rsvp);
                    if(rsvp.ChosenRoomNumber!=null&&rsvp.FIO!=null&&rsvp.PhoneNumber!=null)
                    {
                        hotel.SetRoomAvailability(rsvp.ChosenRoomNumber, false);
                        Response.Redirect("ok.html");
                    }
                }
            }
        }
        protected void SetHotel(int num_of_rooms=30)
        {
            hotel = Hotel.GetHotel();
            if (hotel.Rooms.Count == 0)
            {
                for(int i=0; i< num_of_rooms; i++)
                {
                    hotel.AddRoom(i.ToString(), true, 1000);
                }
            }
        }
        public string ShowHotelRooms()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\t<tr>\n");
            string cls;
            string func;
            for(int i=0; i<hotel.Rooms.Count; i++)
            {
                if(i%10==0&&i!=0)
                {
                    sb.Append("\t</tr>\n");
                    sb.Append("\t<tr>\n");
                }
                sb.Append($"\t\t<td id=\'room_cell_{i}\'>\n");
                if(hotel.Rooms[i].IsAvailable)
                {
                    cls = "empty";
                    func = $"onclick=\"Choose(\'room_cell_{i}\')\"";
                }
                else
                {
                    cls = "occupied";
                    func = "";
                }
                sb.Append($"\t\t\t<input type=\"button\" class=\"room {cls}\" value=\"{hotel.Rooms[i].Number}\"; {func} runat=\"server\"/>\n");
                sb.Append($"\t\t</td>\n");
            }
            sb.Append("\t</tr>\n");
            return sb.ToString();
        }
    }
}