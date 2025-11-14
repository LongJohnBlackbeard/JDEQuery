using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4210 - .
/// </summary>
public class F76B4210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDSFXO.
        /// </summary>
        public const string SDSFXO = "SDSFXO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDB76CI.
        /// </summary>
        public const string SDB76CI = "SDB76CI";

        /// <summary>
        /// SDB76FCI.
        /// </summary>
        public const string SDB76FCI = "SDB76FCI";

        /// <summary>
        /// SDB76TIPI.
        /// </summary>
        public const string SDB76TIPI = "SDB76TIPI";

        /// <summary>
        /// SDB76NEV.
        /// </summary>
        public const string SDB76NEV = "SDB76NEV";

        /// <summary>
        /// SDB76NUM.
        /// </summary>
        public const string SDB76NUM = "SDB76NUM";

        /// <summary>
        /// SDB76AA.
        /// </summary>
        public const string SDB76AA = "SDB76AA";

        /// <summary>
        /// SDB76REF.
        /// </summary>
        public const string SDB76REF = "SDB76REF";

        /// <summary>
        /// SDB76COD.
        /// </summary>
        public const string SDB76COD = "SDB76COD";

        /// <summary>
        /// SDB76DATE.
        /// </summary>
        public const string SDB76DATE = "SDB76DATE";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDSFXO", "SDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDB76CI", "SDB76CI", JdeDataType.Numeric),
        new JdeField("SDB76FCI", "SDB76FCI", JdeDataType.String, 100),
        new JdeField("SDB76TIPI", "SDB76TIPI", JdeDataType.String, 6),
        new JdeField("SDB76NEV", "SDB76NEV", JdeDataType.String, 30),
        new JdeField("SDB76NUM", "SDB76NUM", JdeDataType.Numeric),
        new JdeField("SDB76AA", "SDB76AA", JdeDataType.Numeric),
        new JdeField("SDB76REF", "SDB76REF", JdeDataType.String, 30),
        new JdeField("SDB76COD", "SDB76COD", JdeDataType.String, 4),
        new JdeField("SDB76DATE", "SDB76DATE", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4210_0", "Primary Key on SDKCOO, SDDOCO, SDDCTO, SDSFXO, SDLNID", new[] { "SDKCOO", "SDDOCO", "SDDCTO", "SDSFXO", "SDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
