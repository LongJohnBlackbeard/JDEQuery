using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H001 - .
/// </summary>
public class F76H001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDH76LECO.
        /// </summary>
        public const string LDH76LECO = "LDH76LECO";

        /// <summary>
        /// LDH76LEDT.
        /// </summary>
        public const string LDH76LEDT = "LDH76LEDT";

        /// <summary>
        /// LDH76EMS.
        /// </summary>
        public const string LDH76EMS = "LDH76EMS";

        /// <summary>
        /// LDH76SEQ.
        /// </summary>
        public const string LDH76SEQ = "LDH76SEQ";

        /// <summary>
        /// LDH76LESA.
        /// </summary>
        public const string LDH76LESA = "LDH76LESA";

        /// <summary>
        /// LDH76NNFR.
        /// </summary>
        public const string LDH76NNFR = "LDH76NNFR";

        /// <summary>
        /// LDH76NNTO.
        /// </summary>
        public const string LDH76NNTO = "LDH76NNTO";

        /// <summary>
        /// LDH76NN.
        /// </summary>
        public const string LDH76NN = "LDH76NN";

        /// <summary>
        /// LDH76NNST.
        /// </summary>
        public const string LDH76NNST = "LDH76NNST";

        /// <summary>
        /// LDH76NNEX.
        /// </summary>
        public const string LDH76NNEX = "LDH76NNEX";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDH76LECO", "LDH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LDH76LEDT", "LDH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("LDH76EMS", "LDH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("LDH76SEQ", "LDH76SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LDH76LESA", "LDH76LESA", JdeDataType.String, 6),
        new JdeField("LDH76NNFR", "LDH76NNFR", JdeDataType.Numeric),
        new JdeField("LDH76NNTO", "LDH76NNTO", JdeDataType.Numeric),
        new JdeField("LDH76NN", "LDH76NN", JdeDataType.Numeric),
        new JdeField("LDH76NNST", "LDH76NNST", JdeDataType.String, 2),
        new JdeField("LDH76NNEX", "LDH76NNEX", JdeDataType.Numeric),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H001_0", "Primary Key on LDH76LECO, LDH76LEDT, LDH76EMS, LDH76SEQ", new[] { "LDH76LECO", "LDH76LEDT", "LDH76EMS", "LDH76SEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H001_2", "Index on LDH76LECO, LDH76LESA, LDH76EMS, LDH76SEQ", new[] { "LDH76LECO", "LDH76LESA", "LDH76EMS", "LDH76SEQ" }),
        new JdeIndex("F76H001_3", "Index on LDH76LECO, LDH76LEDT, LDH76EMS, SYS_NC00016$", new[] { "LDH76LECO", "LDH76LEDT", "LDH76EMS", "SYS_NC00016$" })
    };
}
