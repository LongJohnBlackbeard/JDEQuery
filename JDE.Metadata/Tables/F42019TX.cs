using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42019TX - .
/// </summary>
public class F42019TX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STKCOO.
        /// </summary>
        public const string STKCOO = "STKCOO";

        /// <summary>
        /// STDOCO.
        /// </summary>
        public const string STDOCO = "STDOCO";

        /// <summary>
        /// STDCTO.
        /// </summary>
        public const string STDCTO = "STDCTO";

        /// <summary>
        /// STUTP.
        /// </summary>
        public const string STUTP = "STUTP";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42019TX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STKCOO", "STKCOO", JdeDataType.String, 10, true, true),
        new JdeField("STDOCO", "STDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("STDCTO", "STDCTO", JdeDataType.String, 4, true, true),
        new JdeField("STUTP", "STUTP", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42019TX_0", "Primary Key on STDOCO, STDCTO, STKCOO", new[] { "STDOCO", "STDCTO", "STKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
