using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07630 - .
/// </summary>
public class F07630 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMAN8.
        /// </summary>
        public const string LMAN8 = "LMAN8";

        /// <summary>
        /// LMRKID.
        /// </summary>
        public const string LMRKID = "LMRKID";

        /// <summary>
        /// LMLNID.
        /// </summary>
        public const string LMLNID = "LMLNID";

        /// <summary>
        /// LMLVST.
        /// </summary>
        public const string LMLVST = "LMLVST";

        /// <summary>
        /// LMLCMM.
        /// </summary>
        public const string LMLCMM = "LMLCMM";

        /// <summary>
        /// LMEEXX.
        /// </summary>
        public const string LMEEXX = "LMEEXX";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMUPMT.
        /// </summary>
        public const string LMUPMT = "LMUPMT";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F07630";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMAN8", "LMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LMRKID", "LMRKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LMLNID", "LMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LMLVST", "LMLVST", JdeDataType.String, 2),
        new JdeField("LMLCMM", "LMLCMM", JdeDataType.String, 600),
        new JdeField("LMEEXX", "LMEEXX", JdeDataType.String, 4),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMUPMT", "LMUPMT", JdeDataType.Numeric),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07630_0", "Primary Key on LMAN8, LMRKID, LMLNID", new[] { "LMAN8", "LMRKID", "LMLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
