namespace Fiap.BRQ.Data.Repository.Certificado;

public class CertificadoRepository : RepositorySQLBase<Core.Domain.Certificado, Guid>, ICertificadoRepository
{
    public CertificadoRepository(BRQDBContext context) : base(context)
    {
    }
}
