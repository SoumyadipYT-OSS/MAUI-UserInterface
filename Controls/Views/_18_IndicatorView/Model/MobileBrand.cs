namespace _18_IndicatorView.Model {
    public class MobileBrand(string brandName, string model, string ram, string storage, string processor, string imageSource) {
        public string BrandName { get; set; } = brandName;
        public string Model { get; set; } = model;
        public string RAM { get; set; } = ram;
        public string Storage { get; set; } = storage;
        public string Processor { get; set; } = processor;
        public string ImageSource { get; set; } = imageSource;
    }
}