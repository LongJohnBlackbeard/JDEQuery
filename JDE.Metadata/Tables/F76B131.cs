using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B131 - .
/// </summary>
public class F76B131 : JdeTable
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
        /// TCGIKW.
        /// </summary>
        public const string TCGIKW = "TCGIKW";

        /// <summary>
        /// TCGIRT.
        /// </summary>
        public const string TCGIRT = "TCGIRT";

        /// <summary>
        /// TCGISBRT.
        /// </summary>
        public const string TCGISBRT = "TCGISBRT";

        /// <summary>
        /// TCGISTR.
        /// </summary>
        public const string TCGISTR = "TCGISTR";

        /// <summary>
        /// TCGIFF.
        /// </summary>
        public const string TCGIFF = "TCGIFF";

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
    public override string TableName => "F76B131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCGIPF", "TCGIPF", JdeDataType.String, 40, true, true),
        new JdeField("TCGIKW", "TCGIKW", JdeDataType.String, 60, true, true),
        new JdeField("TCGIRT", "TCGIRT", JdeDataType.String, 4, true, true),
        new JdeField("TCGISBRT", "TCGISBRT", JdeDataType.Numeric, null, true, true),
        new JdeField("TCGISTR", "TCGISTR", JdeDataType.String, 200),
        new JdeField("TCGIFF", "TCGIFF", JdeDataType.String, 900),
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
        new JdeIndex("F76B131_0", "Primary Key on TCGIPF, TCGIKW, TCGIRT, TCGISBRT", new[] { "TCGIPF", "TCGIKW", "TCGIRT", "TCGISBRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B131_2", "Index on TCGISTR", new[] { "TCGISTR" })
    };
}
