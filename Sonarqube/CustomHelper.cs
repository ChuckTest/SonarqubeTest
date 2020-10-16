using System;
using Newtonsoft.Json;

namespace Chuck.Sonarqube
{
    public class FormConfigurationDetail
    {

    }

    public class CustomHelper
    {
        private string _formDetail;
        public string FormDetail
        {
            get
            {
                if (!string.IsNullOrEmpty(_formDetail))
                {
                    return _formDetail;
                }

                if (FormConfigurationDetail != null)
                {
                    _formDetail = JsonConvert.SerializeObject(FormConfigurationDetail);
                }

                return _formDetail;
            }
            set
            {
                SetFormConfigurationDetail(value);
            }
        }

        private FormConfigurationDetail _formConfigurationDetail;
        public FormConfigurationDetail FormConfigurationDetail
        {
            get
            {
                if (_formConfigurationDetail != null)
                {
                    return _formConfigurationDetail;
                }
                if (!string.IsNullOrEmpty(FormDetail))
                {
                    _formConfigurationDetail = JsonConvert.DeserializeObject<FormConfigurationDetail>(FormDetail);
                }
                return _formConfigurationDetail;
            }
            set
            {
                SetFormConfigurationDetail(value);
            }
        }

        private void SetFormConfigurationDetail(FormConfigurationDetail formConfigurationDetail)
        {
            if (formConfigurationDetail == null)
            {
                throw new ArgumentNullException(nameof(formConfigurationDetail));
            }

            _formConfigurationDetail = formConfigurationDetail;
        }

        private void SetFormConfigurationDetail(string formConfigurationDetail)
        {
            if (string.IsNullOrEmpty(formConfigurationDetail))
            {
                return;
            }
            SetFormConfigurationDetail(JsonConvert.DeserializeObject<FormConfigurationDetail>(formConfigurationDetail));
            _formDetail = formConfigurationDetail;
        }
    }
}
