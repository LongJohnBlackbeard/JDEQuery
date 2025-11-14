using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980047 - .
/// </summary>
public class F980047 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTEDSNM.
        /// </summary>
        public const string DTEDSNM = "DTEDSNM";

        /// <summary>
        /// DTDESC.
        /// </summary>
        public const string DTDESC = "DTDESC";

        /// <summary>
        /// DTCRTU.
        /// </summary>
        public const string DTCRTU = "DTCRTU";

        /// <summary>
        /// DTSY.
        /// </summary>
        public const string DTSY = "DTSY";

        /// <summary>
        /// DTACTTYPE.
        /// </summary>
        public const string DTACTTYPE = "DTACTTYPE";

        /// <summary>
        /// DTCDAA.
        /// </summary>
        public const string DTCDAA = "DTCDAA";

        /// <summary>
        /// DTCDBB.
        /// </summary>
        public const string DTCDBB = "DTCDBB";

        /// <summary>
        /// DTFNDFUF1.
        /// </summary>
        public const string DTFNDFUF1 = "DTFNDFUF1";

        /// <summary>
        /// DTFNDFUF2.
        /// </summary>
        public const string DTFNDFUF2 = "DTFNDFUF2";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F980047";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTEDSNM", "DTEDSNM", JdeDataType.String, 22, true, true),
        new JdeField("DTDESC", "DTDESC", JdeDataType.String, 60),
        new JdeField("DTCRTU", "DTCRTU", JdeDataType.String, 20),
        new JdeField("DTSY", "DTSY", JdeDataType.String, 8),
        new JdeField("DTACTTYPE", "DTACTTYPE", JdeDataType.String, 4),
        new JdeField("DTCDAA", "DTCDAA", JdeDataType.String, 4),
        new JdeField("DTCDBB", "DTCDBB", JdeDataType.String, 4),
        new JdeField("DTFNDFUF1", "DTFNDFUF1", JdeDataType.String, 60),
        new JdeField("DTFNDFUF2", "DTFNDFUF2", JdeDataType.String, 60),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980047_0", "Primary Key on DTEDSNM", new[] { "DTEDSNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F980047_2", "Index on DTSY, DTCRTU", new[] { "DTSY", "DTCRTU" }),
        new JdeIndex("F980047_3", "Index on DTCRTU", new[] { "DTCRTU" })
    };
}
