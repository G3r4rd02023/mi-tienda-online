﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace TiendaOnline.Helpers
{
	public interface ICombosHelper
	{
        Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync();

        Task<IEnumerable<SelectListItem>> GetComboCountriesAsync();

        Task<IEnumerable<SelectListItem>> GetComboStatesAsync(int countryId);

        Task<IEnumerable<SelectListItem>> GetComboCitiesAsync(int stateId);

    }
}
