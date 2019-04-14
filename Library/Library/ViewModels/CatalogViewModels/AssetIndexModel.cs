using System;
using System.Collections.Generic;
using System.Text;

namespace Library.ViewModels.CatalogViewModels
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> assets { get; set; }
    }
}
