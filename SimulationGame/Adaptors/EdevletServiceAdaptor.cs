using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entity;
using GameDemo.Abstract;


namespace GameDemo.Adaptors
{
    public class EdevletServiceAdaptor : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            EdevletServiceReference.KPSPublicSoap client = new EdevletServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(player.IdentityNum, player.FirstName.ToUpper(), player.LastName.ToUpper(), player.BirthYear);
        }
    }
}
