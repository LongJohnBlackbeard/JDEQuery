using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1690 - .
/// </summary>
public class F1690 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CKEAP.
        /// </summary>
        public const string CKEAP = "CKEAP";

        /// <summary>
        /// CKFILE.
        /// </summary>
        public const string CKFILE = "CKFILE";

        /// <summary>
        /// CKCMTF.
        /// </summary>
        public const string CKCMTF = "CKCMTF";

        /// <summary>
        /// CKOBID.
        /// </summary>
        public const string CKOBID = "CKOBID";

        /// <summary>
        /// CKCO02.
        /// </summary>
        public const string CKCO02 = "CKCO02";

        /// <summary>
        /// CKCO07.
        /// </summary>
        public const string CKCO07 = "CKCO07";

        /// <summary>
        /// CKCO08.
        /// </summary>
        public const string CKCO08 = "CKCO08";

        /// <summary>
        /// CKCO09.
        /// </summary>
        public const string CKCO09 = "CKCO09";

        /// <summary>
        /// CKCO10.
        /// </summary>
        public const string CKCO10 = "CKCO10";

        /// <summary>
        /// CKUSER.
        /// </summary>
        public const string CKUSER = "CKUSER";

        /// <summary>
        /// CKPID.
        /// </summary>
        public const string CKPID = "CKPID";

        /// <summary>
        /// CKUPMJ.
        /// </summary>
        public const string CKUPMJ = "CKUPMJ";

        /// <summary>
        /// CKTDAY.
        /// </summary>
        public const string CKTDAY = "CKTDAY";

        /// <summary>
        /// CKJOBN.
        /// </summary>
        public const string CKJOBN = "CKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1690";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CKEAP", "CKEAP", JdeDataType.String, 20, true, true),
        new JdeField("CKFILE", "CKFILE", JdeDataType.String, 20, true, true),
        new JdeField("CKCMTF", "CKCMTF", JdeDataType.String, 4, true, true),
        new JdeField("CKOBID", "CKOBID", JdeDataType.Numeric),
        new JdeField("CKCO02", "CKCO02", JdeDataType.String, 2),
        new JdeField("CKCO07", "CKCO07", JdeDataType.String, 2),
        new JdeField("CKCO08", "CKCO08", JdeDataType.String, 2),
        new JdeField("CKCO09", "CKCO09", JdeDataType.String, 2),
        new JdeField("CKCO10", "CKCO10", JdeDataType.String, 2),
        new JdeField("CKUSER", "CKUSER", JdeDataType.String, 20),
        new JdeField("CKPID", "CKPID", JdeDataType.String, 20),
        new JdeField("CKUPMJ", "CKUPMJ", JdeDataType.Numeric),
        new JdeField("CKTDAY", "CKTDAY", JdeDataType.Numeric),
        new JdeField("CKJOBN", "CKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1690_0", "Primary Key on CKCMTF, CKEAP, CKFILE", new[] { "CKCMTF", "CKEAP", "CKFILE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1690_2", "Index on CKCMTF, CKFILE", new[] { "CKCMTF", "CKFILE" }),
        new JdeIndex("F1690_3", "Index on CKCMTF, CKEAP", new[] { "CKCMTF", "CKEAP" })
    };
}
