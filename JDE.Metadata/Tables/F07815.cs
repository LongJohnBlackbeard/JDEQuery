using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07815 - .
/// </summary>
public class F07815 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YFIDYE.
        /// </summary>
        public const string YFIDYE = "YFIDYE";

        /// <summary>
        /// YFDTEY.
        /// </summary>
        public const string YFDTEY = "YFDTEY";

        /// <summary>
        /// YFBXNO.
        /// </summary>
        public const string YFBXNO = "YFBXNO";

        /// <summary>
        /// YFPDBA.
        /// </summary>
        public const string YFPDBA = "YFPDBA";

        /// <summary>
        /// YFUPMJ.
        /// </summary>
        public const string YFUPMJ = "YFUPMJ";

        /// <summary>
        /// YFUPMT.
        /// </summary>
        public const string YFUPMT = "YFUPMT";

        /// <summary>
        /// YFPID.
        /// </summary>
        public const string YFPID = "YFPID";

        /// <summary>
        /// YFJOBN.
        /// </summary>
        public const string YFJOBN = "YFJOBN";

        /// <summary>
        /// YFUSER.
        /// </summary>
        public const string YFUSER = "YFUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07815";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YFIDYE", "YFIDYE", JdeDataType.String, 20, true, true),
        new JdeField("YFDTEY", "YFDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YFBXNO", "YFBXNO", JdeDataType.String, 20, true, true),
        new JdeField("YFPDBA", "YFPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YFUPMJ", "YFUPMJ", JdeDataType.Numeric),
        new JdeField("YFUPMT", "YFUPMT", JdeDataType.Numeric),
        new JdeField("YFPID", "YFPID", JdeDataType.String, 20),
        new JdeField("YFJOBN", "YFJOBN", JdeDataType.String, 20),
        new JdeField("YFUSER", "YFUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07815_0", "Primary Key on YFIDYE, YFDTEY, YFBXNO, YFPDBA", new[] { "YFIDYE", "YFDTEY", "YFBXNO", "YFPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
