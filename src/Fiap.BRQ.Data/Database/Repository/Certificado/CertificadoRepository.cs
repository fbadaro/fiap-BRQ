namespace Fiap.BRQ.Data.Database.Repository.Certificado;

internal class CertificadoRepository : RepositorySQLBase<Core.Domain.Certificado, Guid>, ICertificadoRepository
{
    public CertificadoRepository(BRQDBContext context) : base(context)
    {
    }
}
