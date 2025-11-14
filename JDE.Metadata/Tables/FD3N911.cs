using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N911 - .
/// </summary>
public class FD3N911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UCPLT.
        /// </summary>
        public const string UCPLT = "UCPLT";

        /// <summary>
        /// UCPAK.
        /// </summary>
        public const string UCPAK = "UCPAK";

        /// <summary>
        /// UCSCCN.
        /// </summary>
        public const string UCSCCN = "UCSCCN";

        /// <summary>
        /// UCSCCQ.
        /// </summary>
        public const string UCSCCQ = "UCSCCQ";

        /// <summary>
        /// UCSCUM.
        /// </summary>
        public const string UCSCUM = "UCSCUM";

        /// <summary>
        /// UCUPCN.
        /// </summary>
        public const string UCUPCN = "UCUPCN";

        /// <summary>
        /// UCUPQT.
        /// </summary>
        public const string UCUPQT = "UCUPQT";

        /// <summary>
        /// UCUPUM.
        /// </summary>
        public const string UCUPUM = "UCUPUM";

        /// <summary>
        /// UCPSN.
        /// </summary>
        public const string UCPSN = "UCPSN";

        /// <summary>
        /// UCSFX.
        /// </summary>
        public const string UCSFX = "UCSFX";

        /// <summary>
        /// UCMCU.
        /// </summary>
        public const string UCMCU = "UCMCU";

        /// <summary>
        /// UCDOCO.
        /// </summary>
        public const string UCDOCO = "UCDOCO";

        /// <summary>
        /// UCDCTO.
        /// </summary>
        public const string UCDCTO = "UCDCTO";

        /// <summary>
        /// UCKCOO.
        /// </summary>
        public const string UCKCOO = "UCKCOO";

        /// <summary>
        /// UCLNID.
        /// </summary>
        public const string UCLNID = "UCLNID";

        /// <summary>
        /// UCEXED.
        /// </summary>
        public const string UCEXED = "UCEXED";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UCPLT", "UCPLT", JdeDataType.String, 36, true, true),
        new JdeField("UCPAK", "UCPAK", JdeDataType.String, 36, true, true),
        new JdeField("UCSCCN", "UCSCCN", JdeDataType.String, 28, true, true),
        new JdeField("UCSCCQ", "UCSCCQ", JdeDataType.Numeric),
        new JdeField("UCSCUM", "UCSCUM", JdeDataType.String, 4),
        new JdeField("UCUPCN", "UCUPCN", JdeDataType.String, 26),
        new JdeField("UCUPQT", "UCUPQT", JdeDataType.Numeric),
        new JdeField("UCUPUM", "UCUPUM", JdeDataType.String, 4),
        new JdeField("UCPSN", "UCPSN", JdeDataType.Numeric),
        new JdeField("UCSFX", "UCSFX", JdeDataType.String, 6),
        new JdeField("UCMCU", "UCMCU", JdeDataType.String, 24),
        new JdeField("UCDOCO", "UCDOCO", JdeDataType.Numeric),
        new JdeField("UCDCTO", "UCDCTO", JdeDataType.String, 4),
        new JdeField("UCKCOO", "UCKCOO", JdeDataType.String, 10),
        new JdeField("UCLNID", "UCLNID", JdeDataType.Numeric),
        new JdeField("UCEXED", "UCEXED", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N911_0", "Primary Key on UCPLT, UCPAK, UCSCCN", new[] { "UCPLT", "UCPAK", "UCSCCN" }, isUnique: true, isPrimaryKey: true)
    };
}
