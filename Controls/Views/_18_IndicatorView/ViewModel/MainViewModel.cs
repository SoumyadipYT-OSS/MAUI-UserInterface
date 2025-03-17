using System.Collections.ObjectModel;
using _18_IndicatorView.Model;

namespace _18_IndicatorView.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<MobileBrand> MobileBrands { get; set; }

        public MainViewModel() {
            MobileBrands = [
                new ("Motorola", "Moto G100", "8 GB", "128 GB", "Snapdragon 870", "https://www.notebookcheck.net/typo3temp/_processed_/1/1/csm_4_zu_3_moto_g100_e1fdf991e2.jpg"),
                new ("Motorola", "Moto Edge 20", "6 GB", "128 GB", "Snapdragon 778G", "https://www.notebookcheck.net/uploads/tx_nbc2/MotorolaEdge20__1_.jpg"),
                new ("Lava", "Z6", "6 GB", "64 GB", "MediaTek Helio G35", "https://fdn2.gsmarena.com/vv/pics/lava/lava-z6-2.jpg"),
                new ("Lava", "Agni 5G", "8 GB", "128 GB", "MediaTek Dimensity 810", "https://www.91-cdn.com/hub/wp-content/uploads/2021/11/Lava-Agni-5G-featured-image.jpg"),
                new ("Sony", "Xperia 1 III", "12 GB", "256 GB", "Snapdragon 888", "https://static1.xdaimages.com/wordpress/wp-content/uploads/2021/04/Xperia-1-III-featured.jpg"),
                new ("Sony", "Xperia 5 II", "8 GB", "128 GB", "Snapdragon 865", "https://www.chooseyourmobile.com/wp-content/uploads/2020/09/Sony-Xperia-5-II-Grey-Black-Blue-Colors-Image-1024x682.jpg"),
                new ("Micromax", "IN Note 1", "4 GB", "64 GB", "MediaTek Helio G85", "https://techsathi.com/wp-content/uploads/2021/03/Micromax-IN-Note-1.jpg"),
                new ("Micromax", "IN 2b", "4 GB", "64 GB", "Unisoc T610", "https://www.gizchina.com/wp-content/uploads/images/2021/07/micromax-in-2b-1.jpg"),
                new ("Samsung", "Galaxy S21", "8 GB", "256 GB", "Exynos 2100", "https://cdn.mos.cms.futurecdn.net/RJ5nuSLthP386djPzyvqwX.jpg"),
                new ("Samsung", "Galaxy Note 20", "8 GB", "256 GB", "Exynos 990", "https://th.bing.com/th/id/OIP.DqrrtkyWayrMpehbBCI2xAHaEu?rs=1&pid=ImgDetMain")
            ];
        }
    }
}
