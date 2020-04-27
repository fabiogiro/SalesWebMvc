using System;

namespace Aula226_CriacaoProjeto_SalesWebMvc.Models {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}