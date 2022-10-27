namespace Library
{
    public class OfertasSegunReputacion
    {
        public string Oferta { get; set; }
        public void OfertasSegunReputacion()
        {
            if (Reputacion == 5)
            {
                Oferta = "Oferta 1";
            }
            else if (Reputacion == 4)
            {
                Oferta = "Oferta 2";
            }
            else if (Reputacion == 3)
            {
                Oferta = "Oferta 3";
            }
            else if (Reputacion == 2)
            {
                Oferta = "Oferta 4";
            }
            else if (Reputacion == 1)
            {
                Oferta = "Oferta 5";
            }
        }
    }
}