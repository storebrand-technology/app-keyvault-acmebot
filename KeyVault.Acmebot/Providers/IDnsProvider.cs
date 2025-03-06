using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace KeyVault.Acmebot.Providers;

public interface IDnsProvider
{
    int PropagationSeconds { get; }
    Task<IReadOnlyList<DnsZone>> ListZonesAsync(ILogger logger = null);
    Task CreateTxtRecordAsync(DnsZone zone, string relativeRecordName, IEnumerable<string> values);
    Task DeleteTxtRecordAsync(DnsZone zone, string relativeRecordName);
}
