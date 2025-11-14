using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5103 - .
/// </summary>
public class F5103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKMCURPO.
        /// </summary>
        public const string TKMCURPO = "TKMCURPO";

        /// <summary>
        /// TKMCU.
        /// </summary>
        public const string TKMCU = "TKMCU";

        /// <summary>
        /// TKAID.
        /// </summary>
        public const string TKAID = "TKAID";

        /// <summary>
        /// TKLNID.
        /// </summary>
        public const string TKLNID = "TKLNID";

        /// <summary>
        /// TKSUB.
        /// </summary>
        public const string TKSUB = "TKSUB";

        /// <summary>
        /// TKOBJ.
        /// </summary>
        public const string TKOBJ = "TKOBJ";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F5103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKMCURPO", "TKMCURPO", JdeDataType.String, 16, true, true),
        new JdeField("TKMCU", "TKMCU", JdeDataType.String, 24),
        new JdeField("TKAID", "TKAID", JdeDataType.String, 16),
        new JdeField("TKLNID", "TKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TKSUB", "TKSUB", JdeDataType.String, 16),
        new JdeField("TKOBJ", "TKOBJ", JdeDataType.String, 12),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5103_0", "Primary Key on TKMCURPO, TKLNID", new[] { "TKMCURPO", "TKLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5103_2", "Index on TKAID, TKLNID", new[] { "TKAID", "TKLNID" })
    };
}
