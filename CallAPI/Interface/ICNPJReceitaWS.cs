using Refit;

namespace SysEstoque.CallAPI.Interface {
	internal interface ICNPJReceitaWS {
		// Recurso a ser buscado na URL https://receitaws.com.br/
		[Get("/v1/cnpj/{cnpj}")]
		//Task<string> GetAddressAsync(string cnpj);
		Task<CnpjDTO> GetAddressAsync(string cnpj);
	}
}
