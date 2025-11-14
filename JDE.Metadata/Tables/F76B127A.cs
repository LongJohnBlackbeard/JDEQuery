using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B127A - .
/// </summary>
public class F76B127A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCGIDBC.
        /// </summary>
        public const string TCGIDBC = "TCGIDBC";

        /// <summary>
        /// TCGIDBH.
        /// </summary>
        public const string TCGIDBH = "TCGIDBH";

        /// <summary>
        /// TCGIDBD.
        /// </summary>
        public const string TCGIDBD = "TCGIDBD";

        /// <summary>
        /// TCGIURC.
        /// </summary>
        public const string TCGIURC = "TCGIURC";

        /// <summary>
        /// TCGIURD.
        /// </summary>
        public const string TCGIURD = "TCGIURD";

        /// <summary>
        /// TCGIURA.
        /// </summary>
        public const string TCGIURA = "TCGIURA";

        /// <summary>
        /// TCGIURN.
        /// </summary>
        public const string TCGIURN = "TCGIURN";

        /// <summary>
        /// TCGIURR.
        /// </summary>
        public const string TCGIURR = "TCGIURR";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B127A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCGIDBC", "TCGIDBC", JdeDataType.String, 4, true, true),
        new JdeField("TCGIDBH", "TCGIDBH", JdeDataType.String, 600),
        new JdeField("TCGIDBD", "TCGIDBD", JdeDataType.String, 600),
        new JdeField("TCGIURC", "TCGIURC", JdeDataType.String, 4),
        new JdeField("TCGIURD", "TCGIURD", JdeDataType.Numeric),
        new JdeField("TCGIURA", "TCGIURA", JdeDataType.Numeric),
        new JdeField("TCGIURN", "TCGIURN", JdeDataType.Numeric),
        new JdeField("TCGIURR", "TCGIURR", JdeDataType.String, 30),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B127A_0", "Primary Key on TCGIDBC", new[] { "TCGIDBC" }, isUnique: true, isPrimaryKey: true)
    };
}
