using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05115 - .
/// </summary>
public class F05115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETAN8.
        /// </summary>
        public const string ETAN8 = "ETAN8";

        /// <summary>
        /// ETCMPC.
        /// </summary>
        public const string ETCMPC = "ETCMPC";

        /// <summary>
        /// ETSEQ.
        /// </summary>
        public const string ETSEQ = "ETSEQ";

        /// <summary>
        /// ETDGDT.
        /// </summary>
        public const string ETDGDT = "ETDGDT";

        /// <summary>
        /// ETINSTY.
        /// </summary>
        public const string ETINSTY = "ETINSTY";

        /// <summary>
        /// ETGPAR.
        /// </summary>
        public const string ETGPAR = "ETGPAR";

        /// <summary>
        /// ETGPAB.
        /// </summary>
        public const string ETGPAB = "ETGPAB";

        /// <summary>
        /// ETCLCT.
        /// </summary>
        public const string ETCLCT = "ETCLCT";

        /// <summary>
        /// ETHONR.
        /// </summary>
        public const string ETHONR = "ETHONR";

        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETPID.
        /// </summary>
        public const string ETPID = "ETPID";

        /// <summary>
        /// ETJOBN.
        /// </summary>
        public const string ETJOBN = "ETJOBN";

        /// <summary>
        /// ETUPMJ.
        /// </summary>
        public const string ETUPMJ = "ETUPMJ";

        /// <summary>
        /// ETUPMT.
        /// </summary>
        public const string ETUPMT = "ETUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETAN8", "ETAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ETCMPC", "ETCMPC", JdeDataType.String, 20, true, true),
        new JdeField("ETSEQ", "ETSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ETDGDT", "ETDGDT", JdeDataType.Numeric),
        new JdeField("ETINSTY", "ETINSTY", JdeDataType.String, 20),
        new JdeField("ETGPAR", "ETGPAR", JdeDataType.Numeric),
        new JdeField("ETGPAB", "ETGPAB", JdeDataType.Numeric),
        new JdeField("ETCLCT", "ETCLCT", JdeDataType.String, 60),
        new JdeField("ETHONR", "ETHONR", JdeDataType.String, 20),
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20),
        new JdeField("ETPID", "ETPID", JdeDataType.String, 20),
        new JdeField("ETJOBN", "ETJOBN", JdeDataType.String, 20),
        new JdeField("ETUPMJ", "ETUPMJ", JdeDataType.Numeric),
        new JdeField("ETUPMT", "ETUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05115_0", "Primary Key on ETAN8, ETCMPC, ETSEQ", new[] { "ETAN8", "ETCMPC", "ETSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05115_2", "Index on ETAN8, ETCMPC, SYS_NC00015$", new[] { "ETAN8", "ETCMPC", "SYS_NC00015$" }),
        new JdeIndex("F05115_4", "Index on ETINSTY", new[] { "ETINSTY" })
    };
}
