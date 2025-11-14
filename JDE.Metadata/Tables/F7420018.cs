using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7420018 - .
/// </summary>
public class F7420018 : JdeTable
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
        /// STDCTO.
        /// </summary>
        public const string STDCTO = "STDCTO";

        /// <summary>
        /// STDOCO.
        /// </summary>
        public const string STDOCO = "STDOCO";

        /// <summary>
        /// STLNID.
        /// </summary>
        public const string STLNID = "STLNID";

        /// <summary>
        /// STK74TAXC.
        /// </summary>
        public const string STK74TAXC = "STK74TAXC";

        /// <summary>
        /// STTXR1.
        /// </summary>
        public const string STTXR1 = "STTXR1";

        /// <summary>
        /// STCO.
        /// </summary>
        public const string STCO = "STCO";

        /// <summary>
        /// STCRCD.
        /// </summary>
        public const string STCRCD = "STCRCD";

        /// <summary>
        /// STK74TAXD.
        /// </summary>
        public const string STK74TAXD = "STK74TAXD";

        /// <summary>
        /// STK74TAXF.
        /// </summary>
        public const string STK74TAXF = "STK74TAXF";

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
    public override string TableName => "F7420018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STKCOO", "STKCOO", JdeDataType.String, 10, true, true),
        new JdeField("STDCTO", "STDCTO", JdeDataType.String, 4, true, true),
        new JdeField("STDOCO", "STDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("STLNID", "STLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("STK74TAXC", "STK74TAXC", JdeDataType.String, 20, true, true),
        new JdeField("STTXR1", "STTXR1", JdeDataType.Numeric),
        new JdeField("STCO", "STCO", JdeDataType.String, 10),
        new JdeField("STCRCD", "STCRCD", JdeDataType.String, 6),
        new JdeField("STK74TAXD", "STK74TAXD", JdeDataType.Numeric),
        new JdeField("STK74TAXF", "STK74TAXF", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7420018_0", "Primary Key on STKCOO, STDCTO, STDOCO, STLNID, STK74TAXC", new[] { "STKCOO", "STDCTO", "STDOCO", "STLNID", "STK74TAXC" }, isUnique: true, isPrimaryKey: true)
    };
}
