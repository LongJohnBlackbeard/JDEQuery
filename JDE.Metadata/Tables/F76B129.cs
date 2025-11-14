using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B129 - .
/// </summary>
public class F76B129 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCGIPF.
        /// </summary>
        public const string TCGIPF = "TCGIPF";

        /// <summary>
        /// TCFCO.
        /// </summary>
        public const string TCFCO = "TCFCO";

        /// <summary>
        /// TCGICNAE.
        /// </summary>
        public const string TCGICNAE = "TCGICNAE";

        /// <summary>
        /// TCGITXR.
        /// </summary>
        public const string TCGITXR = "TCGITXR";

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
    public override string TableName => "F76B129";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCGIPF", "TCGIPF", JdeDataType.String, 40, true, true),
        new JdeField("TCFCO", "TCFCO", JdeDataType.String, 10, true, true),
        new JdeField("TCGICNAE", "TCGICNAE", JdeDataType.String, 14),
        new JdeField("TCGITXR", "TCGITXR", JdeDataType.String, 4),
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
        new JdeIndex("F76B129_0", "Primary Key on TCGIPF, TCFCO", new[] { "TCGIPF", "TCFCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B129_2", "Index on TCGICNAE", new[] { "TCGICNAE" }),
        new JdeIndex("F76B129_3", "Index on TCGITXR", new[] { "TCGITXR" })
    };
}
