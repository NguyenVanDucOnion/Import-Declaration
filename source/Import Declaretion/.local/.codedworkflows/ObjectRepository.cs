using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ImportDeclaretion.ObjectRepository
{
    public static class Descriptors
    {
        public static class __ECUS5_VNACCS_2018__Electronic_Customs_Service
        {
            static string _reference = "bSOPBbyDJUag3brxNdIvPQ/nGLzsJh-tkOWVZDFbavyig";
            public static _Implementation.___ECUS5_VNACCS_2018__Electronic_Customs_Service.__ECUS5_VNACCS_2018__Electronic_Customs_Service ECUS5_VNACCS_2018__Electronic_Customs_Service { get; private set; } = new _Implementation.___ECUS5_VNACCS_2018__Electronic_Customs_Service.__ECUS5_VNACCS_2018__Electronic_Customs_Service();
        }
    }
}

namespace ImportDeclaretion._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace ___ECUS5_VNACCS_2018__Electronic_Customs_Service
    {
        public class __ECUS5_VNACCS_2018__Electronic_Customs_Service : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __ECUS5_VNACCS_2018__Electronic_Customs_Service()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "bSOPBbyDJUag3brxNdIvPQ/xGpn-qoQXEqCZb1AUZtJuw", DisplayName = "ECUS5-VNACCS 2018 (Electronic Customs Service", Screen = this};
            }
        }
    }
}