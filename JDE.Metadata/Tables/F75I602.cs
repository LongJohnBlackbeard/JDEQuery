using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I602 - .
/// </summary>
public class F75I602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBMCU.
        /// </summary>
        public const string IBMCU = "IBMCU";

        /// <summary>
        /// IBITM.
        /// </summary>
        public const string IBITM = "IBITM";

        /// <summary>
        /// IBI75SRP1.
        /// </summary>
        public const string IBI75SRP1 = "IBI75SRP1";

        /// <summary>
        /// IBI75SRP2.
        /// </summary>
        public const string IBI75SRP2 = "IBI75SRP2";

        /// <summary>
        /// IBI75SRP3.
        /// </summary>
        public const string IBI75SRP3 = "IBI75SRP3";

        /// <summary>
        /// IBI75SRP4.
        /// </summary>
        public const string IBI75SRP4 = "IBI75SRP4";

        /// <summary>
        /// IBI75SRP5.
        /// </summary>
        public const string IBI75SRP5 = "IBI75SRP5";

        /// <summary>
        /// IBI75SRP6.
        /// </summary>
        public const string IBI75SRP6 = "IBI75SRP6";

        /// <summary>
        /// IBI75SRP7.
        /// </summary>
        public const string IBI75SRP7 = "IBI75SRP7";

        /// <summary>
        /// IBI75SRP8.
        /// </summary>
        public const string IBI75SRP8 = "IBI75SRP8";

        /// <summary>
        /// IBI75SRP9.
        /// </summary>
        public const string IBI75SRP9 = "IBI75SRP9";

        /// <summary>
        /// IBI75SRP0.
        /// </summary>
        public const string IBI75SRP0 = "IBI75SRP0";

        /// <summary>
        /// IBI75PRP1.
        /// </summary>
        public const string IBI75PRP1 = "IBI75PRP1";

        /// <summary>
        /// IBI75PRP2.
        /// </summary>
        public const string IBI75PRP2 = "IBI75PRP2";

        /// <summary>
        /// IBI75PRP3.
        /// </summary>
        public const string IBI75PRP3 = "IBI75PRP3";

        /// <summary>
        /// IBI75PRP4.
        /// </summary>
        public const string IBI75PRP4 = "IBI75PRP4";

        /// <summary>
        /// IBI75PRP5.
        /// </summary>
        public const string IBI75PRP5 = "IBI75PRP5";

        /// <summary>
        /// IBI75PRP6.
        /// </summary>
        public const string IBI75PRP6 = "IBI75PRP6";

        /// <summary>
        /// IBI75PRP7.
        /// </summary>
        public const string IBI75PRP7 = "IBI75PRP7";

        /// <summary>
        /// IBI75PRP8.
        /// </summary>
        public const string IBI75PRP8 = "IBI75PRP8";

        /// <summary>
        /// IBI75PRP9.
        /// </summary>
        public const string IBI75PRP9 = "IBI75PRP9";

        /// <summary>
        /// IBI75PRP0.
        /// </summary>
        public const string IBI75PRP0 = "IBI75PRP0";

        /// <summary>
        /// IBI75SHCM.
        /// </summary>
        public const string IBI75SHCM = "IBI75SHCM";

        /// <summary>
        /// IBI75SHCN.
        /// </summary>
        public const string IBI75SHCN = "IBI75SHCN";

        /// <summary>
        /// IBI75CYCL.
        /// </summary>
        public const string IBI75CYCL = "IBI75CYCL";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBUPMT.
        /// </summary>
        public const string IBUPMT = "IBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBMCU", "IBMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBITM", "IBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBI75SRP1", "IBI75SRP1", JdeDataType.String, 6),
        new JdeField("IBI75SRP2", "IBI75SRP2", JdeDataType.String, 6),
        new JdeField("IBI75SRP3", "IBI75SRP3", JdeDataType.String, 6),
        new JdeField("IBI75SRP4", "IBI75SRP4", JdeDataType.String, 6),
        new JdeField("IBI75SRP5", "IBI75SRP5", JdeDataType.String, 6),
        new JdeField("IBI75SRP6", "IBI75SRP6", JdeDataType.String, 12),
        new JdeField("IBI75SRP7", "IBI75SRP7", JdeDataType.String, 12),
        new JdeField("IBI75SRP8", "IBI75SRP8", JdeDataType.String, 12),
        new JdeField("IBI75SRP9", "IBI75SRP9", JdeDataType.String, 12),
        new JdeField("IBI75SRP0", "IBI75SRP0", JdeDataType.String, 12),
        new JdeField("IBI75PRP1", "IBI75PRP1", JdeDataType.String, 6),
        new JdeField("IBI75PRP2", "IBI75PRP2", JdeDataType.String, 6),
        new JdeField("IBI75PRP3", "IBI75PRP3", JdeDataType.String, 6),
        new JdeField("IBI75PRP4", "IBI75PRP4", JdeDataType.String, 6),
        new JdeField("IBI75PRP5", "IBI75PRP5", JdeDataType.String, 6),
        new JdeField("IBI75PRP6", "IBI75PRP6", JdeDataType.String, 12),
        new JdeField("IBI75PRP7", "IBI75PRP7", JdeDataType.String, 12),
        new JdeField("IBI75PRP8", "IBI75PRP8", JdeDataType.String, 12),
        new JdeField("IBI75PRP9", "IBI75PRP9", JdeDataType.String, 12),
        new JdeField("IBI75PRP0", "IBI75PRP0", JdeDataType.String, 12),
        new JdeField("IBI75SHCM", "IBI75SHCM", JdeDataType.String, 6),
        new JdeField("IBI75SHCN", "IBI75SHCN", JdeDataType.String, 6),
        new JdeField("IBI75CYCL", "IBI75CYCL", JdeDataType.String, 6),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBUPMT", "IBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I602_0", "Primary Key on IBMCU, IBITM", new[] { "IBMCU", "IBITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I602_2", "Index on IBITM, IBMCU", new[] { "IBITM", "IBMCU" })
    };
}
