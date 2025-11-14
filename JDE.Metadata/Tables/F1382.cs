using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1382 - .
/// </summary>
public class F1382 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ELEQGP.
        /// </summary>
        public const string ELEQGP = "ELEQGP";

        /// <summary>
        /// ELEQSP.
        /// </summary>
        public const string ELEQSP = "ELEQSP";

        /// <summary>
        /// ELSEQ.
        /// </summary>
        public const string ELSEQ = "ELSEQ";

        /// <summary>
        /// ELNUMB.
        /// </summary>
        public const string ELNUMB = "ELNUMB";

        /// <summary>
        /// ELAAID.
        /// </summary>
        public const string ELAAID = "ELAAID";

        /// <summary>
        /// ELAPID.
        /// </summary>
        public const string ELAPID = "ELAPID";

        /// <summary>
        /// ELASID.
        /// </summary>
        public const string ELASID = "ELASID";

        /// <summary>
        /// ELCO.
        /// </summary>
        public const string ELCO = "ELCO";

        /// <summary>
        /// ELSMTP.
        /// </summary>
        public const string ELSMTP = "ELSMTP";

        /// <summary>
        /// ELLVDT.
        /// </summary>
        public const string ELLVDT = "ELLVDT";

        /// <summary>
        /// ELDTFR.
        /// </summary>
        public const string ELDTFR = "ELDTFR";

        /// <summary>
        /// ELDTTO.
        /// </summary>
        public const string ELDTTO = "ELDTTO";

        /// <summary>
        /// ELEXAS.
        /// </summary>
        public const string ELEXAS = "ELEXAS";

        /// <summary>
        /// ELUSER.
        /// </summary>
        public const string ELUSER = "ELUSER";

        /// <summary>
        /// ELPID.
        /// </summary>
        public const string ELPID = "ELPID";

        /// <summary>
        /// ELMKEY.
        /// </summary>
        public const string ELMKEY = "ELMKEY";

        /// <summary>
        /// ELUPMJ.
        /// </summary>
        public const string ELUPMJ = "ELUPMJ";

        /// <summary>
        /// ELUPMT.
        /// </summary>
        public const string ELUPMT = "ELUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1382";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ELEQGP", "ELEQGP", JdeDataType.String, 60, true, true),
        new JdeField("ELEQSP", "ELEQSP", JdeDataType.String, 60, true, true),
        new JdeField("ELSEQ", "ELSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ELNUMB", "ELNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("ELAAID", "ELAAID", JdeDataType.Numeric),
        new JdeField("ELAPID", "ELAPID", JdeDataType.String, 24),
        new JdeField("ELASID", "ELASID", JdeDataType.String, 50),
        new JdeField("ELCO", "ELCO", JdeDataType.String, 10),
        new JdeField("ELSMTP", "ELSMTP", JdeDataType.String, 2),
        new JdeField("ELLVDT", "ELLVDT", JdeDataType.Numeric),
        new JdeField("ELDTFR", "ELDTFR", JdeDataType.Numeric),
        new JdeField("ELDTTO", "ELDTTO", JdeDataType.Numeric),
        new JdeField("ELEXAS", "ELEXAS", JdeDataType.String, 2),
        new JdeField("ELUSER", "ELUSER", JdeDataType.String, 20),
        new JdeField("ELPID", "ELPID", JdeDataType.String, 20),
        new JdeField("ELMKEY", "ELMKEY", JdeDataType.String, 30),
        new JdeField("ELUPMJ", "ELUPMJ", JdeDataType.Numeric),
        new JdeField("ELUPMT", "ELUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1382_0", "Primary Key on ELEQGP, ELEQSP, ELSEQ, ELNUMB", new[] { "ELEQGP", "ELEQSP", "ELSEQ", "ELNUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1382_2", "Index on ELEQGP, ELEQSP, ELLVDT", new[] { "ELEQGP", "ELEQSP", "ELLVDT" }),
        new JdeIndex("F1382_3", "Index on ELEQGP, ELEQSP, ELSEQ, ELAAID", new[] { "ELEQGP", "ELEQSP", "ELSEQ", "ELAAID" }),
        new JdeIndex("F1382_4", "Index on ELEQGP, ELEQSP, ELSEQ, SYS_NC00019$", new[] { "ELEQGP", "ELEQSP", "ELSEQ", "SYS_NC00019$" })
    };
}
