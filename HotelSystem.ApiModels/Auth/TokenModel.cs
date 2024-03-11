using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.ApiModels.Auth
{
    /// <summary>
    /// Класс модели, представляющий токен.
    /// Он включает свойства для токена доступа и токена обновления.
    /// </summary>
    public class TokenModel
    {
        public string? AcessToken { get; set; }       
        public string? RefreshToken { get; set; }
    }
}
