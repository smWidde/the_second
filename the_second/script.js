var isFirst = true;
function Choose(td_id)
{
    if (isFirst != true)
    {
        document.getElementById("chosen").id = "";
    }
    else
    {
        isFirst = false;
    }
    document.getElementById(td_id).childNodes[1].id = "chosen";
    document.getElementById("chosenroomnumber").value = document.getElementById("chosen").value;
}