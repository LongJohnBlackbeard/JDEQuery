using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L001T - .
/// </summary>
public class F74L001T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LNK74LEDT.
        /// </summary>
        public const string LNK74LEDT = "LNK74LEDT";

        /// <summary>
        /// LNK74LECO.
        /// </summary>
        public const string LNK74LECO = "LNK74LECO";

        /// <summary>
        /// LNK74ISPL.
        /// </summary>
        public const string LNK74ISPL = "LNK74ISPL";

        /// <summary>
        /// LNK70DTFR.
        /// </summary>
        public const string LNK70DTFR = "LNK70DTFR";

        /// <summary>
        /// LNK70DTTO.
        /// </summary>
        public const string LNK70DTTO = "LNK70DTTO";

        /// <summary>
        /// LNL74VTCD.
        /// </summary>
        public const string LNL74VTCD = "LNL74VTCD";

        /// <summary>
        /// LNUSER.
        /// </summary>
        public const string LNUSER = "LNUSER";

        /// <summary>
        /// LNPID.
        /// </summary>
        public const string LNPID = "LNPID";

        /// <summary>
        /// LNJOBN.
        /// </summary>
        public const string LNJOBN = "LNJOBN";

        /// <summary>
        /// LNUPMJ.
        /// </summary>
        public const string LNUPMJ = "LNUPMJ";

        /// <summary>
        /// LNUPMT.
        /// </summary>
        public const string LNUPMT = "LNUPMT";

        /// <summary>
        /// LNYFUTDT.
        /// </summary>
        public const string LNYFUTDT = "LNYFUTDT";

        /// <summary>
        /// LNFFU4.
        /// </summary>
        public const string LNFFU4 = "LNFFU4";

        /// <summary>
        /// LNFUT3.
        /// </summary>
        public const string LNFUT3 = "LNFUT3";

        /// <summary>
        /// LNX2.
        /// </summary>
        public const string LNX2 = "LNX2";

        /// <summary>
        /// LNFUTCH1.
        /// </summary>
        public const string LNFUTCH1 = "LNFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F74L001T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LNK74LEDT", "LNK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("LNK74LECO", "LNK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("LNK74ISPL", "LNK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("LNK70DTFR", "LNK70DTFR", JdeDataType.Numeric),
        new JdeField("LNK70DTTO", "LNK70DTTO", JdeDataType.Numeric),
        new JdeField("LNL74VTCD", "LNL74VTCD", JdeDataType.String, 140),
        new JdeField("LNUSER", "LNUSER", JdeDataType.String, 20),
        new JdeField("LNPID", "LNPID", JdeDataType.String, 20),
        new JdeField("LNJOBN", "LNJOBN", JdeDataType.String, 20),
        new JdeField("LNUPMJ", "LNUPMJ", JdeDataType.Numeric),
        new JdeField("LNUPMT", "LNUPMT", JdeDataType.Numeric),
        new JdeField("LNYFUTDT", "LNYFUTDT", JdeDataType.Numeric),
        new JdeField("LNFFU4", "LNFFU4", JdeDataType.Numeric),
        new JdeField("LNFUT3", "LNFUT3", JdeDataType.String, 60),
        new JdeField("LNX2", "LNX2", JdeDataType.String, 2),
        new JdeField("LNFUTCH1", "LNFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L001T_0", "Primary Key on LNK74LEDT, LNK74LECO, LNK74ISPL", new[] { "LNK74LEDT", "LNK74LECO", "LNK74ISPL" }, isUnique: true, isPrimaryKey: true)
    };
}
