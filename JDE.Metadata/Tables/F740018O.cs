using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740018O - .
/// </summary>
public class F740018O : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTDOCO.
        /// </summary>
        public const string OTDOCO = "OTDOCO";

        /// <summary>
        /// OTDCTO.
        /// </summary>
        public const string OTDCTO = "OTDCTO";

        /// <summary>
        /// OTKCOO.
        /// </summary>
        public const string OTKCOO = "OTKCOO";

        /// <summary>
        /// OTSFXO.
        /// </summary>
        public const string OTSFXO = "OTSFXO";

        /// <summary>
        /// OTLNID.
        /// </summary>
        public const string OTLNID = "OTLNID";

        /// <summary>
        /// OTDOC.
        /// </summary>
        public const string OTDOC = "OTDOC";

        /// <summary>
        /// OTDCT.
        /// </summary>
        public const string OTDCT = "OTDCT";

        /// <summary>
        /// OTCO.
        /// </summary>
        public const string OTCO = "OTCO";

        /// <summary>
        /// OTNLIN.
        /// </summary>
        public const string OTNLIN = "OTNLIN";

        /// <summary>
        /// OT74TRAN.
        /// </summary>
        public const string OT74TRAN = "OT74TRAN";

        /// <summary>
        /// OT74OOPA.
        /// </summary>
        public const string OT74OOPA = "OT74OOPA";

        /// <summary>
        /// OTDGJ.
        /// </summary>
        public const string OTDGJ = "OTDGJ";

        /// <summary>
        /// OTDSVJ.
        /// </summary>
        public const string OTDSVJ = "OTDSVJ";

        /// <summary>
        /// OTAG.
        /// </summary>
        public const string OTAG = "OTAG";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTJOBN.
        /// </summary>
        public const string OTJOBN = "OTJOBN";

        /// <summary>
        /// OTUPMJ.
        /// </summary>
        public const string OTUPMJ = "OTUPMJ";

        /// <summary>
        /// OTUPMT.
        /// </summary>
        public const string OTUPMT = "OTUPMT";

        /// <summary>
        /// OTFFG1.
        /// </summary>
        public const string OTFFG1 = "OTFFG1";

        /// <summary>
        /// OTFFU3.
        /// </summary>
        public const string OTFFU3 = "OTFFU3";

        /// <summary>
        /// OTFFU4.
        /// </summary>
        public const string OTFFU4 = "OTFFU4";

        /// <summary>
        /// OTPYID.
        /// </summary>
        public const string OTPYID = "OTPYID";

        /// <summary>
        /// OTAA1.
        /// </summary>
        public const string OTAA1 = "OTAA1";

        /// <summary>
        /// OTSFX.
        /// </summary>
        public const string OTSFX = "OTSFX";

        /// <summary>
        /// OTPAAP.
        /// </summary>
        public const string OTPAAP = "OTPAAP";

        /// <summary>
        /// OTPFAP.
        /// </summary>
        public const string OTPFAP = "OTPFAP";

        /// <summary>
        /// OTTAAP.
        /// </summary>
        public const string OTTAAP = "OTTAAP";
    }

    /// <inheritdoc />
    public override string TableName => "F740018O";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTDOCO", "OTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OTDCTO", "OTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OTKCOO", "OTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OTSFXO", "OTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("OTLNID", "OTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTDOC", "OTDOC", JdeDataType.Numeric),
        new JdeField("OTDCT", "OTDCT", JdeDataType.String, 4),
        new JdeField("OTCO", "OTCO", JdeDataType.String, 10),
        new JdeField("OTNLIN", "OTNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("OT74TRAN", "OT74TRAN", JdeDataType.String, 60),
        new JdeField("OT74OOPA", "OT74OOPA", JdeDataType.String, 2),
        new JdeField("OTDGJ", "OTDGJ", JdeDataType.Numeric),
        new JdeField("OTDSVJ", "OTDSVJ", JdeDataType.Numeric),
        new JdeField("OTAG", "OTAG", JdeDataType.Numeric),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTJOBN", "OTJOBN", JdeDataType.String, 20),
        new JdeField("OTUPMJ", "OTUPMJ", JdeDataType.Numeric),
        new JdeField("OTUPMT", "OTUPMT", JdeDataType.Numeric),
        new JdeField("OTFFG1", "OTFFG1", JdeDataType.String, 2),
        new JdeField("OTFFU3", "OTFFU3", JdeDataType.String, 20),
        new JdeField("OTFFU4", "OTFFU4", JdeDataType.Numeric),
        new JdeField("OTPYID", "OTPYID", JdeDataType.Numeric),
        new JdeField("OTAA1", "OTAA1", JdeDataType.Numeric),
        new JdeField("OTSFX", "OTSFX", JdeDataType.String, 6),
        new JdeField("OTPAAP", "OTPAAP", JdeDataType.Numeric),
        new JdeField("OTPFAP", "OTPFAP", JdeDataType.Numeric),
        new JdeField("OTTAAP", "OTTAAP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740018O_0", "Primary Key on OTDOCO, OTDCTO, OTKCOO, OTSFXO, OTLNID, OTNLIN", new[] { "OTDOCO", "OTDCTO", "OTKCOO", "OTSFXO", "OTLNID", "OTNLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
